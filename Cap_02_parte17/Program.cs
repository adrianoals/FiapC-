// See https://aka.ms/new-console-template for more information
using Cap_02_parte17.Models;

// Criando a lista dos objetos curso
List<Curso> lista = new List<Curso>();

// Adicionando cursos na lista 
// Add adiciona no final da lista
lista.Add(new Curso(1, "Curso 1"));
lista.Add(new Curso(2, "Curso 2"));
lista.Add(new Curso(4, "Curso 4"));

// Inserindo um curso em uma posição específica (Insert).
lista.Insert(2, new Curso(3, "Curso 3"));

foreach (var curso in lista)
{
    Console.WriteLine(curso.NomeCurso);
}

//Exemplo 2
Console.WriteLine("");

List<Curso> lista2 = new List<Curso>();
Curso c1 = new Curso(1, "Curso 1");
lista2.Add(c1);
lista2.Add(new Curso(2, "Curso 2"));
lista2.Add(new Curso(4, "Curso 4"));
lista2.Insert(2, new Curso(3, "Curso 3"));

// Removendo um objeto de uma determinada posição
lista2.RemoveAt(3);

// Removendo o objeto pela referência de c1
lista2.Remove(c1);

foreach (var curso in lista2)
{
    Console.WriteLine(curso.NomeCurso);
}

Console.Read();



Console.Read();