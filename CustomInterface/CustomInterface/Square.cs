
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    public class Square : Shape, IRegularlyPointy
    {
        public Square() { }
        public Square(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("This is a Square");
        }

        public byte Points => 4;

        public string PropName { get; set; }

        public byte GetNumberOfPoints() => 123;

        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
    }
}
