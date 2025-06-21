using System.Numerics; // This will provide BigInt

//Console.WriteLine("Basic I/O"); ;
//GetUserData();
//Console.ReadLine();

//static void GetUserData()
//{

//}

//Console.WriteLine("Enter your name = ");
//string name = Console.ReadLine();

//Console.WriteLine("Enter your age = ");
//string age = Console.ReadLine();

//Console.WriteLine("Your name is {0}, and your age is {1} {0}", name, age);// we can do this as {0} will work like a variable here

//static void FormatNumericalData()
//{
//    Console.WriteLine("The value 99999 in various formats:");
//    Console.WriteLine("c format: {0:c}", 99999);
//    Console.WriteLine("d9 format: {0:d9}", 99999);
//    Console.WriteLine("f3 format: {0:f3}", 99999);
//    Console.WriteLine("n format: {0:n}", 99999);
//    // Notice that upper- or lowercasing for hex
//    // determines if letters are upper- or lowercase.
//    Console.WriteLine("E format: {0:E}", 99999);
//    Console.WriteLine("e format: {0:e}", 99999);
//    Console.WriteLine("X format: {0:X}", 99999);
//    Console.WriteLine("x format: {0:x}", 99999);
//}
//FormatNumericalData();

static void LocalVarDeclaration()
{
    //int num = 0
    int num;
    int num2 = default;

    //Console.WriteLine("This is the num = {0}", num); // So unassinged variable will also cause error
    Console.WriteLine("This is the num = {0}", num2 ); // default 
}

static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool();
    // Set to false.
    int i = new int();
    double d = new double();
    DateTime dt = new DateTime();
    // Set to 0.
    // Set to 0.
    // Set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}
//NewingDataTypes();

//LocalVarDeclaration();

static void ObjectFunctionality()
{
    Console.WriteLine("=> System.Object Functionality:");
    // A C# int is really a shorthand for System.Int32,
    // which inherits the following members from System.Object.
    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}
ObjectFunctionality();

static void DataTypeFunctionality()
{

    Console.WriteLine(int.MaxValue);
    Console.WriteLine(int.MinValue);
    Console.WriteLine(double.PositiveInfinity);
}
DataTypeFunctionality();
Console.WriteLine(bool.FalseString);
Console.WriteLine(bool.TrueString);
Console.WriteLine(char.IsDigit('a'));
Console.WriteLine(char.IsLetter('a'));
Console.WriteLine(char.IsWhiteSpace("Hello my name is shubham", 8));

static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("False");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
}

ParseFromStrings();

static void ParseFromStringsWithTryParse()
{
    if (bool.TryParse("True", out bool b)) Console.WriteLine($"Value of b = {b}");
    else Console.WriteLine($"Default value of b {b}");
}
ParseFromStringsWithTryParse();

BigInteger BI = BigInteger.Parse("99999999999999999999999999999999");
Console.WriteLine(BigInteger.Multiply(BI, BigInteger.Parse("2323223232")));
Console.WriteLine(BI * BigInteger.Parse("2323223232"));

static void DigitSeparators()
{
    Console.WriteLine("=> Use Digit Separators:");
    Console.Write("Integer:");
    Console.WriteLine(123_456);
    Console.Write("Long:");
    Console.WriteLine(123_456_789L);
 Console.Write("Float:");
    Console.WriteLine(123_456.1234F);
    Console.Write("Double:");
    Console.WriteLine(123_456.12);
    Console.Write("Decimal:");
    Console.WriteLine(123_456.12M);
    //Updated in 7.2, Hex can begin with _
    Console.Write("Hex:");
    Console.WriteLine(0x_00_00_FF);
}

DigitSeparators();