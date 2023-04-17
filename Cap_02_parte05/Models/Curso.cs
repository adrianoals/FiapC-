using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte05.Models
{ 
    public class Curso
    {
        #region atributos
        int Codigo;
        internal string NomeCurso;
        public string NomeInstrutor;
        private int CargaHorario;
        protected int MinimoAlunos;
        protected internal int MaximoAlunos;
        #endregion

        public Curso()
        {
            // Construtor padrão.
        }

        protected internal Curso(string nome, string instrutor)
        {
            this.NomeCurso = nome;
            this.NomeInstrutor = instrutor;
        }


        private Curso(string nome, int minimo, int maximo)
        {
            this.NomeCurso = nome;
            this.MaximoAlunos = maximo;
            this.MinimoAlunos = minimo;
        }


        public void CriarCurso(string nome, string instrutor)
        {
            this.NomeCurso = nome;
            this.NomeInstrutor = instrutor;
        }

        private bool MatricularAluno(string nomeAluno)
        {
            return true;
        }

        private int ConsultarMaximoAlunos()
        {
            return this.MaximoAlunos;
        }

    }
}



