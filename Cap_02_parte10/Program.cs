// See https://aka.ms/new-console-template for more information

using Cap_02_parte10.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Curso curso = new Curso();
        string nomeAluno = null;

        try
        {
            curso.CriarAluno(nomeAluno);
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
    }
}