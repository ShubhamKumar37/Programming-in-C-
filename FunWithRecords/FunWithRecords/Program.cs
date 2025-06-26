using FunWithRecords;

class Program
{
    public static void Main(string[] args)
    {
        //Car car1 = new Car { Make = "Honda", Color = "Black", Model = "Base" };
        //Car car2 = new Car("OD", "Dark Green", "Advance");

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
    }

    static void DisplayCarStats(Car c)
    {
        Console.WriteLine("Car Make: {0}", c.Make);
        Console.WriteLine("Car Model: {0}", c.Model);
        Console.WriteLine("Car Color: {0}", c.Color);
    }
}