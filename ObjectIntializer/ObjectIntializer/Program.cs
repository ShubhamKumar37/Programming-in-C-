using ObjectIntializer;

Point p1 = new Point();
p1.X = 10;
p1.Y = 10; // Manually initialzing value

Point p2 = new Point(20, 20); // Using Constructor
Point p3 = new Point { X = 13 ,Y = 19}; // Using Object Intializer, as these property was public thats why it worked 
// If they were private then this will not work

p1.DisplayStats();
p2.DisplayStats();
p3.DisplayStats();

ReadOnlyPointAfterCreation pr1 = new ReadOnlyPointAfterCreation(212, 232);
ReadOnlyPointAfterCreation pr2 = new ReadOnlyPointAfterCreation() { X = 123, Y = 64}; // Here the default constructor also called explicitely
ReadOnlyPointAfterCreation pr3 = new ReadOnlyPointAfterCreation(2343, 3323232) { X = 1, Y = 4}; // Here the default constructor also called explicitely
// Above the value will be assign as 1 and 4 to x and y
pr1.DisplayStats();
pr2.DisplayStats();
//pr1.X = 324; // This will cause error as we have set the property with init which only allow one time to add value then it become read-only

Rectangle r1 = new Rectangle
{
    TopLeft = new Point { X = 10, Y = 20 },
    //BottomRight = new Point(PointColor.LightBlue) { X = 30, Y = 40}
    BottomRight = new Point { X = 30, Y = 40, Color = PointColor.LightBlue }
};
r1.DisplayStats();

class Point
{
    public int X { get; set; } = 10;
    public int Y { get; set; } = 10;
    public PointColor Color { get; set; }

    public Point(int xPos, int yPos) { 
        X = xPos;
        Y = yPos;
        Color = PointColor.Gold;   
    }
    public Point() : this(PointColor.BloodRed) { }
    public Point(PointColor pt)
    {
        Color = pt;
    }
    public void DisplayStats() => Console.WriteLine("[{0}, {1}] and the point color is {2}", X, Y, Color);

}

class Rectangle
{
    private Point topLeft = new Point();
    private Point bottomRight = new Point();

    public Point TopLeft { get => topLeft; set => topLeft = value;}
    public Point BottomRight { get => bottomRight; set => bottomRight = value;}

    public void DisplayStats()
    {
        Console.WriteLine("[Top-Left: {0}, {1}, {2}], [Bottom-Right: {3}, {4}, {5}]", TopLeft.X, TopLeft.Y, TopLeft.Color, BottomRight.X, BottomRight.Y, BottomRight.Color);

    }


}