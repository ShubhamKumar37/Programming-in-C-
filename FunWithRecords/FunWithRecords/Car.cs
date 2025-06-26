using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithRecords
{
    public class Car 
    {
        public string Make { get; init; }
        public string Model { get; init; }
        public string Color { get; init; }

        public Car() { }

        public Car(string Make, string Model, string Color)
        {
            this.Make = Make;
            this.Model = Model;
            this.Color= Color;
        }

        public void DisplayCarStats()
        {
            Console.WriteLine("Car creator is {0}, color is {1} and Model is {2}", Make, Color, Model);
        }
    }
}
