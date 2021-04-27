using euroPlus4_1.Models;
using euroPlus4_1.Models.Comm;
using euroPlus4_1.Views;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace euroPlus4_1.ViewModels
{
    class GerenciarDadosViewModel:INotifyPropertyChanged
    {
        public string ConteudoMensagem { get; set; }
        public bool MostrarMensagem { get; set; }

        public GerenciarDadosModel ArquivoSelecionado { get; set; }
        public GerenciarDadosModel GerenciarDados { get; set; }

        public ObservableCollection<GerenciarDadosModel> ListaDeDados { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SalvarDados { get; set; }
        public ICommand CarregarDados { get; set; }
        public ICommand ExcluirDados { get; set; }
        public string NomeDoArquivo { get; set; }
        public int IdArquivo { get; set; }

        MainWindow _window;
       
        MetroDialogSettings metroDialogSettings = new MetroDialogSettings();
        public GerenciarDadosViewModel(MainWindow main)
        {
            _window = main;          
            GerenciarDados = new GerenciarDadosModel();
            SalvarDados = new RelayCommand(SalvaDados);
            CarregarDados = new RelayCommand(CarregaDados);
            ExcluirDados = new RelayCommand(RemoveUsuário);
            AtualizaListaDeDados();
        }

        //Inicio dos metodos
       async void SalvaDados(object obj)
        {
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Ok";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;

            List<object> _listParametro = new List<object>();
            GerenciarDados.DataCriacao = DateTime.Now.ToString();
            GerenciarDados.UsuarioCriador = _window.UsuarioCorrente;
            
            if (EtherCAT.CommOK) 
                {
                try
                {
                    if (GerenciarDados.NomeArquivo.Trim() == "" || GerenciarDados.NomeArquivo == null)
                    {
                       await _window.ShowMessageAsync("Nome de arquivo", "O nome do arquivo não pode estar em branco.", MessageDialogStyle.Affirmative, metroDialogSettings);
                        return;
                    }
                }
                catch
                {
                   await _window.ShowMessageAsync("Nome de arquivo", "O nome do arquivo não pode estar em branco.", MessageDialogStyle.Affirmative, metroDialogSettings);
                    return;
                }
                    try
                    {
                        GerenciarDados.DataCriacao = DateTime.Now.ToString();
                        GerenciarDados.UsuarioCriador = _window.UsuarioCorrente;
                    
                    for (int i = 0; i <= 2; i++)
                    {
                        _listParametro.Add(EtherCAT.InicializarVariaveisEstacoes()[i]);
                    }
                    
                    for (int i = 0; i <= 1; i++)
                    {
                        _listParametro.Add(EtherCAT.InicializarVariaveisTemperaturas()[i]);
                    }

                    _listParametro.Add(EtherCAT.InicializarVariaveisBombaHidraulica()[4]);

                    for (int i = 0; i <= 1; i++)
                    {
                        _listParametro.Add(EtherCAT.InicializarVariaveisTemposFrequencias()[i]);
                    }                        
                        GerenciarDados.ListaDeParametros = _listParametro;
                    if (await GerenciarDados.AdicionaDados(GerenciarDados))
                    {
                        await _window.ShowMessageAsync("Dados salvos", string.Format("O arquivo {0} foi criado com sucesso por {1} na data e hora {2}", GerenciarDados.NomeArquivo,
                                GerenciarDados.UsuarioCriador, GerenciarDados.DataCriacao), MessageDialogStyle.Affirmative, metroDialogSettings);
                         AtualizaListaDeDados();
                    }
                    else 
                    {
                        await _window.ShowMessageAsync("Falha ao salvar dados", "Não foi possível salvar os dados devido a uma anormalidade dos dados coletados do controlador, verifique as condições de comunicação.",
                            MessageDialogStyle.Affirmative, metroDialogSettings);

                    }

                    GerenciarDados.NomeArquivo = "";
                    RaiseChange("GerenciarDados");
                    }
                    catch
                    {
                         await _window.ShowMessageAsync("Inconsistência de dados", "Houve uma anormalidade nos campos dos dados inseridos, verifique-os e volte a salvar os dados.", MessageDialogStyle.Affirmative, metroDialogSettings);
                        GerenciarDados.ListaDeParametros = null;
                    }
                                        
                }
                else
                {
                     await _window.ShowMessageAsync("Conexão não estabelecida", "Para salvar os parâmetros é necessario uma comunicação com o controlador.", MessageDialogStyle.Affirmative, metroDialogSettings);
                }


            
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

                if (ArquivoSelecionado !=null)
                {

                    if (await _window.ShowMessageAsync("Excluir arquivo", string.Format("Apagar permanentemente o arquivo {0} da base de dados ? ", ArquivoSelecionado.NomeArquivo),
                        MessageDialogStyle.AffirmativeAndNegative, metroDialogSettings) == MessageDialogResult.Affirmative)
                    {
                        await GerenciarDados.RemoveDados(ArquivoSelecionado.NomeArquivo) ;
                        AtualizaListaDeDados();
                    }
                    else
                    {
                        AtualizaListaDeDados();
                    }

                }
                else
                {
                    metroDialogSettings.AffirmativeButtonText = "Ok";
                    await _window.ShowMessageAsync("Seleção incorreta", string.Format("Selecione ao menos um arquivo para remover da base de dados."),
                                        MessageDialogStyle.Affirmative, metroDialogSettings);
                }
            }
            catch (System.NullReferenceException)
            {
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Seleção incorreta", string.Format("Selecione ao menos um arquivo para remover da base de dados."),
                                    MessageDialogStyle.Affirmative, metroDialogSettings);
            }
            catch (Exception)
            {
                metroDialogSettings.AffirmativeButtonText = "Ok";
                await _window.ShowMessageAsync("Falha de acesso", string.Format("Verifique se o arquivo pode ser excluído da base de dados."),
                                    MessageDialogStyle.Affirmative, metroDialogSettings);
            }
        }


        public async void AtualizaListaDeDados()
        {
            ListaDeDados = await GerenciarDados.RetornaListaDados();
            RaiseChange("ListaDeDados");
        }

        public async void CarregaDados(object obj)
        {
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Ok";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;

            GerenciarDadosModel dadosCarregamento = new GerenciarDadosModel();
            if (EtherCAT.CommOK && await _window.ShowMessageAsync("Carregar arquivo",string.Format("Deseja carregar os dados do arquivo {0} no controlador ?", ArquivoSelecionado.NomeArquivo), 
                MessageDialogStyle.AffirmativeAndNegative, metroDialogSettings)== MessageDialogResult.Affirmative)
            {
                try
                {
                    EtherCAT.CarregamentoDeDados = true;
                    dadosCarregamento = GerenciarDados.CarregarDados(ArquivoSelecionado.NomeArquivo).Result;                    
                    EtherCAT.EnviarArquivoParametros(dadosCarregamento.ListaDeParametros);
                    await _window.ShowMessageAsync("Dados carregados", "Os dados foram carregados com sucesso no controlador.", MessageDialogStyle.Affirmative, metroDialogSettings);
                }
                catch
                {
                    await _window.ShowMessageAsync("Erro de carregamento", "Uma falha de comunicação e/ou integridade de dados impossibilitou o envio de dados.", MessageDialogStyle.Affirmative, metroDialogSettings);
                }
            }
            else
            {
                await _window.ShowMessageAsync("Comunicação não estabelecida", "Não há comunicação com nenhum controlador, os dados não podem ser enviados e carregados.", MessageDialogStyle.Affirmative, metroDialogSettings);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------

        //Apresentação de Mensagem de pop-up-----------------------------------------------------------------------------------------------------
        void ApresentaMensagem(object obj)
        {

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
