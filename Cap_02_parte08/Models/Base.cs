using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte08.Models
{

    public abstract class Base
    {
        public virtual void Metodo()
        {
            Console.WriteLine("Método ClasseBase");
        }

        public abstract void MetodoAbstrato();
    }

        
}
       



