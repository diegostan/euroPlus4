using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using euroPlus4_1.Models;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Controls.Primitives;
using MahApps.Metro.Controls.Dialogs;

namespace euroPlus4_1.ViewModels
{
    class UsuariosViewModel: INotifyPropertyChanged
    {       
        //Propriedades--------------------------------------------------------------------------------------------
        public UsuarioModel UsuarioAdd { get; set; }

        public ICommand AdicionarUsuario { get; set; }
        public ICommand RemoverUsuario { get; set; }

        public ICommand AtualizarNiveisTelas { get; set; }
        public ICommand AtualizarListaDeTelas { get; set; }

        public string ConteudoMensagem { get; set; }
        public bool MostrarMensagem { get; set; }

        public ObservableCollection<UsuarioModel> ListaDeUsuarios { get; private set; }

        public ObservableCollection<TelasModel> ListaDeTelas { get; set; }
        
        public UsuarioModel UsuarioSelecionado { get; set; }

        public TelasModel TelaSelecionada { get; set; }

        public TelasModel TelasDisponiveis { get; set; }

        Task _taskAtualizarListaDeUsuarios;

        Task _taskAtualizarListaDeTelas;

        MainWindow _window;

        MetroDialogSettings metroDialogSettings = new MetroDialogSettings();


        public event PropertyChangedEventHandler PropertyChanged;

        public UsuariosViewModel(MainWindow main)
        {
            _window = main;
            UsuarioAdd = new UsuarioModel();
            UsuarioSelecionado = new UsuarioModel();
            TelaSelecionada = new TelasModel();
            AdicionarUsuario = new RelayCommand(AdicionaUsuario);
            RemoverUsuario = new RelayCommand(RemoveUsuário);
            AtualizarNiveisTelas = new RelayCommand(AtualizaNiveisTelas);
            AtualizarListaDeTelas = new RelayCommand((object obj)=>AtualizaListaDeTelas());

            _taskAtualizarListaDeUsuarios = new Task(AtualizaListaDeUsuarios);
            _taskAtualizarListaDeUsuarios.Start();

            _taskAtualizarListaDeTelas = new Task(AtualizaListaDeTelas);
            _taskAtualizarListaDeTelas.Start();
        }

        //Comandos-------------------------------------------------------------------------------------------------------------------------------
        async void AdicionaUsuario(object obj)
        {
            try
            {

                metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
                metroDialogSettings.AffirmativeButtonText = "Sim";
                metroDialogSettings.NegativeButtonText = "Não";
                metroDialogSettings.DialogTitleFontSize = 30;
                metroDialogSettings.DialogMessageFontSize = 24;

                if (UsuarioAdd!= null && UsuarioAdd.Nome.Trim()!="" && UsuarioAdd.Senha.Trim()!="" && UsuarioAdd.DicaSenha.Trim() != ""
                    && UsuarioAdd.Nome != null && UsuarioAdd.Senha != null && UsuarioAdd.DicaSenha != null)
                {
                      if (UsuarioAdd.RFID == null) UsuarioAdd.RFID = "";
                      UsuarioAdd.DataCriacao = DateTime.Now.ToShortDateString();
                        if(await UsuarioAdd.AdicionaUsuario(UsuarioAdd))
                        {
                        await _window.ShowMessageAsync("Usuário criado", string.Format("O usuário {0} foi criado com sucesso e inserido na base de dados.", UsuarioAdd.Nome),
                                        MessageDialogStyle.Affirmative, metroDialogSettings);
                        AtualizaListaDeUsuarios();
                        UsuarioAdd.Nome ="";
                        UsuarioAdd.Senha = "";
                        UsuarioAdd.RFID = "";
                        UsuarioAdd.DicaSenha = "";
                        UsuarioAdd.Nivel = 1;
                        RaiseChange("UsuarioAdd");
                        }
                    else
                    {
                        metroDialogSettings.AffirmativeButtonText = "Ok";
                        await _window.ShowMessageAsync("Erro ao criar usuário", string.Format("Falha na padronização da tabela de usuários, tente restaurar a base de dados ou verifique a consistência de dados." +
                            " Você está tentando criar um usuário com um nome ou RFID já existente ?"),
                                            MessageDialogStyle.Affirmative, metroDialogSettings);
                    }
                    
                }
                else
                {
                    metroDialogSettings.AffirmativeButtonText = "Ok";
                    await _window.ShowMessageAsync("Erro ao criar usuário", string.Format("Houve uma falha na consistência dos dados, você preencheu os campos corretamente ?"),
                                        MessageDialogStyle.Affirmative, metroDialogSettings);
                }
            }
            catch (System.NullReferenceException)
            {
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Erro ao criar usuário", string.Format("Houve uma falha na consistência dos dados, você preencheu os campos corretamente ?"),
                                        MessageDialogStyle.Affirmative, metroDialogSettings);
            }
            catch (Exception)
            {
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Erro ao criar usuário", string.Format("Não houve resposta da base de dados"),
                                        MessageDialogStyle.Affirmative, metroDialogSettings);
            }
        }

        public async void AtualizaListaDeUsuarios()
        {            
            ListaDeUsuarios = await UsuarioAdd.RetornaListaUsuarios();
            RaiseChange("ListaDeUsuarios");
        }


         void ListaUsuarios(object obj)
        {
                        
            _taskAtualizarListaDeUsuarios.Start();

        }
        async void RemoveUsuário(object obj)
        {
            try
            {
                
                metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
                metroDialogSettings.AffirmativeButtonText = "Sim";
                metroDialogSettings.NegativeButtonText = "Não";
                metroDialogSettings.DialogTitleFontSize = 30;
                metroDialogSettings.DialogMessageFontSize = 24;           
                      
            if (UsuarioSelecionado.ID > 0 || UsuarioSelecionado == null) 
            {                
            
                if (await _window.ShowMessageAsync("Excluir usuário", string.Format("Apagar permanentemente o usuário {0} da base de dados ? ", UsuarioSelecionado.Nome),                
                    MessageDialogStyle.AffirmativeAndNegative, metroDialogSettings) == MessageDialogResult.Affirmative)            
                {                
                    await UsuarioAdd.RemoveUsuario(UsuarioSelecionado.ID);                
                    AtualizaListaDeUsuarios();            
                }            
                else            
                {                
                    AtualizaListaDeUsuarios();            
                }
           
            }
            else
            {
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Seleção incorreta", string.Format("Selecione ao menos um usuário para remover da base de dados."),
                                    MessageDialogStyle.Affirmative, metroDialogSettings);
            }
            }
            catch(System.NullReferenceException)
            {
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Seleção incorreta", string.Format("Selecione ao menos um usuário para remover da base de dados."),
                                    MessageDialogStyle.Affirmative, metroDialogSettings);
            }
            catch(Exception)
            {
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Falha de acesso", string.Format("Verifique se o usuário pode ser excluído da base de dados."),
                                    MessageDialogStyle.Affirmative, metroDialogSettings);
            }
        }

        public async void AtualizaListaDeTelas()
        {
            TelasDisponiveis = new TelasModel();
            ListaDeTelas = await TelasDisponiveis.RetornaTelas();
            RaiseChange("TelasDisponiveis");
            RaiseChange("ListaDeTelas");
        }

        async void AtualizaNiveisTelas(object obj)
        {

            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Sim";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;

            TelasDisponiveis = new TelasModel();
            try 
            {                         
                foreach (var item in ListaDeTelas)            
                {
                    if (item.Nivel >= 10) item.Nivel = 10;
                    await TelasDisponiveis.AtualizaTelas(item);            
                }
                        
                AtualizaListaDeTelas();
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Niveis atualizados", string.Format("As configurações de niveis foram salvas com sucesso na base de dados."),
                                    MessageDialogStyle.Affirmative, metroDialogSettings);
                RaiseChange("ListaDeTelas");
            }
            catch
            {
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Falha na atualização", string.Format("Não foi possível atualizar os níveis das telas. Você preencheu corretamente os campos?"),
                                    MessageDialogStyle.Affirmative, metroDialogSettings);
                RaiseChange("ListaDeTelas");
            }



        }
        //Fim comandos---------------------------------------------------------------------------------------------------------------------------


        //Apresentação de Mensagem de pop-up-----------------------------------------------------------------------------------------------------
        void ApresentaMensagem(object obj)
        {
            ConteudoMensagem = ((MensagemPop)obj).Mensagem.ToString();
            MostrarMensagem = true;
            RaiseChange("ConteudoMensagem");
            RaiseChange("MostrarMensagem");
        }
        //---------------------------------------------------------------------------------------------------------------------------------------

        //Raise Change --------------------------------------------------------------------------------------------------------------------------
        void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        //Fim raise Change --------------------------------------------------------------------------------------------------------------------------
    }
}
