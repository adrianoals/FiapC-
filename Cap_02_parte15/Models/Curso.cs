using Cap_02_parte15.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte15.Models
{
    internal class Curso
    {
        //Atributos
        public int Codigo { get; set; }
        public string NomeCurso { get; set; }
        public string NomeInstrutor { get; set; }
        public int CargaHorario { get; set; }
        public int MinimoAlunos { get; set; }
        public int MaximoAlunos { get; set; }


        //Métodos
        public void CriarCurso(string nome)
        {
            Console.WriteLine($"Curso {nome} criado com sucesso");
            this.NomeCurso = nome;
        }

        public void CriarAluno(string nome)
        {
            if (nome == null)
            {
                // Lançando uma exceção
                throw new PersonalizadaException("Nome do aluno inválido");
            }
        }
    }
}
