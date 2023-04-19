// See https://aka.ms/new-console-template for more information
using Cap_02_parte19.Models;

Curso c1 = new Curso(1, "Curso 1");
Curso c2 = new Curso(2, "Curso 2");
Curso c3 = new Curso(3, "Curso 3");

// Criando uma lista de objeto na estrutura chave + valor
Dictionary<string, Curso> dicionario = new Dictionary<String, Curso>();
dicionario.Add(c1.NomeCurso, c1);
dicionario.Add(c2.NomeCurso, c2);
dicionario.Add(c3.NomeCurso, c3);

// procurando um determinado elemento
Console.Write("Encontrou o Curso 2: ");
Console.WriteLine(dicionario["Curso 3"] == null ? false : true);
Console.WriteLine("");


// Navegando pela coleção e imprimindo os objetos.
foreach (KeyValuePair<string, Curso> itemCurso in dicionario)
{
    string chave = itemCurso.Key;
    Curso c = dicionario[chave];
    Console.WriteLine(c.NomeCurso);
}

Console.Read();



