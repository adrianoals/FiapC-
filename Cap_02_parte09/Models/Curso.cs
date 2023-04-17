using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte09.Models
{
    internal class Curso : IAluno, IInstrutor
    {
        public void CriarAluno()
        {
            Console.WriteLine("Criando aluno");
        }


        public void CriarInstrutor()
        {
            Console.WriteLine("Criando instrutor");
        }

    }
}
