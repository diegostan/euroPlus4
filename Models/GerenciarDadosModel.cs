using euroPlus4_1.Models.Data;
using euroPlus4_1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1.Models
{
    class GerenciarDadosModel
    {
        public string NomeArquivo { get; set; }
        public string DataCriacao { get; set; }
        public string UsuarioCriador { get; set; }
        
        public List<object> ListaDeParametros { get; set; }

        public GerenciarDadosModel()
        {
            ListaDeParametros = new List<object>();
        }

        //Adicionar Dados
        public async Task<bool> AdicionaDados(GerenciarDadosModel dados)
        {
            if (await VerificarDuplicidade(dados.NomeArquivo))
            {
                return false;
            }
            string strCommand = string.Format("use [sysEP4];Insert into DadosParametros(NomeArquivo, DataCriacao, UsuarioCriador, Parametro1, Parametro2, Parametro3, Parametro4, Parametro5, Parametro6, Parametro7, " +
                "Parametro8)" +
                " Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                dados.NomeArquivo.ToLower().Trim(), dados.DataCriacao, dados.UsuarioCriador, ListaDeParametros[0].ToString(), ListaDeParametros[1].ToString(), ListaDeParametros[2].ToString(), ListaDeParametros[3].ToString(),
                ListaDeParametros[4].ToString(), ListaDeParametros[5].ToString(), ListaDeParametros[6].ToString(), ListaDeParametros[7].ToString());
            try
            {
                using (SQLDataModel data = new SQLDataModel())
                {
                    await data.Connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(strCommand, data.Connection))
                    {
                        await command.ExecuteNonQueryAsync();
                        
                    }                    
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Verifica duplicidade
        public async Task<bool> VerificarDuplicidade(string nome)
        {
            string strCommand = string.Format("Select NomeArquivo from DadosParametros");            
            try
            {
                using (SQLDataModel data = new SQLDataModel())
                {
                    await data.Connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(strCommand, data.Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                if ((string)reader["NomeArquivo"] == nome.ToLower().Trim()) return true;
                            }
                            return false;
                        }
                    }
                }
            }

            catch
            {
                return true;
            }
        }

        //Retorna lista de dados
        public async Task<ObservableCollection<GerenciarDadosModel>> RetornaListaDados()
        {
            string strCommand = string.Format("Select NomeArquivo, DataCriacao, UsuarioCriador from DadosParametros");
            ObservableCollection<GerenciarDadosModel> _listaDados = new ObservableCollection<GerenciarDadosModel>();
            try
            {
                using (SQLDataModel data = new SQLDataModel())
                {
                    await data.Connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(strCommand, data.Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                _listaDados.Add(new GerenciarDadosModel()
                                {
                                    NomeArquivo = (string)reader["NomeArquivo"],
                                    DataCriacao = (string)reader["DataCriacao"],
                                    UsuarioCriador = (string)reader["UsuarioCriador"],                                    
                                });
                            }
                        }
                    }
                }
                return _listaDados;
            }

            catch
            {
                return null;
            }
        }

        //Remover dados
        public async Task<bool> RemoveDados(string nome)
        {
            string strCommand = string.Format("delete from DadosParametros Where NomeArquivo='{0}'", nome);
            try
            {
                using (SQLDataModel data = new SQLDataModel())
                {
                    await data.Connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(strCommand, data.Connection))
                    {
                        await command.ExecuteNonQueryAsync();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        //Carregamento de dados
        public async Task<GerenciarDadosModel> CarregarDados(string nome)
        {
            string strCommand = string.Format("Select *from DadosParametros Where NomeArquivo = '{0}'", nome);
            ObservableCollection<GerenciarDadosModel> _listaDados = new ObservableCollection<GerenciarDadosModel>();
            GerenciarDadosModel dadosModel = new GerenciarDadosModel();
            try
            {
                using (SQLDataModel data = new SQLDataModel())
                {
                    await data.Connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(strCommand, data.Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dadosModel.NomeArquivo = (string)reader["NomeArquivo"];
                                dadosModel.DataCriacao = (string)reader["DataCriacao"];
                                dadosModel.UsuarioCriador = (string)reader["UsuarioCriador"];
                                dadosModel.ListaDeParametros.Add((string)reader["Parametro1"]);
                                dadosModel.ListaDeParametros.Add((string)reader["Parametro2"]);
                                dadosModel.ListaDeParametros.Add((string)reader["Parametro3"]);
                                dadosModel.ListaDeParametros.Add((string)reader["Parametro4"]);
                                dadosModel.ListaDeParametros.Add((string)reader["Parametro5"]);
                                dadosModel.ListaDeParametros.Add((string)reader["Parametro6"]);
                                dadosModel.ListaDeParametros.Add((string)reader["Parametro7"]);
                                dadosModel.ListaDeParametros.Add((string)reader["Parametro8"]);
                            }
                        }
                    }
                }
                return dadosModel;
            }

            catch
            {
                return null;
            }
        }

    }
}
