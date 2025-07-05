using CustomInterface;
using System;
using System.Diagnostics;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CustomInterface
{

    public abstract class Shape
    {
        protected Shape() { }
        protected Shape(string name)
        {
            PetName = name;
        }

        public string PetName { get; set; }

        public abstract void Draw();  // If i mark a method as abstract then i have to leave its body empty
                                      // also abstract method can only define inside a abstract class
    }

    public class Circle : Shape // , IPointy // If i donot implement the Draw() method then i have to mark this class as abstarct else compilation error
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("This is also a circle draw method and i need a 360 deg and my pet name is {0}", PetName);
        }

        public byte Points => 123;
        public byte GetNumberOfPoints() => 3;
        public string PropName { get; set; }

    }

    public class Hexagon : Shape, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("This is the hexagon shape and we are about to do it");
        }

        public void Draw3D()
        {
            Console.WriteLine("This is 3d hexagon and i need to print it ");
        }
    }

    class ThreeDCircle : Circle, IDraw3D
    {
        // here new keyword is use to intentionally ignore the original implementation
        public new string PetName { get; set; }

        //public override void Draw() // I will get a warning because of not using override keyword
        //{
        //    Console.WriteLine("This is a 3d circle");
        //}

        // These are called shadowed members 
        public new void Draw()  // this new keyword tells explicitly that this implementation is created to ignore the parent implementation
        {
            Console.WriteLine("This is a 3d circle");
        }

        public void Draw3D()
        {
            Console.WriteLine("This is 3d circle and i need to print it ");
        }
    }

    public class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("This is a triangle cann't you see this ");
        }

        public byte Points => 123;
        public byte GetNumberOfPoints() => 3;
        public string PropName { get; set; }
    }

    //public class Pencil: IPointy { } // We have to declare all the methods and other variable from interface
    //public class Pencil: object, IPointy { } // We deriving object class with interface


    internal class Program
    {
        static void Main(string[] args)
        {

            Triangle tr1 = new Triangle();
            Console.WriteLine(tr1.GetNumberOfPoints());

            Circle c1 = new Circle("Gola");
            IPointy ip = null;
            try
            {
                ip = (IPointy)c1; // Explicit type casting to check wheather circle includes the property of ipointy or not
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            ip = c1 as IPointy;
            if (ip == null) Console.WriteLine("Opps it is not possible");
            else Console.WriteLine("Yes this is possible and here is the points = {0}", ip.Points);

            if (ip is IPointy i) Console.WriteLine("Yes ip is implementing interface");
            else Console.WriteLine("No it doesn't");

            var sq = new Square("Boxy") { NumberOfSides = 4, SideLength = 4 };
            sq.Draw();
            //This won't compile
            Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of { ((IRegularlyPointy)sq).Perimeter}"); // we have to explicity cast it because in sqare class there is no implementation for this
            // we can also do this , but due to this we can not use the property fo square
            IRegularlyPointy ipr = new Square("Choxy") { NumberOfSides=4, SideLength = 4 };

            Console.WriteLine($"Examle Property {IRegularlyPointy.ExampleProperty}");
            IRegularlyPointy.ExampleProperty = "New property man ";
            Console.WriteLine($"Examle Property {IRegularlyPointy.ExampleProperty}");


            //IPointy ip = new IPointy(); // interface and abstract cannot be instansiated 
            //Hexagon hex = new Hexagon("Hexgon");
            //hex.Draw();

            //Circle circle = new Circle("Circle");
            //circle.Draw();
            //Shape d3Circle = new ThreeDCircle();
            //d3Circle.Draw();

            //Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };
            //// we cannot create a direct instance of abstarct class but we can store the refernce of it dreived classes
            //foreach (Shape i in myShapes) i.Draw();

            //ThreeDCircle dc = new ThreeDCircle() { PetName = "HiCirlce" };
            //dc.Draw();

            //((Circle)dc).Draw();// we can still use the implementation of base abstract class using explicit type casting

            //object hexagon = new Hexagon("HIHI");
            //((Hexagon)hexagon).Draw(); // Here this object does know about the hexagon so we have to explicitly cast it to its required class

            //object[] arr = new object[3];
            //arr[0] = new Circle("This is a circle");
            //arr[1] = "String";
            //arr[2] = false;

            //foreach (var i in arr)
            //{
            //    Circle h = i as Circle;
            //    //if (h is null) Console.WriteLine("This is not a hexagon object");
            //    if (h is Circle) Console.WriteLine("Gotta before the original Gotta"); // This will just check if the given object is type of the given class or not
            //    else if (h is var _) Console.WriteLine("Gotta a nigga"); // By this way we can create a catch hall in which if any of these does not work then here flow has to fall
            //}

            //Shape sh = new Hexagon("Meis hexa");
            //switch (sh)
            //{
            //    case Circle cr:
            //        Console.WriteLine("This is a circle");
            //        break;
            //    case Hexagon h when h.PetName == "Meis hexa":
            //        Console.WriteLine("This is a hexagon");
            //        break;
            //    case Shape _:
            //        Console.WriteLine("This is nothing from shape or discards");
            //        break;
            //    default:
            //        Console.WriteLine("None of these are fr");
            //        break;

            //}

        }
    }

    //public abstract class ClonableTypes
    //{
    //    public abstract object Clone();
    //}

    //public interface IClonable
    //{
    //    object Clone();
    //}
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Interfaces");
    //        CloneableExample();
    //    }
    //    static void CloneableExample()
    //    {
    //        // These classes implement ICloneable
    //        string myStr = "Hello";
    //        OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());

    //        // Therefore, we can pass them into a method expecting ICloneable
    //        CloneMe(myStr);
    //        CloneMe(unixOS);
    //    }

    //    static void CloneMe(ICloneable c)
    //    {
    //        // Clone whatever we get and print the type name
    //        object theClone = c.Clone();
    //        Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
    //    }
    //}
}


//namespace CustomInterfaces
//{
//    public abstract class ClonableTypes
//    {
//        public abstract object Clone();
//    }

//    public interface IClonable
//    {
//        object Clone();
//    }


//    internal class Program
//    {  
//        static void Main(string[] args)
//        {
//        }
//    }
//}
