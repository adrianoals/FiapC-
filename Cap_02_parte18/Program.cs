// See https://aka.ms/new-console-template for more information

// Criando uma lista ordenada
SortedSet<string> alunos = new SortedSet<string>();

// Adicionando elementos na lista
alunos.Add("Alberto");
alunos.Add("Giovanna");
alunos.Add("Fabio");
alunos.Add("Victor");
alunos.Add("Carlos");

Console.Write("Encontrou o aluno Carlos: ");
// Procurando na lista um determinado elemento
Console.WriteLine(alunos.Contains("Carlos"));
Console.WriteLine("");

foreach (string aluno in alunos)
{
    Console.WriteLine(aluno);
}

Console.Read();