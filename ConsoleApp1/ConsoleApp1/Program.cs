using System;

namespace Program { 
    class Employee { }
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //string name = "Shubham Kumar";
            //Console.WriteLine("Hello world");
            //Console.WriteLine($"This is me ${name} {80000} Rs");
            //Console.ReadLine();

            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //int[,] arr2 = new int[2, 4]; // This is a 2d array 2 is the row and 4 is column
            //int[][] arr3 = new int[5][]; // Only Row is required;

            //for(int i =  0; i < arr.Length; i++) Console.WriteLine(arr[i]); // default value will be 0;
            //foreach(int i in arr) Console.WriteLine(i);

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr2.GetLength(i + 1); j++) Console.WriteLine(arr2[i, j]);
            //}

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    for(int j = 0; j < arr3[i].Length; j++) Console.WriteLine($"{arr3[i][j]}");
            //}

            //Object obj1 = "1232";
            //Object obj2 = 123;

            //switch (obj2){
            //    case string s: 
            //        Console.WriteLine("This is a string", s);
            //        break;
            //    case int a: Console.WriteLine("This is a number", a);
            //        break;
            //    default: break;

            //}

            //Object[] data = { 23, null, new Employee(), "Shubham Kumar" };
            //foreach(Object i in data)
            //{
            //    if (i is Employee) Console.WriteLine("This is a object = ", i);
            //    else if (i is var catcher) Console.WriteLine("This is a error - ", catcher.GetType().Name);
            //    //else Console.WriteLine("This is rest elements = ", i);

            //}
            //var name = "Shubham Kumar";
            //Console.WriteLine(name.GetType().Name);
            //Console.WriteLine((12342342342343).GetType().Name);

            //HelloWorld obj  = new HelloWorld();
            //obj.Display();
            //Login(); // As Login function is static so we donot need instance of class to call this method

            //Calculator calc = new Calculator();

            //Console.WriteLine(calc.Add(43, 23));
            //Console.WriteLine(calc.Add(43, 23, 34));
            //int a = 10;
            //int b = 20;
            //int c;

            //Console.WriteLine($"This is before: a = {a}, b = {b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"This is after: a = {a}, b = {b}");

            //Console.WriteLine(SalaryReturn(a, b, out c));
            //Console.WriteLine($"This is a out keyword parameter value = {c}");
            Message(message: "Hi i am Shubham Kumar", name: "Shubham Kumar");
        }

        static void Message(string name, string message)
        {
            Console.WriteLine($"Your name is {name} and {message}");
        }

        static int SalaryReturn(int a, int b, out int c)
        {
            c = a + b;
            return b;
        }
        static void Swap(ref int a, ref int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine($"This is a = {a}");
            Console.WriteLine($"This is b = {b}");

        }

        void Display()
        {
            Console.WriteLine("This is a display function which is not static");
        }

        static void Login()
        {
            Console.WriteLine("You are now login");
        }
    }
}
