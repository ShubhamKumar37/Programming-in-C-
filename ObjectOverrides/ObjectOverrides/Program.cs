using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{

    public class Person
    {
        public string FirstName {  get; set; }
        public string LastName{  get; set; }
        public int Age{  get; set; }
        public Person() { }
        public Person(int Age, string FirstName, string LastName) {
            this.Age = Age;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public override string ToString() => $"[FirstName: {FirstName}, LastName: {LastName}, Age: {Age}]";
        
        public override bool Equals(object obj)
        {
            //if(!(obj is Person temp)) return false;
            //if (!(this.FirstName == temp.FirstName) || !(this.LastName == temp.LastName) || !(this.Age == temp.Age)) return false;
            //return true;
            return obj?.ToString() == this.ToString();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());
            Person p2 = p1;
            object o = p2;

            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }

            Console.WriteLine(p2.ToString());
        }
    }
}
