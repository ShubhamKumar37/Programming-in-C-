using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritence
{
    public record Car
    {
        public string Make {  get; init; }
        public string Model{  get; init; }
        public string Color {  get; init; }

        public Car(string Make, string Model, string Color)
        {
            this.Make = Make;
            this.Model = Model;
            this.Color = Color;
        }
    }
}

public class ClassType { }
public record RecordType { }

// Record can not inherit class type and class can not inherit record type
//public class test1 : RecordType { }
//public record test2 : ClassType { } 