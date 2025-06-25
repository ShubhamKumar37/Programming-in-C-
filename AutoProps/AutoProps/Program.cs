using AutoProps;

Car car1 = new Car();
car1.PetName = "OD";
car1.Color = "Green";
car1.Speed= 212;

car1.DispalyStats();

Garage g = new Garage();
g.NumberOfCars = 121;
Console.WriteLine("This is the name of my car {0} and there {1} number of cars", g.MyAuto.PetName, g.NumberOfCars); // Without value of PetName and constructor in Garage.cs we will have runtime error
