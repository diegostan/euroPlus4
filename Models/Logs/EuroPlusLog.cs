using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace euroPlus4_1.Models.Logs
{
    class EuroPlusLog :IDisposable
    {
        public string Caminho { get; }       

        bool _arquivoExistente;
        StreamWriter _streamWriter;
        public EuroPlusLog()
        {
            //Caminho = Properties.Settings.Default.CaminhoLog + "/euroPlusLogs.txt";
            _arquivoExistente = File.Exists(Caminho)? true:false;            
            
        }
        public void GerarLog(string mensagem)
        {
            _streamWriter = new StreamWriter(Caminho, _arquivoExistente);
            TextWriter textWriter = _streamWriter;
            textWriter.WriteLine(mensagem + " - " + DateTime.Now.ToString());
            textWriter.Close();
        }

        public void Dispose()
        {            
            _streamWriter.Close();
        }
    }
}
