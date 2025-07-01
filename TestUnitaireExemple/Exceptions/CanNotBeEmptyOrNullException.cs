using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaireExemple.Exceptions
{
    public class CanNotBeEmptyOrNullException : Exception
    {
        public CanNotBeEmptyOrNullException():base("Le business ne permet pas un palydrome vide ou Null")
        {
            
        }
    }
}
