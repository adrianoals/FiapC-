// See https://aka.ms/new-console-template for more information

using Cap_02_parte13.Models;

Curso curso = new Curso();
string nomeAluno = "";

try
{
    curso.CriarAluno(nomeAluno);
    var nomeRecortado = nomeAluno.Substring(0, 10);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Tamanho menor que 10");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Finalizou");
}


