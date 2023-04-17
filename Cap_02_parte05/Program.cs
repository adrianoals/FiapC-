// See https://aka.ms/new-console-template for more information

//Modificadores De Acesso


using Cap_02_parte05.Models;

Curso curso = new Curso();
//Acessando atributos
curso.Codigo = 1;   //Erro pois o modificador padrão para atributos é private
curso.NomeCurso = "Nome do Curso";
curso.NomeInstrutor = "Instrutor";

curso.CargaHorario = 1; //Erro pois o modificador é protected
curso.MaximoAluno  = 1; //Erro pois o modificador é protected

//Construtores
Curso curso1 = new Curso();
Curso curso2 = new Curso("Curso", "Instrutor");
Curso curso3 = new Curso("Node.js", 5, 40); //Erro pois o modificador desse construtor é private
