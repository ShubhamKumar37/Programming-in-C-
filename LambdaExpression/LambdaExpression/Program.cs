namespace LambdaExpression;
using System.Collections.Generic;

//public List<T> FindAll(Predicate<T> match);

//public delegate bool Predicate<T>(T obj);


class Program
{ 
    public delegate void MessageMe();
    public static void Main(string[] args)
    {
        TraditionalDelegateSyntax();
        MessageMe mm = new MessageMe(() => Console.WriteLine("Here is your message"));
    }
    static void TraditionalDelegateSyntax()
    {
        List<int> list = new List<int>();
        list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
        Predicate<int> callBack = Program.IsEven;
        //List<int> evenNumbers = list.FindAll(callBack); // Instead of calling this function seperate method we could use anonymous methods
        //List<int> evenNumbers = list.FindAll(delegate(int i) { return (i % 2 == 0); }); // We can again reduce this using lambda methods
        //List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
        //List<int> evenNumbers = list.FindAll((int i) => (i % 2) == 0); // We can wrap the parameter with data type like this
        List<int> evenNumbers = list.FindAll((int i) => {
            Console.WriteLine("This is the number {0}", i);
            if (i % 2 == 0) return true;
            return false;
        }); // We can write multiple statement as well 
        foreach (int i in evenNumbers) Console.Write("{0}, ", i);
    }

    static bool IsEven(int num) => num % 2 == 0;
}

