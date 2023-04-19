// See https://aka.ms/new-console-template for more information

using FiapC_.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        HelloModel hello = new HelloModel();
        hello.Mensagem = "Olá Fiap!";

        Console.WriteLine(hello.Mensagem);


        // trecho para manter a janela aberta
        Console.Read();
 
    }
}