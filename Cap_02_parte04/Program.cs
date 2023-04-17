// See https://aka.ms/new-console-template for more information
using Cap_02_parte04.Models;

//Classes Métodos e Atríbutos

// Construtor padrão
Curso cursoXamarin = new Curso();
//Utilizando o método Criar Curso
cursoXamarin.CriarCurso("Xamarin", "Flavio Moreni");
//Usando o método get
Console.WriteLine(cursoXamarin.NomeCurso);

// Definindo nome do curso e instrutor
Curso cursoIonic = new Curso("Ionic", "Antonio Coutinho");
//Usando o método get
Console.WriteLine(cursoIonic.NomeCurso);

// Definindo nome do curso e capacidade mínima e máxima
Curso cursoNode = new Curso("Node.js", 5, 40);
//Usando o método get
Console.WriteLine(cursoNode.NomeCurso);