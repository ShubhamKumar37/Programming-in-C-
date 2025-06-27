using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithRecords
{
    internal record CarRecord// By this we can make this class as a record it work on value equality which mean if 2 diff object have
                            // same value then we will get true if we use equal operator 
    {
        // We can also make a mutable record type just we need to use the set keyword instead of init
        public string Make { get; init; }
        public string Model { get; init; }
        public string Color { get; init; }
        public CarRecord() { }
        public CarRecord(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }

        static public void DisplayCarRecordStats(CarRecord c)
        {
            Console.WriteLine("Car creator is {0}, color is {1} and Model is {2}", c.Make, c.Color, c.Model);
        }
    }

    // This is a record position syntax and this define init only property and we have to use the basic way of initializing the objects
    internal record BikeRecord(string Model, string Color, int Millage) // Now these parameter will become the actual variable of this class
    // This syntax only work with record
    {
        public void Display() { }
    }
}
