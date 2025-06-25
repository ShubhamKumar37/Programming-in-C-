using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    internal class Garage
    {
        public int NumberOfCars { get; set; } = 1; // If i do this i do not have to the extra code in constructor for assigning default values
        public Car MyAuto { get; set; } = new Car();
        public Garage()
        {
            //NumberOfCars = 0;
            //MyAuto = new Car(); // Now this will help to not get runtime error if invoke any property of Car class
        }

        public Garage(int numberOfCars, Car car)
        {
            this.NumberOfCars = numberOfCars;
            this.MyAuto = car;
        }
    }
}
