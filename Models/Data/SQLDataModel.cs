using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using euroPlus4_1.Properties;
using System.Collections.ObjectModel;
using System.Threading;

namespace euroPlus4_1.Models.Data
{
    class SQLDataModel:IDisposable
    {
        // Camada de dominio para gerenciamento de dados do SQL
        
        
        //Propriedades------------------------------------------------------------------
        public ObservableCollection<string> ListaBancoDados { get; private set; }
        public bool BancoEuroPlusPresente { get; private set; }
        //------------------------------------------------------------------------------

        public SqlConnection Connection{ get; set; }
        public SqlConnectionStringBuilder StringBuilder { get; private set; }
        public SQLDataModel()
        {
            BancoEuroPlusPresente = true;
            ListaBancoDados = new ObservableCollection<string>();
            
            var prop = Settings.Default;
            StringBuilder = new SqlConnectionStringBuilder();
            StringBuilder.InitialCatalog = prop.sqlDataBase;
            StringBuilder.DataSource = prop.sqlServerConfig;
            StringBuilder.UserID = prop.sqlUserIdConfig;
            StringBuilder.Password = prop.sqlPasswordConfig;
            Connection = new SqlConnection(StringBuilder.ConnectionString);
            
        }


        //Testa a conexão e verifica se a base de dados do euroPlus está instalada na instância
        public async Task<bool> TestarConexao()
        {
            try
            {
                StringBuilder.InitialCatalog = "master";
                Connection.ConnectionString = StringBuilder.ConnectionString;
                await Connection.OpenAsync();
                if (Connection.State == ConnectionState.Open)
                {
                    DataTable dataTable = Connection.GetSchema("Databases");
                    ListaBancoDados.Clear();
                    foreach (DataRow database in dataTable.Rows)
                    {
                        string databaseName = database.Field<string>("database_name");
                        ListaBancoDados.Add(databaseName);
                        if (databaseName=="sysEP4") BancoEuroPlusPresente = false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();
            }
        }

        public async Task<bool> CriarEstruturaDados()
        {
            try 
            {
                var prop = Settings.Default;
                StringBuilder.InitialCatalog = "master";
                Connection.ConnectionString = StringBuilder.ConnectionString;
                await Connection.OpenAsync();
                string strCommand = "create database sysEP4";
                SqlCommand command = new SqlCommand(strCommand, Connection);
                await command.ExecuteNonQueryAsync();
                Thread.Sleep(500);
                SelecionarBanco(Connection);
                CriarTabelaUsuarios(Connection);
                CriarTabelaNivelTela(Connection);
                CriarTabelaGerenciarDados(Connection);
                StringBuilder.InitialCatalog = prop.sqlDataBase;

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
                Connection.ConnectionString = StringBuilder.ConnectionString;
            }
        }

        private void SelecionarBanco(SqlConnection conn)
        {
            string strCommand = "use sysEP4";
            SqlCommand command = new SqlCommand(strCommand, conn);
            command.ExecuteNonQuery();
        }
        private void CriarTabelaUsuarios(SqlConnection conn)
        {           
                string strCommand = "CREATE TABLE dbo.Usuarios(ID int IDENTITY(1,1) PRIMARY KEY, Nome varchar(50) NOT NULL, Senha varchar(50) NOT NULL, Nivel int NOT NULL, RFID varchar(128) NOT NULL, " +
                "DicaSenha varchar(128) NOT NULL," +
                    " DataCriacao varchar(50) NOT NULL);";
                SqlCommand command = new SqlCommand(strCommand, conn);
                command.ExecuteNonQuery();                                      
        }

        private void CriarTabelaNivelTela(SqlConnection conn)
        {
            string strCommand = "CREATE TABLE dbo.TelasDisponiveis(Descricao varchar(50) NOT NULL, Nivel int NOT NULL);";
            SqlCommand command = new SqlCommand(strCommand, conn);
            command.ExecuteNonQuery();
            command.CommandText = "Insert into TelasDisponiveis values ('Estacoes', 1)";
            command.ExecuteNonQuery();
            command.CommandText = "Insert into TelasDisponiveis values ('Temperaturas', 1)";
            command.ExecuteNonQuery();
            command.CommandText = "Insert into TelasDisponiveis values ('BombaHidraulica', 1)";
            command.ExecuteNonQuery();
            command.CommandText = "Insert into TelasDisponiveis values ('TemposFrequencias', 1)";
            command.ExecuteNonQuery();
            command.CommandText = "Insert into TelasDisponiveis values ('GerenciarDados', 1)";
            command.ExecuteNonQuery();
            command.CommandText = "Insert into TelasDisponiveis values ('Tolerancias', 10)";
            command.ExecuteNonQuery();
            command.CommandText = "Insert into TelasDisponiveis values ('Configuracoes', 10)";
            command.ExecuteNonQuery();
        }

        private void CriarTabelaGerenciarDados(SqlConnection conn)
        {
            string strCommand = "CREATE TABLE dbo.DadosParametros(NomeArquivo varchar(50) NOT NULL, DataCriacao varchar(50) NOT NULL, UsuarioCriador varchar(50) NOT NULL," +
                " Parametro1 varchar(12) NOT NULL, Parametro2 varchar(12) NOT NULL, Parametro3 varchar(12) NOT NULL, Parametro4 varchar(12) NOT NULL, Parametro5 varchar(12) NOT NULL" +
                ", Parametro6 varchar(12) NOT NULL, Parametro7 varchar(12) NOT NULL, Parametro8 varchar(12) NOT NULL);";
            SqlCommand command = new SqlCommand(strCommand, conn);
            command.ExecuteNonQuery();
        }


        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
