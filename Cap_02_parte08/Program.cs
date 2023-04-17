// See https://aka.ms/new-console-template for more information

using Cap_02_parte08.Models;


Derivada b = new Derivada();
b.Metodo();

Base c = new Derivada();
c.Metodo();
c.MetodoAbstrato();

Console.Read();