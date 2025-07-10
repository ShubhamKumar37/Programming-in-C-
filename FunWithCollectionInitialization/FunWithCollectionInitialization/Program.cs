using System.Collections;
using System.Drawing;

// Init a standard array.
int[] myArrayOfInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Init a generic List<> of ints.
List<int> myGenericList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Init an ArrayList with numerical data.
ArrayList myList = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

List<Point> myListOfPoints = new List<Point>()
{
    new Point(){X = 0,Y = 0},
    new Point(){X = 22,Y = 232},
    new Point(){X = 27,Y = 3}
};

foreach (var pt in myListOfPoints)
{
    Console.WriteLine(pt);
}
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}