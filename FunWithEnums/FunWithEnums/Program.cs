using System.Diagnostics.Contracts;
using System.Text;
using System;

enum DaysType
{
    Sunday = 0, Monday = 1, Tuesday = 2, Wednesday = 3, Friday = 5, Saturday = 6
};
// We can also assign some value to them and by default first value have 0 as the value
enum EmpTypeEnum : byte // We can also assign the data storage data type
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100
    //Vi = 999  // This will give error because it is out of range of byte
};

class Program
{
    public static void Main(string[] args)
    {
        EmpTypeEnum e = EmpTypeEnum.Contractor;
        Console.WriteLine(e);

        //e = Manager; // This is actually wrong we cannot do this
        Console.WriteLine(Enum.GetUnderlyingType(e.GetType()));
        Console.WriteLine(e.GetType()); // Name of the enum variable
        Console.WriteLine(typeof(EmpTypeEnum));
        Console.WriteLine("emp is a {0}, {1}", e.ToString(), (System.Byte)e); // We can use this to get the value of the enum

        EvaluateEnum(e);
    }

    static void EvaluateEnum(System.Enum e)
    {
        Console.WriteLine("Underlying stoarage type is {0}, and the name is {1}", System.Enum.GetUnderlyingType(e.GetType()), e.GetType().Name);
        Array enumArray = Enum.GetValues(e.GetType()); // GetValues() will give us the array of enum values;
        for (int i = 0; i < enumArray.Length; i++) Console.WriteLine(enumArray.GetValue(i)); // GetValue(i) will help to see the actual value

        DayOfWeek dw = DayOfWeek.Sunday;
        Array arr = Enum.GetValues(dw.GetType());

        foreach (var i in arr) Console.WriteLine(i);
    }
}

