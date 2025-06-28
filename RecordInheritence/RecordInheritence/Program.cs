using RecordInheritence;

//Car c = new Car("Honda", "Pilot", "Blue");
//MiniVan m = new MiniVan("Honda", "Pilot", "Blue", 10);
//Console.WriteLine($"Checking MiniVan is-a Car:{m is Car}");

PositionalSytax p1 = new PositionalSytax("Honda", "Base", "Black");
PositionalSytax p2 = p1 with { Color = "Red"};
PositionalSytax ir2 = new InheritRecord("Honda", "Base", "Black");
Console.WriteLine("Are these equal = {0}", Equals(ir2, p1)); // Different record are different no matter if value are same 
// Also record type have runtime type equality check 
// With keyword only work with records and helps to copy a object with some different value and rest become same

//p1.Display();
//p2.Display();


var (Make, Model, Color) = ir2;