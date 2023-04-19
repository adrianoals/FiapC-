// See https://aka.ms/new-console-template for more information


using Cap_02_parte11.Model;

Curso curso = new Curso();
string nomeAluno = "";

try
{
    var nomeRecortado = nomeAluno.Substring(0, 10);
    curso.CriarAluno(nomeAluno);
}catch (ArgumentOutOfRangeException ex)
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


Console.Read();