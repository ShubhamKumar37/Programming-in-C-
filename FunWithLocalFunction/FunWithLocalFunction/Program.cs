using System.Diagnostics.CodeAnalysis;

//Console.WriteLine(AddWrapper(3, 2));
//static int AddWrapper(int a, int b)
//{
//    return Add(a, b);
//    int Add([NotNullWhen(true)]int x, int y) => x + y;
//}

Console.WriteLine(AddWrapperWithSideEffect(5, 2)); static int AddWrapperWithSideEffect(int x, int y)
{
    //Do some validation here
    return Add();
    static int Add() // Local variable can change the value of variable so to prevent this we use static keyword so that they cannot access the parent varaibles
    {
        //x += 1;
        return x + y;
    }
}
