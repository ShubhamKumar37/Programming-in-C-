// Record struct are value type same as struct which is also value type 
// The difference is normal struct are mutble and record stuct are immutable and oto make them immutable we use read-only keyword
//public record struct Point(int X, int Y, int Z); // This also works

Point p1 = new Point { X = 12, Z = 12, Y = 132 };
Console.WriteLine(p1.ToString());

// As this struct is mutable but if we want a immutable record struct then just add init keyword instead of set and use read only access modifier
// If i make a struct readonly or class then i have to use init as it will show error
public readonly record struct Point
{
    public int X {  get; init; } public int Y { get; init; } public int Z { get; init; } 
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}