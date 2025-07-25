﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected Shape() { }
        protected Shape(string name) {
            PetName = name;
        }

        public string PetName { get; set; }

        public abstract void Draw();  // If i mark a method as abstract then i have to leave its body empty
            // also abstract method can only define inside a abstract class
    }

    public class Circle : Shape // If i donot implement the Draw() method then i have to mark this class as abstarct else compilation error
    {
        public Circle() { }
        public Circle(string name): base(name) { }

        public override void Draw()
        {
            Console.WriteLine("This is also a circle draw method and i need a 360 deg and my pet name is {0}", PetName);
        }

    }

    public class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name): base(name) { }

        public override void Draw()
        {
            Console.WriteLine("This is the hexagon shape and we are about to do it");
        }
    }

    class ThreeDCircle : Circle
    {
        // here new keyword is use to intentionally ignore the original implementation
        public new string PetName {get; set;}
        
        //public override void Draw() // I will get a warning because of not using override keyword
        //{
        //    Console.WriteLine("This is a 3d circle");
        //}

        // These are called shadowed members 
        public new void Draw()  // this new keyword tells explicitly that this implementation is created to ignore the parent implementation
        {
            Console.WriteLine("This is a 3d circle");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Hexagon hex = new Hexagon("Hexgon");
            hex.Draw();

            Circle circle = new Circle("Circle");
            circle.Draw();
            Shape d3Circle = new ThreeDCircle();
            d3Circle.Draw();

            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda")};
            // we cannot create a direct instance of abstarct class but we can store the refernce of it dreived classes
            foreach(Shape i in myShapes) i.Draw();

            ThreeDCircle dc = new ThreeDCircle() { PetName = "HiCirlce"};
            dc.Draw();

            ((Circle)dc).Draw();// we can still use the implementation of base abstract class using explicit type casting

            object hexagon = new Hexagon("HIHI");
            ((Hexagon)hexagon).Draw(); // Here this object does know about the hexagon so we have to explicitly cast it to its required class

            object[] arr = new object[3];
            arr[0] = new Circle("This is a circle");
            arr[1] = "String";
            arr[2] = false;

            foreach (var i in arr)
            {
                Circle h = i as Circle;
                //if (h is null) Console.WriteLine("This is not a hexagon object");
                if (h is Circle) Console.WriteLine("Gotta before the original Gotta"); // This will just check if the given object is type of the given class or not
                else if (h is var _)Console.WriteLine("Gotta a nigga"); // By this way we can create a catch hall in which if any of these does not work then here flow has to fall
            }

            Shape sh = new Hexagon("Meis hexa");
            switch (sh)
            {
                case  Circle cr:
                    Console.WriteLine("This is a circle");
                    break;
                case Hexagon h when h.PetName == "Meis hexa":
                    Console.WriteLine("This is a hexagon");
                    break;
                case Shape _:
                    Console.WriteLine("This is nothing from shape or discards");
                    break;
                default:
                    Console.WriteLine("None of these are fr");
                    break;

            }

        }
    }
}