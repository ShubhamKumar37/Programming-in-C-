using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleException
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
            if (delta < 0) throw new ArgumentOutOfRangeException(nameof(delta), "Speed must be greater then 0");
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

            Car car1 = new Car(21, "Nin");
            car1.CrankTunes(true);
            try
            {
                car1.Accelerate(-323);
            }
            catch (CarIsDeadException e) when (e.Message == $"{car1.PetName} has been overheated")
            {
                Console.WriteLine(e.ToString());
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) // This will catch any type of exception thrown inside the try block
            {
                Console.WriteLine(e.Message);
                //throw new Exception("This is reach to upper flow of execution"); // we can throw another exception inside a exception or catch block
            }
            finally
            {
                car1.CrankTunes(true); // This statement will always execute no matter how the error is 
            }
            //Console.WriteLine("***** Simple Exception Example *****");
            //Console.WriteLine("=> Creating a car and stepping on it!");
            //Car myCar = new Car(20, "Zippy");
            //myCar.CrankTunes(true);
            //myCar.CrankTunes(true);

            //try
            //{

            //    for (int i = 0; i < 10; i++)
            //    {
            //        myCar.Accelerate(10);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("\n*** Error! ***");
            //    Console.WriteLine("Member name: {0}", e.TargetSite);
            //    Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
            //    Console.WriteLine("Help Link: {0}", e.HelpLink);
            //    Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
            //    Console.WriteLine("Message: {0}", e.Message);
            //    Console.WriteLine("Source: {0}", e.Source);

            //    foreach (DictionaryEntry i in e.Data)
            //    {
            //        Console.WriteLine($"This is key = {i.Key} and its value is {i.Value}");
            //    }

            //}
            //NullReferenceException nullRefEx = new NullReferenceException();
            //Console.WriteLine(
            //"NullReferenceException is-a SystemException? : {0}",
            //nullRefEx is SystemException);
        }
    }
}
