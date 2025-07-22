public class Program
{
    static async Task<string> DoWork()
    {
        return await Task.Run(() =>
        {
            Console.WriteLine("This is a function");
            Thread.Sleep(2000);
            return "Yes i am doing some task";
        });
    }

    static async Task VoidMethodAsync() // To make this work use Task instead of void
    {
        await Task.Run(() =>
        {
            Thread.Sleep(1000);
            throw new Exception("Something bad happened");
        });
        Console.WriteLine("I am inside the async method");
        Console.ReadLine();
    }

    static async Task MultipleAwaits()
    {
        //await Task.Run(() => { Thread.Sleep(2_000); });
        //Console.WriteLine("Done with first task!");
        //await Task.Run(() => { Thread.Sleep(2_000); });
        //Console.WriteLine("Done with second task!");
        //await Task.Run(() => { Thread.Sleep(2_000); });
        //Console.WriteLine("Done with third task!");

        // Instead of this we can use WhenAll() method to run multiple at the same time
        // Also there is WhenAny() which will return the first task which is completed and move but rest will also run and give the result 
        // here it just give signal that the first one is completed
        await Task.WhenAll(Task.Run(() =>
        {
            Thread.Sleep(2_000);
            Console.WriteLine("Done with first task!");
        }), Task.Run(() =>
        {
            Thread.Sleep(1_000);
            Console.WriteLine("Done with second task!");
        }), Task.Run(() =>
        {
            Thread.Sleep(1_000);
            Console.WriteLine("Done with third task!");
        }));
    }

    static async ValueTask<int> ReturnInt()
    {
        await Task.Run(() => Thread.Sleep(200));
        return 10;
    }

    static async Task Main(string[] args)
    {
        //Console.WriteLine(await DoWork().ConfigureAwait(false)); // Using ConfigureAwait(false) make it litter and work fast 
        // Async method return Task or Task<T> object in which await keyword help to extract the value inside of it 
        //static string DoWork() // Instead of this we can use async/await
        //{
        //    Console.WriteLine("This is a function");
        //    Thread.Sleep(2000);
        //    return "Hi i am doing my work";
        //}

        try
        {
            //await VoidMethodAsync(); // void method can not be awaited
            await MultipleAwaits(); // Result may differ because now all are running at same time so the lowest sleep time one will execute quickly
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }
    //public static void Main(string[] args)
    //{
    //    //VoidMethodAsync(); // This will cause issue as the execution flow will go normally and will not wait for completing the code
    //    //Console.WriteLine("Completed");
    //    try
    //    {
    //        VoidMethodAsync();
    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine(e.ToString()); 
    //    }
    //}
}