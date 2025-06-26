using ConstData;

MyMathClass mc1 = new MyMathClass(23);
mc1.DisplayStats();
Console.WriteLine(MyMathClass.PI); // By default the const data member are static 
mc1.LocalStringConstVariable();
//mc1.PI = 32; // We cannot assign new value to const variable
//mc1.DisplayStats();

const string str1 = "Shubham ";
const string str2 = "Kumar";
const string str3 = $"{str1}{str2}"; // Const variable support string interpolation
Console.WriteLine(str3);
