Point<int> p = new Point<int>(10, 10);
Console.WriteLine("p.ToString()={0}", p.ToString());
p.ResetPoint();
Console.WriteLine("p.ToString()={0}", p.ToString());
Console.WriteLine();
// Point using double.
Point<double> p2 = new Point<double>(5.4, 3.3);
Console.WriteLine("p2.ToString()={0}", p2.ToString());
p2.ResetPoint();
Console.WriteLine("p2.ToString()={0}", p2.ToString());
Console.WriteLine();
// Point using strings.
Point<string> p3 = new Point<string>("i", "3i");
Console.WriteLine("p3.ToString()={0}", p3.ToString());
p3.ResetPoint();
Console.WriteLine("p3.ToString()={0}", p3.ToString());

Point<string> p4 = default;
Console.WriteLine("p4.ToString()={0}", p4.ToString());
Console.WriteLine();
Point<int> p5 = default;
Console.WriteLine("p5.ToString()={0}", p5.ToString());
public struct Point<T>
{
    private T _X; private T _Y;
    public Point(T x, T y)
    {
        _X = x; _Y = y;
    }

    public T X
    {
        get => _X;
        set => _X= value;
    }
    public T Y
    {
        get => _Y;
        set => _Y = value;
    }
    public override string ToString() => $"[{_X}, {_Y}]";

    public void ResetPoint()
    {
        _X = default;
        _Y = default;
        //_X = default(T);
        //_Y = default(T);
    }
}