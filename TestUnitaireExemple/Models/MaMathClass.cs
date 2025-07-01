using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnitaireExemple.Exceptions;

namespace TestUnitaireExemple.Models
{
    public static class MaMathClass
    {
        public static int AddPositiveNumber(int a, int b)
        {
            if (a == int.MaxValue) throw new TooLargeNumberException();
            if (b == int.MaxValue) throw new TooLargeNumberException();
            if (a < 0) throw new NegativeNumberException();
            if (b < 0) throw new NegativeNumberException();
            return a +b;
        }
    }
}
