Point p1 = new Point(50, 50);
Point p2 = p1;
p2.X = 0;
Console.WriteLine(p1);
Console.WriteLine(p2);

Point p3 = new Point(100, 100);
Point p4 = (Point)p3.Clone();
// Change p4.X (which will not change p3.X).
p4.X = 0;
// Print each object.
Console.WriteLine(p3);
Console.WriteLine(p4);
public class Point : ICloneable
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
    public Point() { }

    public override string ToString() => $"X = {X}; Y = {Y}";

    public object Clone() => new Point(this.X, this.Y);
}

public interface ICloneable
{
    object Clone();
}