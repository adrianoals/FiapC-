// See https://aka.ms/new-console-template for more information//

//Operadores

int valorInt = 100;

// convertendo inteiro para long
long valorLong = valorInt;

// convertendo long para double
double valorDouble = valorLong;

// Imprimindo conteúdo da variável
Console.WriteLine("Valor Inteiro:" + valorInt);
Console.WriteLine("Valor Long:" + valorLong);
Console.WriteLine("Valor Double:" + valorDouble);

//Separador
Console.WriteLine("");

int valorInt2 = 100;
long valorLong2 = valorInt2;
double valorDouble2 = valorLong;

// Tentando converter long para int
//valorInt2 = valorLong2;


// declaração de conversação (Parse)
valorInt2 = (int)valorLong2;

Console.WriteLine(valorInt2);
Console.WriteLine(valorLong2);
Console.WriteLine(valorDouble2);

//Separador
Console.WriteLine("");

// Operadores para Cálculos 
int soma = 10 + 15 + 3;
int subtracao = soma - 10;
int multiplicacao = soma * subtracao;
double divisao = multiplicacao / subtracao;

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);

//Separador
Console.WriteLine("");


// Atribuição 
    soma = 10;
    soma += 1; // Valor final 11
    soma++;   // Valor final 11

    subtracao = soma;
    subtracao -= 10; // Valor final 2

    multiplicacao = soma * subtracao;
    multiplicacao *= 3; // Valor final 72

    divisao = multiplicacao;
    divisao /= soma; // Valor final 6

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao);






// Para a execução até o usuário teclar Enter.
Console.Read();
//}