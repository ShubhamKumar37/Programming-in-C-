using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        public const int Maxspeed = 100;
        public int CurrSped { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool _isCarDead = false;
        private readonly Radio _theMusicBox = new Radio();

        public Car() { }
        public Car(int speed, string petName)
        {
            PetName = petName;
            CurrSped = speed;   
        }

        public void CrankTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_isCarDead == true) Console.WriteLine("Already dead car");
            else
            {
                CurrSped += delta;
                if (CurrSped > Maxspeed)
                {
                    CurrSped = 0;
                    _isCarDead = true;
                    //Console.WriteLine("{0} has been overheated", PetName); // Instead of this i can throw exception using throw keyword
                    throw new Exception($"{PetName} has been overheated");
                }
                Console.WriteLine("{0} is the current speed", CurrSped);
            }


        }

    }

    class Radio
    {
        public void TurnOn(bool on)
        {
            Console.WriteLine(on == true ? "Jamming" : "Quite Time");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car(20, "Zippy");
            myCar.CrankTunes(true);
            for (int i = 0; i < 10; i++)
            {
                myCar.Accelerate(10);
            }
            myCar.CrankTunes(true);
        }
    }
}
