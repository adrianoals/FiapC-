using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cap_02_parte15.Exceptions
{
    internal class PersonalizadaException : Exception
    {
      
        public PersonalizadaException() : base() { }
        public PersonalizadaException(string message) : base(message) { }
        public PersonalizadaException(string message, System.Exception inner) : base(message, inner) { }

        protected PersonalizadaException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
        
    }
}
