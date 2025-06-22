using System;

namespace FunWithValueAndReferenceTypes;
struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public void Display()
    {
        Console.WriteLine("This is x = {0} and this is y = {1}", X, Y);
    }
}

class Program
{
    class PointRef
    {
        public int x;
        public int y;

        public PointRef(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine("This is x = {0} and this is y = {1}", x, y);
        }

        
    }
    static void ReferenceTypeAssingment()
    {
        PointRef p1 = new PointRef(20, 50);
        PointRef p2 = p1;

        p1.Display();
        p2.Display();

        p1.x = 60;
        p1.Display();
        p2.Display();

    }
    static void Main(string[] args)
    {
        // Point p1 = new Point(20, 50);
        // Point p2 = p1;
        // p1.X = 60;
        // p1.Display();
        // p2.Display();

        ReferenceTypeAssingment();
    }

    
}