using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaireExemple.Exceptions
{
    public  class NegativeNumberException : Exception
    {
        public NegativeNumberException():base("Le nombre est négatif")
        {
            
        }
    }
}
