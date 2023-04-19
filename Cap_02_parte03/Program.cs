// See https://aka.ms/new-console-template for more information

//Laços De Repetição

//Loop For
// Contando de 0 a 100
for (int i = 0; i < 101; i += 1)
{
    Console.WriteLine(i);
}

//Separador
Console.WriteLine("");

//Loop While
// Contando de 0 a 100
int i2 = 0;
while (i2 < 101)
{
    Console.WriteLine(i2);
    i2 += 1;
}


//Separador
Console.WriteLine("");

//Loop Do While
// Contando de 0 a 100
int i3 = 0;
do
{
    Console.WriteLine(i3);
    i3 += 1;
} while (i3 < 101);


//Separador
Console.WriteLine("");

// For Each
string[] lista = { "Fiap", "Fiap On", "Fiap School" };

foreach (string nome in lista)
{
    Console.WriteLine(nome);
}


Console.Read();
