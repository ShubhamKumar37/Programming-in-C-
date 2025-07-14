Car car1 = new Car();
car1.Exploded += new Car.CarEngineHandler(PrintMessage); // To attach a function to the event we have to use += and for remove use -=
//car1.AboutToBlow += new Car.CarEngineHandler(PrintMessage); 
car1.Accelerate(12);

car1.Exploded += NewMessage;
//car1.AboutToBlow += new Car.CarEngineHandler(NewMessage);
car1.Accelerate(13);
car1.Accelerate(543);
car1.Accelerate(543);
car1.Exploded -= new Car.CarEngineHandler(NewMessage1); // Even though the reference doesnot exist it will not raise any error
car1.Accelerate(543);

void PrintMessage(string msg)
{
    Console.WriteLine("Ahh shit here we go again {0}",  msg);
}
void NewMessage(string msg)
{
    Console.WriteLine("Get a job b* {0}",  msg);
}
void NewMessage1(string msg)
{
    Console.WriteLine("Get a job b* {0}",  msg);
}


public class Car
{
    public int CurrentSpeed { get; set; } = 10;
    public int MaxSpeed = 100;
    private bool _isCarDead = false;
    public delegate void CarEngineHandler(string msg);

    public event CarEngineHandler AboutToBlow;
    public event CarEngineHandler Exploded;
    public void Accelerate(int delta)
    {
        if (_isCarDead == true)
        {
            Exploded?.Invoke("Sorry your car is exploded we cannot do any thing here");
        }
        else
        {
            if (CurrentSpeed + delta <= MaxSpeed) CurrentSpeed += delta;
            else
            {
                _isCarDead = true;
                AboutToBlow?.Invoke("Yes the car is about to blow");
            }

            Console.WriteLine("Current speed of the car is {0}", CurrentSpeed);
        }
    }
}