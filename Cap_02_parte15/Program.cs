using Cap_02_parte15.Exceptions;
using Cap_02_parte15.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        
        try
        {
            string nome = null;
            new Curso().CriarAluno(nome);
            Console.WriteLine(nome.Substring(2));
        }
        catch (PersonalizadaException p)
        {
            Console.WriteLine(p.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Problema na execução a operação");
            throw new Exception("Problema na execução a operação");
        }
    }
}
