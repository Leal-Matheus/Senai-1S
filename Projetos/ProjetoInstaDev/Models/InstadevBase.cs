using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetoInstaDev.Models
{
    public class InstadevBase
    {

        Random randomid = new Random();
        public void CriarPastaeArquivo(string _path)
        {
            string folder = _path.Split("/")[0];
            string file = _path.Split("/")[1];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(_path))
            {
                File.Create(_path).Close();
            }
        }

        public List<string> LerCSV(string _path)
        {
            List<string> linhas = new List<string>();
            using (StreamReader file = new StreamReader(_path))
            {
                string linha;
                while ((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            return linhas;
        }

        public void ReescreverCSV(string _path, List<string> linhas)
        {
            using (StreamWriter output = new StreamWriter(_path))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + "\n");
                }
            }
        }

        public int GerarId(List<int> ids)
        {
            int id;
            do
            {
                id = randomid.Next(1, 10000000);
                if (!ids.Contains(id))
                {
                    return id;
                }

            } while (ids.Contains(id));
            return id;
        }
    }
}