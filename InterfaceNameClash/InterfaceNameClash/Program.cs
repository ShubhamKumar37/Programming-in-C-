Octagon oct = new Octagon();

//oct.Draw();
((IDrawToMemory)oct).Draw();
if (oct is IDrawToFrom dtf)
{
    dtf.Draw();
}

public interface IDrawToFrom
{
    void Draw();
}

public interface IDrawToMemory
{
    void Draw();
}
public interface IDrawToPrinter
{
    void Draw();
}

class Octagon: IDrawToFrom, IDrawToMemory, IDrawToPrinter
{
    //public void Draw() // Instead of this we can use explicit interface implementation syntax
    //{
    //    // Shared drawing logic.
    //    Console.WriteLine("Drawing the Octagon...");
    //}

    void IDrawToFrom.Draw() // We are not required to use any acess modifier as these are all private in nature and cann't be changed
    {
        Console.WriteLine("This is the interface of IDrawToForm");
    }
    void IDrawToMemory.Draw()
    {
        Console.WriteLine("This is the interface of IDrawToMemory");
    }
    void IDrawToPrinter.Draw()
    {
        Console.WriteLine("This is the interface of IDrawToPrinter");
    }
}