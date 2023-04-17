// See https://aka.ms/new-console-template for more information


using Cap_02_parte07.Models;

Base a = new Base();
a.Metodo();

Derivada b = new Derivada();
b.Metodo();

Base c = new Derivada();
c.Metodo();

Console.Read();
