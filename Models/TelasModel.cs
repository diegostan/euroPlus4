using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using euroPlus4_1.Models.Data;
using System.Collections.ObjectModel;

namespace euroPlus4_1.Models
{
    class TelasModel
    {
        public string Descricao { get; set; }
        public int Nivel { get; set; }

        ObservableCollection<TelasModel> _listaDeTelas;

        public TelasModel()
        {
                      
        }

        public async Task<ObservableCollection<TelasModel>> RetornaTelas()
        {
            string strCommand = "Select *from TelasDisponiveis";
            _listaDeTelas = new ObservableCollection<TelasModel>();
            try { 
            using (SQLDataModel data = new SQLDataModel())
            {
                await data.Connection.OpenAsync();
                using(SqlCommand command = new SqlCommand(strCommand, data.Connection))
                {
                    using(SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            _listaDeTelas.Add ( new TelasModel() { Descricao = (string)reader["Descricao"], Nivel = (int)reader["Nivel"] });                            
                        }
                            return _listaDeTelas;
                    }
                }

            }
            }
            catch
            {
                return null;
            }
        }
        public async Task<bool> AtualizaTelas(TelasModel telas)
        {
            try
            {            
            string strCommand = string.Format("Update TelasDisponiveis Set Nivel={0} Where Descricao = '{1}'", telas.Nivel, telas.Descricao);
            using(SQLDataModel data = new SQLDataModel())
            {
                await data.Connection.OpenAsync();
                using(SqlCommand command = new SqlCommand(strCommand, data.Connection))
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

    }
}
