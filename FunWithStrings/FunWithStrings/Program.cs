using System.Runtime.CompilerServices;
using System.Text; // StringBuilder live here
BasicStringFunctionality();


static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}",
    firstName.Contains("y"));
    Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();
}

StringConcatenation();
static void StringConcatenation()
{
    Console.WriteLine("=> String concatenation:");
    string s1 = "Programming the ";
    string s2 = "PsychoDrill (PTP)";
    string s3 = String.Concat(s2, s1);
    Console.WriteLine(s3);
    Console.WriteLine();
}

StringInterpolation(); static void StringInterpolation()
{
    String name = "Shubham Kumar";
    int age = 21;

    Console.WriteLine($"My name is {name} and my age is {age}");
    Console.WriteLine(String.Format("My name is {0} and my age is {1}", name, age));
}

int temp = 10;
Console.WriteLine($@"This is called verbatim string c://Program//system32\
    Here i can also write para with spaces and it will be interperated as i write
    Interpolation can also happen here {temp} but have to use $ sign as well 
the order of $@ does not matter it will still work
");

StringEquality();  static void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Test these strings for equality.
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}

FunWithStringBuilder();  static void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("*** This is a good library for strings ***", 256); // This will be the inital size but if increase then it will copy itself to new instance and grow according to the size
    sb.Append("\n");
    sb.Append("This is also a function to add item in a stringbuilder object");
    sb.AppendLine("Morrowind");
    sb.AppendLine("Deus Ex" + "2");
    sb.AppendLine("System Shock");
    Console.WriteLine(sb);
    sb.Replace("2", " Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chars.", sb.Length);
}