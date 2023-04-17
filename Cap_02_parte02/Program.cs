// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Ifs

int idade = 17;
if (idade >= 18)
{
    Console.WriteLine("É maior de idade");
}
else
{
    Console.WriteLine("Ação não permitida para menores de 18 anos");
}

//Separador
Console.WriteLine("");

idade = 17;
if (idade >= 18 && idade < 21)
{
    Console.WriteLine("Você pode jogar na categoria SUB-20");
}
else
{
    Console.WriteLine("Você NÃO pode jogar na categoria SUB-20");
}

//Separador
Console.WriteLine("");

idade = 20;

if (idade > 15 && idade < 18)
{
    Console.WriteLine("SUB-17");
}
else if (idade > 17 && idade < 21)
{
    Console.WriteLine("SUB-20");
}
else if (idade > 21 && idade < 24)
{
    Console.WriteLine("SUB-23");
}


//Separador
Console.WriteLine("");

idade = 16;

switch (idade)
{
    case 15:
        Console.WriteLine("SUB-15");
        break;
    case 16:
        Console.WriteLine("SUB-17");
        break;
    case 17:
        Console.WriteLine("SUB-17");
        break;
    case 18:
        Console.WriteLine("SUB-20");
        break;
    default:
        Console.WriteLine("Categoria não definida");
        break;
}


Console.Read();



