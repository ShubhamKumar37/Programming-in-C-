// Value types cannot be set to null!
//bool myBool = null;
//int myInt = null;
#nullable disable

namespace FunWithNullableDataType
{
    class Program
    {
        public class TestClass
        {
            public string name { get; set; }
            public int age { get; set; }
        }

        public static void Main(string[] args)
        {
            int? nullNum = null;
            bool? nullBool= false;
            int?[] arr = new int?[10]; // we have to specify both side of arr
            Nullable<int> newInt = null;

            TestClass? obj = null;
            TestClass obj2 = obj; // This will generate a warning 

        }

    }
}


