using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14
{
    public class Manipula
    {
        private string caminho = 
            "C:\\Users\\Public\\Documents\\Dados.txt";
        
        public void Gravar(string texto)
        {
            StreamWriter sw = new StreamWriter(caminho);
            sw.WriteLine(texto);
            sw.Close();
        } 
        public List<Aluno> Ler()
        {
            var list = new List<Aluno>();
            if (File.Exists(caminho))
            {
                StreamReader sr = File.OpenText(caminho);
                string linha;
                while((linha=sr.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    Aluno alguem = new Aluno(int.Parse(arquivo[0]), arquivo[1], arquivo[2], arquivo[3]);
                    list.Add(alguem);
                }
            }
            return list;
        }
    }
}
