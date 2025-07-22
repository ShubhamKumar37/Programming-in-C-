using System.Reflection;

static void ListMethods(Type t)
{
    MethodInfo[] methods = t.GetMethods();
    foreach (MethodInfo method in methods)
    {
        Console.WriteLine($"-> {method.Name}");
    }
}
