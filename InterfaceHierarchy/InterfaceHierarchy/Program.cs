BitmapImage myBitmap = new BitmapImage();
myBitmap.Draw();
myBitmap.DrawInBoundingBox(10, 10, 100, 150);
myBitmap.DrawUpSideDown();
//myBitmap.TimeToDraw(); // This will cause error because this have a default implementation and these are not provided to the upstream of hirericy
Console.WriteLine(myBitmap.TimeToDraw()); // This is after implementing this inside the class

Console.WriteLine($"Time to draw: {myBitmap.TimeToDraw()}");
Console.WriteLine($"Time to draw: {((IDrawable)myBitmap).TimeToDraw()}");
Console.WriteLine($"Time to draw: {((IAdvancedDraw)myBitmap).TimeToDraw()}");
// Get IAdvancedDraw explicitly.
if (myBitmap is IAdvancedDraw iAdvDraw) // Checking of type
{
    iAdvDraw.DrawUpSideDown();
    Console.WriteLine("Time to draw is {0}", iAdvDraw.TimeToDraw());
}


public interface IDrawable
{
    void Draw();
    int TimeToDraw() => 4;
}

public interface IAdvancedDraw : IDrawable
{
    void DrawInBoundingBox(int top, int left, int bottom, int right);
    void DrawUpSideDown();
    new int TimeToDraw() => 12;
}

public class BitmapImage: IAdvancedDraw
{
    public void Draw()
    {
        Console.WriteLine("This is drwaing something");
    }

    public void DrawInBoundingBox(int top, int left, int bottom, int right)
    {
        Console.WriteLine("This is drawing a box ");
    }

    public void DrawUpSideDown()
    {
        Console.WriteLine("This is drawing up side donw ");
    }

    public int TimeToDraw() => 12;
}