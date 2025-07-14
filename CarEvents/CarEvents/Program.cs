using CarEvents;
//Car car1 = new Car();
//car1.Exploded += new Car.CarEngineHandler(PrintMessage); // To attach a function to the event we have to use += and for remove use -=
////car1.AboutToBlow += new Car.CarEngineHandler(PrintMessage); 
//car1.Accelerate(12);

//car1.Exploded += NewMessage;
////car1.AboutToBlow += new Car.CarEngineHandler(NewMessage);
//car1.Accelerate(13);
//car1.Accelerate(543);
//car1.Accelerate(543);
//car1.Exploded -= new Car.CarEngineHandler(NewMessage1); // Even though the reference doesnot exist it will not raise any error
//car1.Accelerate(543);

//void PrintMessage(string msg)
//{
//    Console.WriteLine("Ahh shit here we go again {0}",  msg);
//}
//void NewMessage(string msg)
//{
//    Console.WriteLine("Get a job b* {0}",  msg);
//}
//void NewMessage1(string msg)
//{
//    Console.WriteLine("Get a job b* {0}",  msg);
//}


//public class Car
//{
//    public int CurrentSpeed { get; set; } = 10;
//    public int MaxSpeed = 100;
//    private bool _isCarDead = false;
//    public delegate void CarEngineHandler(string msg);

//    public event CarEngineHandler AboutToBlow;
//    public event CarEngineHandler Exploded;
//    public void Accelerate(int delta)
//    {
//        if (_isCarDead == true)
//        {
//            Exploded?.Invoke("Sorry your car is exploded we cannot do any thing here");
//        }
//        else
//        {
//            if (CurrentSpeed + delta <= MaxSpeed) CurrentSpeed += delta;
//            else
//            {
//                _isCarDead = true;
//                AboutToBlow?.Invoke("Yes the car is about to blow");
//            }

//            Console.WriteLine("Current speed of the car is {0}", CurrentSpeed);
//        }
//    }
//}

// WE CAN DO SAME THESE THING WITH OUR GENERIC TYPES JUST NEED TO ADD <T> LIKE WE DID IN DELEGATE

Car car1 = new Car();

car1.Exploded += MessageForExplode;
car1.AboutToBlow += MessageForAboutToExplode;

car1.Accelerate(21);
car1.Accelerate(210);
car1.Accelerate(210);

void MessageForExplode(object obj,  CarEventArg message)
{
    if (obj is Car cr) Console.WriteLine("Here we are in middle of no where and here our fans message {0} from {1}", message.message, obj.GetType());
}

void MessageForAboutToExplode(object obj,  CarEventArg message)
{
    if (obj is Car cr) Console.WriteLine("Yooo just stop it man , here is the mesage {0} from {1}", message.message, obj.GetType());
}


public class Car
{
    public int CurrentSpeed { get; set; } = 10;
    public int MaxSpeed = 100;
    private bool _isCarDead = false;
    public delegate void CarEngineHandler(object obj, CarEventArg e);

    public event CarEngineHandler AboutToBlow;
    public event CarEngineHandler Exploded;
    public void Accelerate(int delta)
    {
        if (_isCarDead == true)
        {
            Exploded?.Invoke(this, new CarEventArg("Now your car is already broked so donn't worry we cannot fix this"));
        }
        else
        {
            if (CurrentSpeed + delta <= MaxSpeed) CurrentSpeed += delta;
            else
            {
                _isCarDead = true;
                AboutToBlow?.Invoke(this, new CarEventArg("You gotta stop here man donot trip"));
            }

            Console.WriteLine("Current speed of the car is {0}", CurrentSpeed);
        }
    }
}