using Cap_02_parte16.Models;

//Arrays
internal class Program
{
    private static void Main(string[] args)
    {
        // Exemplo 1
        Console.WriteLine("Exemplo 1");
        string[] nomes1 = { "João", "Maria", "José" };
        Console.WriteLine(nomes1.Length);

        foreach (string nome in nomes1)
        {
            Console.WriteLine(nome); 
        }

        //Exemplo 2
        Console.WriteLine("\nExemplo 2");
        string[] nomes2 = new string[3];
        nomes1[0] = "João";
        nomes2[1] = "Maria";
        nomes2[2] = "José";
        
        Console.WriteLine(nomes2.Length);
        foreach (string nome in nomes1)
        {
            Console.WriteLine(nome);
        }

        // Criando um array de curso
        //Exemplo 3
        Console.WriteLine("\nExemplo 3");
        Curso[] listaCursos = new Curso[3];

        // Criando os items do array
        listaCursos[0] = new Curso(1, "Curso 1");
        listaCursos[1] = new Curso(2, "Curso 2");
        listaCursos[2] = new Curso(3, "Curso 3");


        // Navegando pelo array e imprimindo o conteúdo
        foreach (Curso curso in listaCursos)
        {
            Console.WriteLine(curso.NomeCurso);
        }


        Console.Read();


    }
}


