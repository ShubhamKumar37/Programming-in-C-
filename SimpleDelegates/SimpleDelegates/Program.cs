SimpleMath m = new SimpleMath();
BinaryOp bp = new BinaryOp(m.Add);
//BinaryOp bp1 = new BinaryOp(SimpleMath.Square); // This will not compile because 

Console.WriteLine("This addition to 2 number is {0}", bp(12, 22));
Console.WriteLine("This addition to 2 number is {0}", bp.Invoke(12, 22)); // We can also explicity use this function
DisplayDelegateInfo(bp);


static void DisplayDelegateInfo(Delegate delObj)
{
    // Print the names of each member in the
    // delegate's invocation list.
    foreach (Delegate d in delObj.GetInvocationList())
    {
        Console.WriteLine("Method Name: {0}", d.Method);
        Console.WriteLine("Type Name: {0}", d.Target);
    }
}
StrOp so = new StrOp(Con.Sum);
Console.WriteLine(so("Shubham"));

public delegate int BinaryOp(int a, int b);

public class SimpleMath
{
    public int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Square(int a) => a * a;
}

public delegate string StrOp(string a);

public class Con
{
    public static string Sum(string s) => s + s;
}