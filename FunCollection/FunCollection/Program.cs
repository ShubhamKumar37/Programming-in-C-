using System;
using System.Collections;
using System.Collections.Generic;

ArrayList strArray = new ArrayList();
strArray.AddRange(new string[] { "Shubham", "Sparsh", "Yash" });

foreach (var i in strArray) Console.WriteLine(i);
Console.WriteLine("Size of array list is {0}", strArray.Count);

strArray.Add("Harsh");
foreach (var i in strArray) Console.WriteLine(i);