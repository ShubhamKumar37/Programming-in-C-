using FunWithRecords;

class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car { Make = "Honda", Color = "Black", Model = "Base" };
        Car car2 = new Car("Honda", "Black", "Base");

        Console.WriteLine("Are the class equal = {0}", car1.Equals(car2));
        Console.WriteLine("Are the class equal with reference = {0}", ReferenceEquals(car1, car2));
        //car1.DisplayCarStats();
        //car2.DisplayCarStats();

        Console.WriteLine("*************** RECORDS *********************");
        //Use object initialization
        CarRecord myCarRecord = new CarRecord
        {
            Make = "Honda",
            Model = "Pilot",
            Color = "Blue"
        };
        Console.WriteLine("My car: ");
        CarRecord.DisplayCarRecordStats(myCarRecord);
        Console.WriteLine();
        //Use the custom constructor
        CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
        Console.WriteLine("Another variable for my car: ");
        // This toString method is also a little fancy for Records
        Console.WriteLine(anotherMyCarRecord.ToString()); // ToStrint() This help to print whole varaible of the object instance   
        Console.WriteLine();
        //Compile error if property is changed
        //myCarRecord.Color = "Red";

        BikeRecord br1 = new BikeRecord("Base", "Yellow", 321);
        BikeRecord br2 = new BikeRecord("Base", "Yellow", 321);
        BikeRecord br3 = br2; // This will make the reference and the value same
        br1.Deconstruct(out string model, out string color, out int millage);
        var (model1, color1, millage1) = br1;  
        Console.WriteLine("Model = {0}, Color = {1}, Millage = {2}", model, color, millage);
        Console.WriteLine("Model = {0}, Color = {1}, Millage = {2}", model1, color1, millage1);
        Console.WriteLine("Are the class equal = {0}", br1.Equals(br2)); // I can use ==, != operator (only for records)
        Console.WriteLine("Are the class equal with reference = {0}", ReferenceEquals(br1, br2));

        Console.WriteLine("Car Record copy using with expression results");
        Console.WriteLine($"CarRecords are the same? {br1.Equals(br2)}");
        Console.WriteLine($"CarRecords are the same? {ReferenceEquals(br2, br3)}");
    }

    static void DisplayCarStats(Car c)
    {
        Console.WriteLine("Car Make: {0}", c.Make);
        Console.WriteLine("Car Model: {0}", c.Model);
        Console.WriteLine("Car Color: {0}", c.Color);
    }
}