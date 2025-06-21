using System.Linq;

DeclareImplicitVars();  static void DeclareImplicitVars()
{
    // Implicitly typed local variables
    // are declared as follows:
    // var variableName = initialValue;
    var myInt = 0;
    var myBool = true;
    var myString = "Time, marches on...";
    Console.WriteLine(myString.GetType().Name);
    Console.WriteLine(myBool.GetType().Name);
    Console.WriteLine(myInt.GetType().Name);
}

class ThisWillNeverCompile
{
    // Error! var cannot be used as field data!
    //private var myInt = 10;
    // Error! var cannot be used as a return value
    // or parameter type!
    //public var MyMethod(var x, var y) { }

    // We cannot declare var as a return type, parameter or field datatype
    //var myVar; // We can not just declare a var variable we need to initialize it but not with null else compilation error
    // if we create a interface instance using new keyword then asign it a null then there will be no problem (maybe)

    // if we assign a var variable to other yes it is correct if return type of a function is int then we return var variable which is int itself then it is possible
    // After initalizing a var variable with a data type value then we cannot reassign it as the compiler knows that variable have different datatype

}
