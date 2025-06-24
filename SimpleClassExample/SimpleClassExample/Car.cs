using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public string petName;
        public System.Int32 currSpeed;

        public Car() // Custom default constructor
        {
            this.currSpeed = 10;
            this.petName = "Cobal";
        }

        public Car(int currSpeed) => this.currSpeed = currSpeed; // This way int will get the given value but if not then 0 as the default if some other value is assigned here
        public Car(int currSpeed, string petName) 
        {
            this.currSpeed = currSpeed;
            this.petName = petName;
        }

        public Car(int currSpeed, string petName, out bool flag)
        {
            this.currSpeed = currSpeed;
            this.petName = petName;
            if (currSpeed < 40) flag = true;
            else flag = false;
        }

        public void PrintState() => Console.WriteLine("{0} this is the speed of the car {1}", currSpeed, petName);
        public void SpeedUp(int delta) => currSpeed += delta;
    }
}