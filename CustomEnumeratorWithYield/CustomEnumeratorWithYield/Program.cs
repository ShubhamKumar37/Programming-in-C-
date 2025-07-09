using CustomEnumeratorWithYield;
using System.Collections;

Garage gr = new Garage();
IEnumerator enumt = gr.GetEnumerator();
enumt.MoveNext();

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

    //public IEnumerator GetEnumerator()
    //{
    //    foreach (Car i in carArray) yield return i;
    //}

    public IEnumerator GetEnumerator()
    {
        //This will not get thrown until MoveNext() is called
        throw new Exception("This won't get called");
        foreach (Car c in carArray)
        {
            yield return c;
        }
    }
}