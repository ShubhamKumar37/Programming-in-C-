
static void MakeNewCar()
{
    // Now this allocated memory may be free after this function over or return something as 
    // C# select from our code base that which of the allocated memory is not being used then that get cleared by garbage collection
    Car cr = new Car();
    cr = null;
}

public class Car
{
    public int CurrSpeed { get; set; }
    public string PetName{ get; set; }
    public Car() { }
    public Car(int speed, string petName) { 
        CurrSpeed = speed;
        PetName = petName;
    }
    public override string ToString() => $"{PetName} is going {CurrSpeed} MPH";
}

