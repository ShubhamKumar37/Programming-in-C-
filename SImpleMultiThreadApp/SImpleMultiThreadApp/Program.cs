using System.Threading;

Thread currThread = Thread.CurrentThread;
currThread.Name = "Main Thread";
Printer p = new Printer();

Thread secondThread = new Thread(new ThreadStart(p.PrintNumber));
secondThread.Name = "Second thread";
secondThread.Start();
public class Printer
{
    public void PrintNumber()
    {
        Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(" -> {0} is printing number {1}", Thread.CurrentThread.Name, i);
            Thread.Sleep(100);
        }
    }
}