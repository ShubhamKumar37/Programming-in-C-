AddParams ad = new AddParams(5, 10);
Thread newT = new Thread(new ParameterizedThreadStart(Add));
newT.Start(ad);

void Add(object data)
{
    if (data is AddParams ad)
    {
        Console.WriteLine("This is the sum = {0} ", ad.a + ad.b);
    }
}

public class AddParams
{
    public int a, b;

    public AddParams(int a, int b)
    {
        this.a = a;
        this.b = b;
    } 
}