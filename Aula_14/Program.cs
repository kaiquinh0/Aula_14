using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manipula arquivo = new Manipula();
            Aluno a = new Aluno(63222300, "Marcelo Silva", "1ºADS", "123.456.789-10");
            arquivo.Gravar(a.RA+"; "+ a.Nome+"; "+ a.Turma+"; "+ a.Cpf);

            List<Aluno> alunos = arquivo.Ler();
            string texto = null;
            foreach(Aluno fulano in alunos)
            {
                texto += "RA = " + fulano.RA + "\nNome: " + fulano.Nome + "\nTurma: "
                    + fulano.Turma +"\nCPF: " + fulano.Cpf;
            }
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
