QueryOverString(); static void QueryOverString()
{
    string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "Shock 2"};
    IEnumerable<string> subset = from i in currentVideoGames where i.Contains(" ") orderby i select i;
    ReflectOverQueryResults(subset);
    foreach(string s in subset) Console.WriteLine(s);
}
QueryOverStringWithExtensionMethod(); static void QueryOverStringWithExtensionMethod()
{
    string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "Shock 2"};
    IEnumerable<string> subset = currentVideoGames.Where(i => i.Contains(" ")).OrderBy(i => i).Select(i => i);
    foreach(string s in subset) Console.WriteLine(s);
}


QueryOverInt(); static void QueryOverInt()
{
    int[] numbers = new int[]{ 4, 3, 5, 7, 312, 3, 243, 123, 12 };
    //IEnumerable<int> num = from i in numbers where i < 20 select i; // we could also use var for this 
    var nums = from i in numbers where i < 20 select i;

    // Here the query does not evaluated in above as when we apply some operation on the query holding variable then it is 
    // evauluated and we work on that result and if some line after if we again use the same variable then again it will be evaluated
    
    foreach(int i in nums) Console.WriteLine(i);

}
static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
{
    Console.WriteLine($"***** Info about your query using {queryType} *****");
    Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
    Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
}

DefaultWithEmpty(); static void DefaultWithEmpty()
{
    int[] numbers = new int[] { 4, 3, 5, 7, 312, 3, 243, 123, 12 };
    foreach (var i in (from j in numbers where j > 10000 select j).DefaultIfEmpty(-1)) Console.WriteLine(i);
}

IEnumerable<string> strArr = GetStringSubset();
//foreach (var i in strArr) Console.WriteLine(i);
foreach(string i in GetStringSubset()) Console.WriteLine(i);
static IEnumerable<string> GetStringSubset()
{
    string[] arr = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };
    return (from i in arr where i.Contains(" ") select i);
}