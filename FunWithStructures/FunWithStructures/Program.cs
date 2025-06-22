using System;
struct Point
{
    public int x;
    public int y;


    //public Point() { x = 0; y = 0; }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Increment()
    {
        x++; y++; 
    }
    public void Decrement()
    {
        x--; y--; 
    }
    public void Display()
    {
        Console.WriteLine("This is x = {0} and this is y = {1}", x, y);
    }
}

readonly struct ReadOnlyStruct // This read only sturcts only assign value while initalizing the variable means from constructor
{
    public int x { get; }
    public int y { get; }

    public ReadOnlyStruct(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Display()
    {
        Console.WriteLine("This is x = {0} and this is y = {1}", x, y);
    }
}

struct PointWithReadOnly
{
    // Fields of the structure.
    public int X;
    public readonly int Y; // Instead of creating the whole struct as readonly we can make some variable readonly and other things like method are also able to become readonly
    public readonly string Name;
    // Display the current position and name.
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
    }
    // A custom constructor.
    public PointWithReadOnly(int xPos, int yPos, string name)
    {
        X = xPos;
        Y = yPos;
        Name = name;
    }
}

ref struct DisposeStuff
{
    public int val1;
    public readonly int val2 { get; }
    public readonly string val3;

    void Dispose()
    {
        // Some deallocation
        Console.WriteLine("Here we free up the memory using this method name Dispose()");
    }
}

namespace FunWithStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Point newPoint = new Point(); // But if we use this then the data member will have the default value assign when no constructor is created
            Point newPoint = new Point(); 
            newPoint.Display();
            Point myPoint;
            myPoint.x = 40;
            myPoint.y = 120; // If i donot assign all the data member then i will face compilation error while invoking the methods
            myPoint.Increment();
            myPoint.Display();

        }
    }

  
        //public abstract class ValueType : object
        //{
        //    public virtual bool Equals(object obj);
        //    public virtual int GetHashCode();
        //    public Type GetType();
        //    public virtual string ToString();
        //}
    
}