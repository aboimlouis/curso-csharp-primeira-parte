using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Calculadora
    {
        public static void TripleOut(double origin, out double result)
        {
            result = origin * 3;
        }
        public static void TripleRef(ref double origin)
        {
            origin = origin * 3;
        }
    }
}
