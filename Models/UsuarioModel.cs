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
    class UsuarioModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Nivel { get; set; }

        public string RFID { get; set; }
        public string DataCriacao { get; set; }

        public string DicaSenha { get; set; }
    
    public UsuarioModel()
        {

        }

        public async Task<bool> VerificarUsuario(UsuarioModel usuario, UsuarioModel usuarioInfo)
        {
            string strCommand = string.Format("Select *from Usuarios Where Nome = '{0}'", usuario.Nome);
            string senha= "";
          
            using (SQLDataModel data = new SQLDataModel())
            {
                await data.Connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(strCommand, data.Connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            senha = reader.GetString(2);
                            usuarioInfo.Nivel = reader.GetInt32(3);
                            usuarioInfo.RFID = (reader.GetValue(4)!=null)? reader.GetValue(4).ToString():"" ;
                        }
                    }
                }
            }

            if (senha == usuario.Senha)  return true; else  return false;
            
        }

        public async Task<string> EsqueceuSenha(UsuarioModel usuario)
        {
            string strCommand = string.Format("Select *from Usuarios Where Nome = '{0}'", usuario.Nome);
            string dicaSenha = "";
            using (SQLDataModel data = new SQLDataModel())
            {
                await data.Connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(strCommand, data.Connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dicaSenha = reader.GetString(5);
                        }
                    }
                }
            }
            return dicaSenha;
        }

        //Retorna lista de usuarios
        public async Task<ObservableCollection<UsuarioModel>> RetornaListaUsuarios()
        {
            string strCommand = string.Format("Select ID, Nome, Nivel, RFID, DataCriacao from Usuarios");
            ObservableCollection<UsuarioModel> _listaUsuarios = new ObservableCollection<UsuarioModel>();            
            try { 
            using(SQLDataModel data = new SQLDataModel())
            {
                await data.Connection.OpenAsync();
                using(SqlCommand command = new SqlCommand(strCommand, data.Connection))
                {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                _listaUsuarios.Add(new UsuarioModel() { Nome = (string)reader["Nome"], Nivel = (int)reader["Nivel"], ID = (int)reader["id"], RFID = (string)reader["RFID"],
                                DataCriacao = (string)reader["DataCriacao"]});
                            }
                        }
                }
            }
            return _listaUsuarios;
            }
            
            catch
            {
                return null;
            }
        }

        //Remover usuario
        public async Task<bool> RemoveUsuario(int id)
        {
            string strCommand = string.Format("delete from Usuarios Where id={0}", id);
            try
            {
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

        //Adicionar Usuario
        public async Task<bool> AdicionaUsuario(UsuarioModel usuario)
        {
            if (await VerificarDuplicidade(usuario.Nome, usuario.RFID))
            {
                return false;
            }
            string strCommand = string.Format("use [sysEP4];Insert into Usuarios(Nome, Senha, Nivel, RFID, DicaSenha, DataCriacao) Values('{0}', '{1}', {2}, '{3}', '{4}', '{5}')",
                usuario.Nome.ToLower().Trim(), usuario.Senha, usuario.Nivel, usuario.RFID, usuario.DicaSenha, usuario.DataCriacao);
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

        //Verifica duplicidade
        public async Task<bool> VerificarDuplicidade(string nome, string RFID)
        {
            string strCommand = string.Format("Select Nome, RFID from Usuarios");
            ObservableCollection<UsuarioModel> _listaUsuarios = new ObservableCollection<UsuarioModel>();
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
                                if((string)reader["Nome"] == nome.ToLower().Trim() || (string)reader["RFID"] == RFID.ToLower().Trim()) return true;                                
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
    }
}
