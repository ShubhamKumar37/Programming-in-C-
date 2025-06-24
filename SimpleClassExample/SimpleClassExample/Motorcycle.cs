using SimpleClassExample;
class Motorcycle
{
    public int driverIntensity;
    public string driverName;
    public Motorcycle(){}
    public Motorcycle(int driverIntensity) => this.driverIntensity = driverIntensity;

    public void PopAWheely()
    {
        for(int i = 0; i < driverIntensity; i++) Console.WriteLine("Hurrra");
    }    
    public void SetDriverName(string driverName) => this.driverName = driverName; // We know what is meaning of "this" keyword, to repreesnt the current class context

}
