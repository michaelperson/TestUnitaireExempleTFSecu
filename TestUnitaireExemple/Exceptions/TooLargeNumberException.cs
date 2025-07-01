using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaireExemple.Exceptions
{
    public class TooLargeNumberException : Exception
    {
        public TooLargeNumberException():base("ça est trop grand une fois!")
        {
            
        }
    }
}
