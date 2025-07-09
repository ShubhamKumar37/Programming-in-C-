using CustomEnumerator;
using System.Collections;

Garage gr = new Garage();

IEnumerator iec = gr.GetEnumerator();
//iec.MoveNext(); // We have to move the iterator atleast one for getting correct result else compilation error
//iec.MoveNext();
Car gc = (Car)iec.Current;
Console.WriteLine($"This is the speed {gc.CurrSped} and name is {gc.PetName}");
//foreach (Car i in gr) Console.WriteLine("This is carr {0}", i.CurrSped);

public class Garage : IEnumerable
{
    private Car[] carArray = new Car[4];
    // Fill with some Car objects upon startup.
    public Garage()
    {
        carArray[0] = new Car("Rusty", 30);
        carArray[1] = new Car("Clunker", 55);
        carArray[2] = new Car("Zippy", 30);
        carArray[3] = new Car("Fred", 30);
    }

    public IEnumerator GetEnumerator()
    {
        return carArray.GetEnumerator();
    }
}