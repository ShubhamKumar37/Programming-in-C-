using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethodOverloading
{
        public static class AddOperations
        {
            public static int Add(int x, int y) => x + y;
            public static double Add(double x, double y) => x + y;
            public static long Add(long x, long y) => x + y;
            //public static int Add(ref int x, ref int y) => x + y;
            //public static int Add(out int x, out int y) => x + y; // This will give us the compilation error but only one have ref/out but other donot then no error even if the datatype signature is same
        }
}
