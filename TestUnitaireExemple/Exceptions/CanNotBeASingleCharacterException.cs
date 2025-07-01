using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaireExemple.Exceptions
{
    public class CanNotBeASingleCharacterException: Exception
    {
        public CanNotBeASingleCharacterException():base("Le business ne permet pas un palindrome d'1! caractère")
        {
            
        }
    }
}
