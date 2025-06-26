using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectIntializer
{
    internal class ReadOnlyPointAfterCreation
    {
        public ReadOnlyPointAfterCreation() { }
        public ReadOnlyPointAfterCreation(int xPos, int yPos) {
            X = xPos; Y = yPos;
        }
        public int X { get; init; } // This init help to initialize the value when object is created then this become read-only;
        public int Y { get; init; }
        
        
        public void DisplayStats() => Console.WriteLine("Init initializer [{0}, {1}]", X, Y);
    }
}
