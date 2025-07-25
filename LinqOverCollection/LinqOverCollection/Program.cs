﻿using System.Collections;

List<Car> myCars = new List<Car> {
    new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
    new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
    new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
    new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
    new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
};

FastCars(myCars); static void FastCars(List<Car> arr)
{
    foreach (Car car in (from j in arr where j.Speed > 55 && j.PetName == "Henry" select j)) Console.WriteLine(car.PetName);
}

LINQOverArrayList(); static void LINQOverArrayList()
{
    Console.WriteLine("***** LINQ over ArrayList *****");
    // Here is a nongeneric collection of cars.
    ArrayList myCars = new ArrayList() {
 new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
 new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
 new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
 new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
 new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
 };
    // Transform ArrayList into an IEnumerable<T>-compatible type.
    var myCarsEnum = myCars.OfType<Car>();
    // Create a query expression targeting the compatible type.
    var fastCars = from c in myCarsEnum where c.Speed > 55 select c;
    foreach (var car in fastCars)
    {
        Console.WriteLine("{0} is going too fast!", car.PetName);
    }
}

OfTypeAsFilter();  static void OfTypeAsFilter()
{
    // Extract the ints from the ArrayList.
    ArrayList myStuff = new ArrayList();
    myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
    var myInts = myStuff.OfType<int>();
    // Prints out 10, 400, and 8.
    foreach (int i in myInts)
    {
        Console.WriteLine("Int value: {0}", i);
    }
}
class Car
{
    public string PetName { get; set; } = "";
    public string Color { get; set; } = "";
    public int Speed { get; set; }
    public string Make { get; set; } = "";
 }
