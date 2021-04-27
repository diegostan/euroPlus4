using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Configuration;

namespace euroPlus4_1.Models.Data
{
    class CriarBaseDados
    {
        

        public ObservableCollection<string> ListaBancoDados { get; private set; }
        public bool BaseOK { get; }

        public CriarBaseDados()
        {
            ListaBancoDados = new ObservableCollection<string>();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = "master";
            builder.DataSource = "localhost\\SQLEXPRESS";
            builder.UserID = "sa";
            builder.Password = "191260";
            
            using (var con = new SqlConnection(builder.ConnectionString))
            {
                try { 
                con.Open();
                DataTable dataTable = con.GetSchema("Databases");

                foreach (DataRow database in dataTable.Rows)
                {
                    string databaseName = database.Field<string>("database_name");
                    ListaBancoDados.Add(databaseName);
                    BaseOK = true;
                }
                }
                catch
                {
                    BaseOK = false;
                }
            }
           
        }
    }
}
