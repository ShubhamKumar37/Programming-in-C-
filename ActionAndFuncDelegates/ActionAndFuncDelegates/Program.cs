Action<string, int, bool> actionTarget = DisplayMessage;
actionTarget("Shubham Kumar", 12312, false);

Func<int, int, int> sumFun = Add; // The third placeholder is the always the return type of the function we are assining
Func<int, int, string> strFun = SumTostring;
Console.WriteLine("This is the value after addition {0}", Add(123, 2));
Console.WriteLine("This is the value after addition {0}", strFun(123, 2));
static void DisplayMessage(string msg, int num, bool flag)
{
    Console.WriteLine(msg);
    Console.WriteLine(num);
    Console.WriteLine(flag);
}

static int Add(int x, int y)  =>  x + y;
static string SumTostring(int x, int y) => (x + y).ToString();