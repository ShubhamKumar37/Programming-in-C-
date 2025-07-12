int a = 10;
int b = 20;

Console.WriteLine("This is a {0} and this is b {1}", a, b);
SwapFunction.Swap<int>(ref a, ref b);
Console.WriteLine("This is a {0} and this is b {1} after function call", a, b);

string s1 = "Shubham";
string s2 = "Sparsh";

Console.WriteLine("This is a {0} and this is b {1}", s1, s2);
SwapFunction.Swap(ref s1, ref s2); // We can also do this without specifying the datatype but still its not a good habit
Console.WriteLine("This is a {0} and this is b {1} after function call", s1, s2);
DisplayBaseType<string>();  void DisplayBaseType<T>() // Here we need to specify the placeholder else compilation error
{
    Console.WriteLine("Base class of {0} is {1}", typeof(T), typeof(T).BaseType);
}

//DisplayBaseType(); // This will lead compilation error

static class SwapFunction
{
    //public static void Swap(ref int a, ref int b)
    //{
    //    a = a ^ b;
    //    b = a ^ b;
    //    a = a ^ b;
    //}

    // Here is the implementation of generic swap
    public static void Swap<T>(ref T a,  ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

}

