public interface IDrawable
{
    void Draw();
}

public interface IPrintable
{
    void Draw();
    void Print();
}

interface IShape: IDrawable, IPrintable
{
    int GetNumberOfSides();
}

class Rectangle : IShape
{
    public int GetNumberOfSides() => 4;
    public void Draw() => Console.WriteLine("Drawing...");
    public void Print() => Console.WriteLine("Printing...");
}

class Square : IShape
{
    // Using explicit implementation to handle member name clash.
    void IPrintable.Draw()
    {
    }
    // Draw to printer ...
    void IDrawable.Draw()
    {
        // Draw to screen ...
    }
    public void Print()
    {
        // Print ...
    }
    public int GetNumberOfSides() => 4;
}