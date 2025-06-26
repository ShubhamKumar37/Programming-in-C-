using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    internal class MyMathClass
    {
        //public const double PI = Math.PI;
        //public readonly double PI; // read-only are like constant but not implecitly static
        public static readonly double PI; // If i specify it as static then i need to make static constructor to intialize it

        static MyMathClass() // Static constructor never take parameters
        {
            PI = Math.PI;
        }
        public MyMathClass(double piValue)
        {
            //PI = piValue; // This is not possible because const variable must be initialized at the time of declaration
            //PI = 3.14; // Only here we can intialize the value of read-only variables else we will get error;
        }
        //public double Pie {  get { return PI; } set=>PI= value } // Only done by constructor for read-only
        public void DisplayStats() => Console.WriteLine("This is the PI value {0}", PI);

        public void LocalStringConstVariable()
        {
            //PI = 342; // This is comiplatation error because read-only variable can only intialize in constructor
            const string temp = "Shubham Kumar"; // we cannot update this also they are by default static
            Console.WriteLine(temp);
        }
    }
}
