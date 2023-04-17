using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte09.Models
{
    internal class Teoria
    {
        /* Tanto as classes abstratas quanto as interfaces são mecanismos que permitem definir uma estrutura comum para um grupo de classes relacionadas em programação orientada a objetos. No entanto, há diferenças importantes entre elas.

A principal diferença é que uma classe abstrata pode conter métodos e propriedades concretas (métodos com implementação) e abstratas (métodos sem implementação), enquanto uma interface só pode conter métodos e propriedades abstratas. Ou seja, na classe abstrata, é possível definir uma implementação padrão para alguns métodos e permitir que outras classes possam sobrescrevê-los se necessário. Na interface, não há implementação definida.

Outra diferença importante é que uma classe pode herdar apenas uma classe abstrata, mas pode implementar várias interfaces. Ou seja, a classe pode ter uma estrutura básica fornecida pela classe abstrata e implementar comportamentos específicos definidos em diferentes interfaces.

Uma interface é um tipo de contrato que define um conjunto de métodos e propriedades que uma classe deve implementar. Dessa forma, as interfaces são usadas principalmente para definir um conjunto de métodos que uma classe precisa suportar para atender a um determinado conjunto de requisitos. As interfaces são implementadas explicitamente pelas classes, o que significa que os métodos definidos na interface precisam ser implementados pela classe que a implementa.

Por outro lado, uma classe abstrata é uma classe que não pode ser instanciada diretamente e é usada principalmente como uma classe base para outras classes que a estendem. A classe abstrata pode conter métodos abstratos que precisam ser implementados pelas classes que a estendem, bem como métodos concretos que já têm uma implementação definida. A classe abstrata pode ter métodos com visibilidade restrita, o que significa que eles só são acessíveis pelas classes que a estendem.

Em resumo, a principal diferença entre interfaces e classes abstratas é que as interfaces definem apenas a assinatura dos métodos que devem ser implementados pelas classes que as implementam, enquanto as classes abstratas podem definir tanto métodos abstratos quanto concretos e são usadas principalmente como uma base comum para outras classes que a estendem. Além disso, uma classe pode implementar várias interfaces, mas só pode herdar de uma classe abstrata.

        */
         

    }
}
