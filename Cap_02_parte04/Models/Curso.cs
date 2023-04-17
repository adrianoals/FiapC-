using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte04.Models
{

    public class Curso
    {

        //Atributos
        public int Codigo { get; set; }
        public string NomeCurso { get; set; }
        public string NomeInstrutor { get; set; }
        public int CargaHorario { get; set; }
        public int MinimoAlunos { get; set; }
        public int MaximoAlunos { get; set; }


        //Métodos
        public void CriarCurso(string nome, string instrutor)
        {
            Console.WriteLine($"Curso {nome} criado com sucesso");
          //Console.WriteLine("Curso" + nome + "criado com sucesso");
            this.NomeCurso = nome;
            this.NomeInstrutor = instrutor;
        }

        public bool MatricularAluno(string nomeAluno)
        {
            // Verificar a quantidade de alunos
            return true;
        }

        public int ConsultarMaximoAlunos()
        {
            // Retorno o valor do atributo
            return this.MaximoAlunos;
        }

        //Contrutores

        //Contrutor Padrão
        public Curso()
        {

        }

        //Contrutor Personalizado
        public Curso(string nome, string instrutor)
        {
            this.NomeCurso = nome;
            this.NomeInstrutor = instrutor;

        }

        //Contrutor Personalizado
        public Curso(string nome, int minimoAlunos, int maximoAlunos)
        {
            this.NomeCurso = nome;
            this.MinimoAlunos = minimoAlunos;
            this.MaximoAlunos=maximoAlunos;

        }


    }
 }

