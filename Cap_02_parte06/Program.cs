// See https://aka.ms/new-console-template for more information
using Cap_02_parte06.Models;

CursoFerias CursoFeriasModel = new CursoFerias();
// Classe derivada pode acessar todas atributos e métodos da classe pai
Console.WriteLine(CursoFeriasModel.Codigo);
// Classe derivada pode ter atributos e métodos especificos
CursoFeriasModel.Monitor = "André";
Console.WriteLine(CursoFeriasModel.Monitor);


//Separador
Console.WriteLine("");

Base a = new Base();
a.Metodo();

Derivada b = new Derivada();
b.Metodo();

Base c = new Derivada();
c.Metodo();

Console.Read();
    

