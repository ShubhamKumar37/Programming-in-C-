int? nullNum = null;
// Null-Coalescing operator
//nullNum ??= 22;
int[] arr = null;

Console.WriteLine("This is value of nullNum = {0}", nullNum);
Console.WriteLine($"This is the length of the array = {arr?.Length ?? 0}");