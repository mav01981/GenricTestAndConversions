using System;
using System.Collections.Generic;
using System.Text;

namespace Conversions
{
    class Digit
    {
        public Digit(double d) { val = d; }
        public double val;
        // ...other members

        // User-defined conversion from Digit to double
        public static implicit operator double(Digit d)
        {
            return d.val;
        }
        //  User-defined conversion from double to Digit
        public static implicit operator Digit(double d)
        {
            return new Digit(d);
        }
    }
}
