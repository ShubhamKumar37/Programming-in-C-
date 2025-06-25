using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    //internal class Radio // This is same as class Radio
    //{
    //    Radio() { } // This is a private default constructor
    //}

    // A public classs with public constructor
    public class Radio
    {
        public Radio() { }
    }

    public class SportsCar // Non-nesting types can not be assigned with private as we will get error 
    {
        private enum CarColor { red, green, black}
    }
}
