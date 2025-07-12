Car car1 = new Car("Breea", 100, 90);
Car.CarEngineDelegate b = new Car.CarEngineDelegate(AMessageInsideDelegate);

car1.RegisterWithCarHandler(b);
car1.Accelerate(120);
car1.Accelerate(120);

 void AMessageInsideDelegate(string str)
{
    Console.WriteLine("Here the message starts");
    Console.WriteLine(str);
}
public class Car
{
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; } = 100;
    public string PetName { get; set; }
    private bool _carIsDead;

    public Car() { }
    public Car(string name, int mxSpeed, int currSpeed)
    {
        PetName = name;
        CurrentSpeed = currSpeed;
        MaxSpeed = mxSpeed;
    }

    public delegate void CarEngineDelegate(string mssgToCaller);
    private CarEngineDelegate _listOfHandlers;
    public void RegisterWithCarHandler(CarEngineDelegate handler)
    {
        _listOfHandlers = handler;
    }

    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            _listOfHandlers?.Invoke("Sorry the car is dead and you know what is want to fix it");
            return;
        }
        else
        {
            CurrentSpeed += delta;
            if (CurrentSpeed < MaxSpeed) _listOfHandlers?.Invoke("VRUMMMMMM");
            else if (CurrentSpeed > MaxSpeed)
            {
                _carIsDead = true;
                _listOfHandlers?.Invoke("Your engine is aiming for your bad future");
            }
            else Console.WriteLine("This is the current speed {0}", CurrentSpeed);
        }
    }
}