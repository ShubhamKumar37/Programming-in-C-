Car car1 = new Car();
car1.Acclerate(12);
car1.ListOfHandlers = CallWhenBroke;

car1.Acclerate(12);
car1.ListOfHandlers += CallAfterBroken;
car1.Acclerate(12);

car1.ListOfHandlers.Invoke("hahaha i am here and no one can stop me");

void CallWhenBroke(string msg)
{
    Console.WriteLine("This is the message from first function and the message is {0}", msg);
}

void CallAfterBroken(string msg)
{
    Console.WriteLine("I am still in this function but this time is outside{0}", msg);
}
public class Car
{
    public delegate void CarEngineHandler(string msg);

    public CarEngineHandler ListOfHandlers;

    public void Acclerate(int delta)
    {
        if (ListOfHandlers != null) ListOfHandlers("Sorry your car is broken");
    }
}