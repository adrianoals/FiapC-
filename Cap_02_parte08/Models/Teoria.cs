using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte08.Models
{
    internal class Teoria
    {

      /*
       Uma classe abstrata é uma classe que não pode ser instanciada, ou seja, você não pode criar objetos a partir dela. Ela serve apenas como uma base para outras classes que a estendem (herdam). Uma classe abstrata pode conter métodos abstratos e/ou métodos concretos (com implementação).

      Os métodos abstratos são definidos na classe abstrata, mas não possuem implementação, ou seja, não possuem um corpo de código definido. Em vez disso, eles são declarados com a palavra-chave "abstract" e sua implementação é deixada para as classes filhas que estendem a classe abstrata.

     As classes filhas que estendem uma classe abstrata precisam implementar todos os métodos abstratos da classe pai, caso contrário, também precisam ser declaradas como classes abstratas. Dessa forma, as classes filhas garantem que tenham implementado todas as funcionalidades definidas na classe pai, mas ainda permitem que cada classe implemente suas próprias funcionalidades específicas.

   Em resumo, uma classe abstrata é uma classe que não pode ser instanciada e que fornece uma estrutura comum para outras classes relacionadas. Um método abstrato é um método declarado sem uma implementação, deixando a implementação para as classes que herdam a classe abstrata. Juntos, eles ajudam a criar um código mais modular, escalável e fácil de manter.     

        Classes:
        - Não pode ser instaciada, não é permitido criar um objeto apartir de uma classe abstrata
        - Geralmente é usada como classe base p/ outras classes
        - Pode conter métodos abstratos ou métodos comuns
        - Pode possuir construtores e propriedades
        - Não pode ser estática (static)
        - Pode herdar de outra classe abstrata

        Métodos
        - Não possui implementação na classe abstrata. é composto apenas por sua assinatura.
        - A classe que deriva de uma classe abstrata precisa implementar seus métodos abstratos. Caso contrario erro de compilação é apresentado.
        - Método abstrato é virtual e deve ser implementado usando o modificador override.
        - Não pode usar os modificadores static e virtual.
        */

    }
}
