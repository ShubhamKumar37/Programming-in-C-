//static int Add(int x, int y)
//{
//    x = 10;
//    y = 20;
//    return x + y;
//}

//static int AddWithOut(int a, int b, out int ans)
//{
//    ans = a + b; 
//    return a + b;
//}

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
//FillSomeValue(out int val1, out _, out _); // The called method need to assign the value to these discard variable as well because of out modifier nature and compilation error
//Console.WriteLine("This is val1 {0}\nThis is val2 {1} \nThis is val3 {2}", val1, val2, val3);

static void SwapString(ref string str1, ref string str2)
{
    string temp = str1;
    str1 = str2;
    str2 = temp;
}

string str1 = "Shubham Kumar";
string str2 = "Sparsh Sharma";
Console.WriteLine("This is first string {0} and this is second {1}", str1, str2);
// We have to initilaze a variable
//SwapString(ref str1, ref str2); // We have to declare the ref on both - parameter, and calling method place and we have to follow all the rules;
Console.WriteLine("This is first string {0} and this is second {1}", str1, str2);

static int Add(in int x, in int y)
{
    //x = 100;
    //y = 200; // In both of the variable we are getting compile time error as we have specified the parameter with "in" Modifier
    // This is because "in" modifier is read-only variable
    return x + y;
}

Console.WriteLine(Add(3, 2));

Console.WriteLine(GetAverage(4, 23.32, 23, 34)); static double GetAverage(params double[] arr)
{
    double sum = 0;
    if (arr.Length == 0) return sum;

    foreach (double i in arr) sum += i;
    return sum / arr.Length;
}

DisplayOption("Shubham Kumar"); static void DisplayOption(string val2, string val3 = "This is a optional parameter")
// This optional parameter is know at compile time so we have to specify that else we can not assign it on run time like DateTime timestamp = DateTIme.Now();
{
    Console.WriteLine("This is the first value {0} and this is second value {1}", val2, val3);
}

NamedParameter(name: "Shubha Kumar", age: 21); static void NamedParameter(int age, string name)
{
    Console.WriteLine("This is your name {0} and this is your age {1}", name, age);
}
