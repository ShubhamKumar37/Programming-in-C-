using System.Collections;

PersonCollection myPeople = new PersonCollection();
myPeople[0] = new Person("Homer", "Simpson", 40);
myPeople[1] = new Person("Marge", "Simpson", 38);
myPeople[2] = new Person("Lisa", "Simpson", 9);
myPeople[3] = new Person("Bart", "Simpson", 7);
myPeople[4] = new Person("Maggie", "Simpson", 2);
// Now obtain and display each item using indexer.
for (int i = 0; i < myPeople.Count; i++)
{
    Console.WriteLine("Person number: {0}", i);
    Console.WriteLine("Name: {0} {1}",
    myPeople[i].FirstName, myPeople[i].LastName);
    Console.WriteLine("Age: {0}", myPeople[i].Age);
    Console.WriteLine();
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
public class PersonCollection : IEnumerable
{
    private ArrayList arPeople = new ArrayList();
    // Cast for caller.
    public Person GetPerson(int pos) => (Person)arPeople[pos];
    // Insert only Person objects.
    public void AddPerson(Person p)
    {
        arPeople.Add(p);
    }
    public void ClearPeople()
    {
        arPeople.Clear();
    }
    public int Count => arPeople.Count;
    // Foreach enumeration support.
    IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();

}