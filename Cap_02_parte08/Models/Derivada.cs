using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte08.Models
{
 
        public class Derivada : Base
        {
            public override void Metodo()
            {
                Console.WriteLine("Método Derivada");
            }

            public override void MetodoAbstrato()
            {
                Console.WriteLine("Método MetodoAbstrato");
            }
        }
}
