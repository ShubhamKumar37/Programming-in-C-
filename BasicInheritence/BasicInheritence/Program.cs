Car car1 = new Car(120) { Speed = 40 };
MiniVan mn1 = new MiniVan() { Speed = 80 };
Console.WriteLine("My car is going {0} MPH", car1.Speed);
Console.WriteLine("My mini van is going {0} MPH {1}", mn1.Speed, mn1.maxSpeed);

//mn1._currSpeed = 121; // This will cause error because that member is private in Car class 
// Private access modifier only allows us to have the access inside the class only not outside any where 

class Car
{
    public readonly int maxSpeed;
    private int _currSpeed;

    public Car() { maxSpeed = 60; }
    public Car(int maxSpeed) { this.maxSpeed = maxSpeed; }

    public int Speed
    {
        get => _currSpeed; 
        set
        {
            _currSpeed = value;
            if (_currSpeed > maxSpeed) _currSpeed = maxSpeed;
        }
    }
}

// Inheritennce of Car class by derived class MiniVan
// C# doesnot allow multiple inheritance which mean a class have 2 base classes 
// This sealed keyword will not allow any other class to inherit this one
sealed class MiniVan : Car { 

    public void TestMethod()
    {
        Speed = 120; // This will work because of public
        //_currSpeed = 23; // This will not work and cause issue 

    }
}

//class DeluxeMiniVan : MiniVan { } // Now here we have a compilation error
//class MyString : String { }  // This will also cause error because String is a sealed class defined by c# itself
