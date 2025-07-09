using IssueWithNonGenericeCollections;
using System.Collections;

int[] intArr = { 34, 2, 4, 6, 2, 34, 564, 2 };
Array.Sort(intArr);
foreach(int i in intArr) Console.WriteLine(i);

static void UsePersonCollection()
{
    Console.WriteLine("***** Custom Person Collection *****\n");
    PersonCollection myPeople = new PersonCollection();
    myPeople.AddPerson(new Person("Homer", "Simpson", 40));
    myPeople.AddPerson(new Person("Marge", "Simpson", 38));
    myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
    myPeople.AddPerson(new Person("Bart", "Simpson", 7));
    myPeople.AddPerson(new Person("Maggie", "Simpson", 2));
    // This would be a compile-time error!
     //myPeople.AddPerson(new Car()); // As this function is trying to convert this car obejct to person 
    foreach (Person p in myPeople)
    {
        Console.WriteLine(p);
    }
}


SimpleBoxUnboxOperaion();
static void SimpleBoxUnboxOperaion()
{
    int myInt = 234;
    object boxedInt = myInt; // This is called boxing where value type are stored inside a reference type
    //int unBoxedInt = (int)boxedInt; // This is unboxing which mean getting from reference type to variable type which was early the value type
    try
    {
        long unboxedLong = (long)boxedInt;
    }
    catch (InvalidCastException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

WorkWithArray();
static void WorkWithArray()
{
    ArrayList arr = new ArrayList();
    arr.Add(1); 
    arr.Add(4); 
    arr.Add(6);
    arr.Add("Shubham");

    string value = (string)arr[3]; // This is called unboxing as the array list box the element in head
    Console.WriteLine("This the first value {0}", value);
}

static void UseGenericList()
{
    List<Person> ls = new List<Person>();
    ls.Add(new Person("Shubham", "Kumar", 21));

    List<int> l1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
    l1.Add(123);
    l1.AddRange(new List<int>{ 34, 4, 2, 43});
}

public class Car
{
    public int Sped { get; set; }
}
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person() { }
    public Person(string firstName, string lastName, int age)
    {
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}