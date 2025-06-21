//Console.WriteLine("***** Fun with type conversions *****");
//// Add two shorts and print the result.
//short numb1 = 9, numb2 = 10;
//Console.WriteLine("{0} + {1} = {2}",
//numb1, numb2, Add(numb1, numb2));
//Console.ReadLine();
static int Add(int x, int y) // This is weidening (short to int)
{
    return x + y;
}
// But implict conversion of int to short is not possible

//static void NarrowingAttempt()
//{
//    byte myByte = 0;
//    int myInt = 200;
//    myByte = myInt; // as it is possible but due to the good compiler it is not allowing because 200 can be fit inside a byte
//    Console.WriteLine("Value of myByte: {0}", myByte);
//}

ProcessByte();  static void ProcessByte()
{
    byte b1 = 100;
    byte b2 = 200;

    try
    {
        checked
        {
            byte sum = (byte)Add(b1, b2);

            Console.WriteLine(sum);

        }
    }
    catch(OverflowException e){
        Console.WriteLine(e);
    }
}