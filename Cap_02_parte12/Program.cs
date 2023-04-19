// See https://aka.ms/new-console-template for more information


using Cap_02_parte12.Models;

Curso curso = new Curso();
string nomeAluno = null;

try
{
    var nomeRecortado = nomeAluno.Substring(0, 10);
    // Vai dar o erro abaixo
    //System.NullReferenceException: 'Object reference not set to an instance of an object.'
    //nomeAluno was null.
    curso.CriarAluno(nomeAluno);
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