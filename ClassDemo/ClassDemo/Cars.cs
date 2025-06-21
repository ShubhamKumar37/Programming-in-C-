using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Car
    {
        // This is the state of the car
        string petName;
        int currSpeed;
        string color;
        int torque;
        bool dispalyAvailable;

        //Constructor
        public Car()
        {
            petName = "Harsh";
            currSpeed = 0;
        }

        public Car(int speed)
        {
            this.currSpeed = speed;
        }
        public Car(int speed, string name, string color)
        {
            this.currSpeed = (int)speed;
            this.color = color;
            //this.PetName = name; // This is not allowed
            this.petName = name;
        }

        //public Car(int speed) => this.currSpeed = speed;

        // Property
        public string Color
        {
            private set { color = value; } // Now this set will be only availble to this class only 
            get { return color; }
        }

        public int CurrSpeed
        {
            get { return currSpeed; }
            set
            {
                if (value < 10) this.currSpeed = 10;
                else this.currSpeed = value;
            }
        }

        // Auto implemented property
        public int Torque { set => this.torque = value; get => this.torque; }
        public string FuelType { set; get; } // If either one is declared may be set or get then it will become read only or write only
        // Expression body syntax
        public bool DisplayAvailable { set => this.dispalyAvailable = value; get => this.dispalyAvailable; }

        public string PetName
        {
            //get { return petName; }
            set
            {
                if (value == null || value.Length <= 3) throw new ArgumentException("petName is required");
                else this.petName = value;
            }
        }
        // The behaviour and functionality
        public void PrintState()
        {
            Console.WriteLine($"{petName} is running at a speed of {currSpeed}");
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
            Console.WriteLine($"Speed is increased by {delta}");
        }
    }
}
