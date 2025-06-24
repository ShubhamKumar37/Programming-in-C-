using SimpleClassExample;
class Motorcycle
{
    public int driverIntensity;
    public string driverName;
    //public Motorcycle() { }
    //public Motorcycle(int driverIntensity) => this.driverIntensity = driverIntensity; // This will lead us to redundant constructor so we will use the this keyword.

    // create all kind of constructor
    public Motorcycle() {  }
    //public Motorcycle(): this(0, "") { Console.WriteLine("This is default constructor"); } // Instead of this we can just do this
    //public Motorcycle(int intensity): this(intensity, "") { Console.WriteLine("This is intensity constructor"); }
    //public Motorcycle(string name): this(0, name) { Console.WriteLine("This is name constructor"); }
    public Motorcycle(int intensity = 10, string name = "") { // Optional arguments is way more better then this
        if (intensity < 10) intensity = 10;
        this.driverIntensity = intensity;
        this.driverName = name;

        Console.WriteLine("This is master constructor");
    }

    public void PopAWheely()
    {
        for (int i = 0; i < driverIntensity; i++) Console.WriteLine("Hurrra");
    }
    public void SetDriverName(string driverName) => this.driverName = driverName; // We know what is meaning of "this" keyword, to repreesnt the current class context

}
