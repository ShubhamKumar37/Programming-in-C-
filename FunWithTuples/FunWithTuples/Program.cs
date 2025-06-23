(int, string, int) val1 = (123, "Shubham Kumar", 342);
var val2 = (123, "Sparsh Sharma", 2342, false);

Console.WriteLine($"This is the value 1 = {val1.Item1}");
Console.WriteLine($"This is the value 1 = {val1.Item2}");
Console.WriteLine($"This is the value 1 = {val1.Item3}");
//Console.WriteLine($"This is the value 1 = {val1.Item4}"); // This will give compilation error

(int num1, string str1, int num2) val = (123, "Pratham", 122321);
var val3 = (key1: "Shubham Kumar", key2: false, key3: true, key4: 1323);
Console.WriteLine($"This is the value = {val3.key1}");
Console.WriteLine($"This is the value = {val3.key2}");
Console.WriteLine($"This is the value = {val3.key3}");
Console.WriteLine($"This is the value = {val3.key4}");

(int Field1, int Field2) example = (Custom1: 5, Custom2: 7);
// Here the compiler will listen to FieldX not with CustomX

var nt = (1, 2, new int[] { 13, 33, 4 }, ("shubham", false, true, 32));
foreach(int i in nt.Item3) Console.WriteLine(i);

var foo = new{prop1= 323, prop2= "Shubham"};
var tup = (foo.prop1,  foo.prop2);
Console.WriteLine($"This is the value = {tup.Item1}");
Console.WriteLine($"This is the value = {tup.Item2}");
