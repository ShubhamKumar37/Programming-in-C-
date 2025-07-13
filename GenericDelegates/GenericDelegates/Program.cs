IntStrDelegate<int> intD = new IntStrDelegate<int>(GetIncrease);
IntStrDelegate<string> strD = GetString; // Shortend notation

intD(12);
strD("Shubham kumar");


void GetString(string str)
{
    Console.WriteLine("This is the value of string {0}", str);
}

void GetIncrease(int n)
{
    Console.WriteLine("This the value of int {0}", ++n);
}

public delegate void IntStrDelegate<T>(T para);
