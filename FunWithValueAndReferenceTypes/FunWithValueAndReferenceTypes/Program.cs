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

    class ShapeInfo
    {
        public string str;
        public ShapeInfo(string str)
        {
            this.str = str;
        }
    }

    struct Rectangle
    {
        public ShapeInfo RectInfo;
        public int top, right, bottom, left;

        public Rectangle(string info, int top, int right, int bottom, int left)
        {
            RectInfo = new ShapeInfo(info);
            this.top = top;
            this.right = right; ;
            this.bottom = bottom;
            this.left = left;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " + "Left = {3}, Right = {4}", RectInfo.str, top, bottom, left, right);
        }
    }

    static void CheckRef()
    {
        Rectangle rect = new Rectangle("This shape have 4 side", 4, 5, 4, 5);
        rect.Display();
        Rectangle rect2 = rect;

        rect.top = 23;
        rect.Display();
        rect2.Display();
    }

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

        //ReferenceTypeAssingment();
        CheckRef();
    }

    
}