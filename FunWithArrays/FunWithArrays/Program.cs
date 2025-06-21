using System.Numerics;
using System.Security.Cryptography;

Console.WriteLine("This is a simple array");

//SimpleArray();
static void SimpleArray()
{
    int[] arr = { 1, 2, 3 };
    int[] arr2 = new int[10]; // By default it store 0 
    string[] strArr = new string[10]; // Array of string of size 10
    string[] strArr2 = new string[] {"Shubham", "Kumar", "Sparsh", "Sharma" }; // This way we donot need to specify the array size
    // And we specify the array and allote more value then it, we will get error
    arr2[0] = 1;
    arr2[1] = 3;
    arr2[2] = 4;

    foreach (string i in strArr2) Console.WriteLine(i);
}


//DeclareImplicitArray(); 
static void DeclareImplicitArray()
{
    var arr = new[] { 1, 2, 3 }; // Now this will become int array;
    var arr2 = new[] { "Shubham", "Kumar" }; // This become string array and we cannot reinitialze a var variable;
    //var d = new[] { 1, "one", 2, "two", false }; // Mix type will generate error
}

//ArrayOfObject(); 
static void ArrayOfObject()
{
    object[] arr = new object[4];
    arr[0] = 12;
    arr[1] = "Shubham Kumar";
    arr[2] = new DateTime(2025, 6, 21);
    arr[3] = false;

    foreach(object i in arr) Console.WriteLine("Type: {0}, Value: {1}", i.GetType(), i);
}

//Matrix();
static void Matrix()
{
    int[,] mat;
    mat = new int[4, 3];

    for(int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; j++) Console.WriteLine("This is the index {0}", i + j + 1);
    }
}

//JaggedMatrix(); 
static void JaggedMatrix()
{
    int[][] matrix = new int[4][]; // We have to give a length to this array;

    for (int i = 0; i < matrix.Length; i++) matrix[i] = new int[i + 3];
    for (int i = 0; i < matrix.Length; i++)
    {
        for(int j = 0; j < matrix[i].Length; j++) Console.Write(matrix[i][j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] arr = { 1, 2, 3, 4 };
//PrintArray(arr);
static void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write("{0} ", arr[i]);
}

Console.WriteLine(GetStringUpper("Shubham kumar")); static string GetStringUpper(string str)
{
    return str.ToUpper();
}

//ReverseAndClear(); 
static void ReverseAndClear()
{
    int[] arr = { 1, 2, 3, 4, 5 };

    //foreach(int i in arr) Console.Write("{0} ", i);
    //Console.WriteLine();

    //Array.Reverse(arr);
    //foreach(int i in arr) Console.Write("{0} ", i);
    //Console.WriteLine();

    //Array.Clear(arr, 2, 3); // Second parameter is start index and third is the length if we exceed it we will get error
    //foreach (int i in arr) Console.Write("{0} ", i);
    //Console.WriteLine();

    //for (int i = 0; i < arr.Length; i++)
    //{
    //    Index idx = i;
    //    // Print a name
    //    Console.Write(arr[idx] + ", ");
    //}
    //Console.WriteLine();

    //for(int i = 1; i <= arr.Length; i++)
    //{
    //    Index ind = ^i; Console.Write(arr[ind] + ", ");
    //}

    foreach (int i in arr[0..3]) Console.WriteLine("{0} ", i); // This move in 0, 1, 2(n - 1) only 
    Range r = 1..4;
    foreach (int i in arr[r]) Console.WriteLine(i);

    Index idx1 = 0;
    Index idx2 = 2;
    r = idx1..idx2; //the end of the range is exclusive
    foreach (var itm in arr[r])
    {
        // Print a name
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");
    //Console.WriteLine(arr[0..3])); // This is not allowed
    Console.WriteLine(arr.ElementAt(^1));

}

Console.WriteLine(add(3, 2)); static int add(int x, int y) =>  x + y;