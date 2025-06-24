(int, string, int) val1 = (123, "Shubham Kumar", 342);
var val2 = (123, "Sparsh Sharma", 2342, false);

Console.WriteLine($"This is the value 1 = {val1.Item1}");
Console.WriteLine($"This is the value 1 = {val1.Item2}");
Console.WriteLine($"This is the value 1 = {val1.Item3}");
//Console.WriteLine($"This is the value 1 = {val1.Item4}"); // This will give compilation error

(int num1, string str1, int num2) val = (123, "Pratham", 122321);
var val3 = (key1: "Shubham Kumar", key2: false, key3: true, key4: 1323);
Console.WriteLine($"This is the value = {val3.key1}");
Console.WriteLine($"This is the value = {val3.key2}");
Console.WriteLine($"This is the value = {val3.key3}");
Console.WriteLine($"This is the value = {val3.key4}");

(int Field1, int Field2) example = (Custom1: 5, Custom2: 7);
// Here the compiler will listen to FieldX not with CustomX

var nt = (1, 2, new int[] { 13, 33, 4 }, ("shubham", false, true, 32));
foreach(int i in nt.Item3) Console.WriteLine(i);

var foo = new{prop1= 323, prop2= "Shubham"};
var tup = (foo.prop1,  foo.prop2);
Console.WriteLine($"This is the value = {tup.Item1}");
Console.WriteLine($"This is the value = {tup.Item2}");


Console.WriteLine("=> Tuples Equality/Inequality");
// lifted conversions
var left = (a: 5, b: 10);
(int? a, int? b) nullableMembers = (5, 10);
Console.WriteLine(left == nullableMembers); // Also true
                                            // converted type of left is (long, long)
(long a, long b) longTuple = (5, 10);
Console.WriteLine(left == longTuple); // Also true
                                      // comparisons performed on (long, long) tuples
(long a, int b) longFirst = (5, 10);
(int a, long b) longSecond = (5, 10);
Console.WriteLine(longFirst == longSecond); // Also true
//Console.WriteLine((1, 2, 3) == ("Shubham")); // This will be compilation

static (int a, string b, int c) FillValues()
{
    return (32, "Shubham", 34);
}

var sample = FillValues();
Console.WriteLine("{1} {0} {2}", sample.a, sample.b, sample.c);

//var (first, _, last) = SplitNames("Philip F Japikse");
//Console.WriteLine($"{first}:{last}");

// Switch case
switch( "rock", "paper")
{
    case ("rock", "paper"):
        Console.WriteLine("You win");
        break;
    default:
        Console.WriteLine("Every combination is done");
        break;
}

//Switch expression with Tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins.",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}
Console.WriteLine(RockPaperScissors("fsd", "sdf"));

(int x, int y) myTup = (32, 5);
(int a, int b) = myTup;

Console.WriteLine("This is the value of a {0} and this is for b {1}", a, b);

Point p = new Point(32, -54);
//(int n1, int n2) = p.Deconstruct();
(int n1, int n2) = p.Deconstruct();

Console.WriteLine(WhichPlane(p));
static string WhichPlane(Point p)
{
    return p.Deconstruct() switch // We can only just use p instead of calling the whole method but idk, here it is not working
    {
        (0, 0) => "Center",
        var (x, y) when x > 0 && y > 0 => "One",
        var (x, y) when x < 0 && y > 0 => "Two",
        var (x, y) when x > 0 && y < 0 => "Three",
        var (x, y) when x < 0 && y < 0 => "Four",
        (_, _) => "Border"

    };
}

struct Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public (int a, int b) Deconstruct() => (x, y);
}