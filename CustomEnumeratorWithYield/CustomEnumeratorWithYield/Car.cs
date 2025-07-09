using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    public class Car
    {
        public const int Maxspeed = 100;
        public int CurrSped { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool _isCarDead = false;
        private readonly Radio _theMusicBox = new Radio();

        public Car() { }
        public Car(string petName, int speed)
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
                    throw new CarIsDeadException($"{PetName} has been overheated")
                    {
                        HelpLink = " http://www.cars.com/overheated",
                        Data =
                        {
                            { "TimeStamps", $"Car was dead at {DateTime.Now}" },
                            {"Cause", "You had lead the foot" }
                        }
                    };
                }
                Console.WriteLine("{0} is the current speed", CurrSped);
            }


        }

    }
}
