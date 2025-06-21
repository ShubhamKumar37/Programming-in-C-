static int Add(int x, int y)
{
    x = 10;
    y = 20;
    return x + y;
}

static int AddWithOut(int a, int b, out int ans)
{
    ans = a + b; 
    return a + b;
}

int a = 1, b = 2, ans = 1; // if variable is just declared then we can pass it to function qw well
//Console.WriteLine("a = {0} b = {1}", a , b);
//Console.WriteLine("a + b = {0}", Add(a, b));
//Console.WriteLine("a = {0} b = {1}", a , b); // The value does not change at all because a copy of the variable was passed

//Console.WriteLine("a + b = {0}", AddWithOut(a, b, out ans)); // we have to use out at both places 
//Console.WriteLine("This is the ans {0} ", ans);
//Console.WriteLine(AddWithOut(a, b, out int val)); // We can also do this 
//Console.WriteLine("This is val {0}", val);

static void FillSomeValue(out int val1, out string val2, out string val3)
{
    val1 = 1222;
    val2 = "Shubham Kumar";
    val3 = "Sparsh Sharma"; // If we have catches a parameter which have out modifier we need to assign the value else we will get compilation error
}

//FillSomeValue(out int val1, out string val2, out string val3);
FillSomeValue(out int val1, out _, out _); // The called method need to assign the value to these discard variable as well because of out modifier nature and compilation error
//Console.WriteLine("This is val1 {0}\nThis is val2 {1} \nThis is val3 {2}", val1, val2, val3);