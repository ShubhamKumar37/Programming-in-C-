using AnonymousMethod;

Car car1 = new Car();
int Counter = 0;
car1.AboutToBlow += delegate (object obj, CarEventArg e)
{
    Console.WriteLine(e.message);
    Counter++;
};

car1.Exploded += delegate(object obj, CarEventArg _) { 
    Console.WriteLine("This is the message {0}, from {1}", _.message, obj.GetType());
    Counter++;
};
// In delegate we can use Discord  (_) like above (and this is use to ignore a parameter)


car1.Accelerate(20);
car1.Accelerate(20);
car1.Accelerate(20);
car1.Accelerate(20);
car1.Accelerate(20);
car1.Accelerate(20);
Console.WriteLine("Number of time delegate called is {0}", Counter);

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