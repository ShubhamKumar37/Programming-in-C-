using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritence
{
    public record PositionalSytax(string Make, string Model, string Color)
    {
        public void Display()
        {
            Console.WriteLine("This is the value = {0}, {1}, {2}", Make, Model, Color);
        }
    }
    public record InheritRecord(string Make, string Model, string Color) : PositionalSytax(Make, Model, Color);
    public record YoungerInherit(string Make, string Model, string Color, string Company, string Age): InheritRecord(Make, Model, Color);
}
