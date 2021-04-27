using euroPlus4_1.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace euroPlus4_1.Models
{

    class RFID
    {
        [DllImport("SRF32.dll")]
        private static extern int s_init(
       ushort PortNum,
       int combaud,
       ushort DTR_State,
       ushort RTS_State);

        [DllImport("SRF32.dll")]
        private static extern ushort s_exit(int m_hUSB);

        [DllImport("SRF32.dll")]
        private static extern ushort s_bell(int m_hUSB, ushort bell_time);

        [DllImport("SRF32.dll")]
        private static extern ushort s_emid_read(int m_hUSB, byte[] emid_number);

        [DllImport("SRF32.dll")]
        private static extern ushort s_emid_WriteT5557(
          int m_hUSB,
          byte[] emid_number,
          ushort type,
          byte[] card_password);

        [DllImport("SRF332.dll")]
        private static extern ushort s_emid_Write8800(int m_hUSB, byte[] emid_number);

        [DllImport("SRF32.dll")]
        private static extern ushort s_em4305_readWord(
          int m_hUSB,
          ushort rf_freq,
          ushort block,
          byte[] card_data);

        [DllImport("SRF32.dll")]
        private static extern ushort s_emid_WriteEM4305(
          int m_hUSB,
          byte[] emid_number,
          ushort type,
          byte[] card_password);

        int h_Reader = 0;
        string leitura = "";
        byte[] emid_number = new byte[128];

        public bool RFIDOK;
        public RFID()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\SRF32.dll"))
            {                
                h_Reader = s_init((ushort)0, 0, (ushort)0, (ushort)0);
                RFIDOK = true;
            }
            else
            {
                RFIDOK = false;
            }
            
        }
        
        public string LerTag()
        {
            if (RFIDOK)
            {
                if (s_emid_read(h_Reader, emid_number) == (ushort)5)
                {
                    leitura = ((uint)((((int)emid_number[1] * 256 + (int)emid_number[2]) * 256 + (int)emid_number[3]) * 256) + (uint)emid_number[4]).ToString("D10");
                    if(leitura!= null || leitura!="") s_bell(h_Reader, (ushort)100);

                }
                else
                {
                    leitura = "";
                }
            }
            else
            {
                leitura = "";
            }
            return leitura;
        }

        public async Task<bool> VerificaTagRFID(UsuarioModel usuarioInfo)
        {
            string strCommand = string.Format("Select *from Usuarios");            

            using (SQLDataModel data = new SQLDataModel())
            {
                await data.Connection.OpenAsync();
                using (SqlCommand command = new SqlCommand(strCommand, data.Connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {                            
                            if(LerTag() == (reader.GetValue(4).ToString()) || (reader.GetValue(4).ToString()) == "" || (reader.GetValue(4).ToString())==null)
                            {
                                usuarioInfo.Nome = reader.GetString(1);
                                usuarioInfo.Nivel = reader.GetInt32(3);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
            
        }
    }
}
