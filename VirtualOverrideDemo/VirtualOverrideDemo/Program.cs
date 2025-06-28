public class Employee
{
    public string Name {  get; set; }
    
    public virtual void GiveBonus()
    {
        Console.WriteLine("This is a base class and we can give {0} 5% bonus", Name);
    }

    public void Display() => Console.WriteLine("Employee name = {0}", Name);
}

public class Manager : Employee
{
    public override void GiveBonus()
    {
        Console.WriteLine("This is a Manager class and we can give {0} 10% bonus", Name);
    }
}

public class Developer : Employee
{
    public void GiveBonus()
    {
        Console.WriteLine("This is a Developer class and we can give {0} 20% bonus", Name);
    }
}

public class Intern : Employee
{
    public override void GiveBonus()
    {
        Console.WriteLine("This is a Intern class and we can give {0} 1% bonus", Name);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee man = new Manager() { Name = "Shubham" };
        Employee dev = new Developer() { Name = "Sparsh" }; // Here i didnot use Override keword
        // so the method called was from base class or from the type of object 
        Employee intern = new Intern() { Name = "Harsh" };

        man.Display();
        man.GiveBonus();
        dev.Display();
        dev.GiveBonus();
        intern.Display();
        intern.GiveBonus();

    }
}