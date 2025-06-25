using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // I have to write the static else i will get compilor error

namespace StaticDataAndMembers
{
    static class TimeUtilClass
    {
        // If i do not mark all the method as static then i will face compilation error 
        public static void PrintTime() => WriteLine(DateTime.Now.ToShortTimeString());
        public static void PrintDate() => WriteLine(DateTime.Today.ToShortDateString());
    }
}
