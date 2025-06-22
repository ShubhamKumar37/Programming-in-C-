class Person
{
    public int age;
    public string name;

    public Person(int age, string name)
    {
        this.name = name;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine("This is your name = {0} and this is your age = {1}", name, age);
    }

}

class Program
{
    public static void SendAPersonByValue(Person p)
    {
        p.name = "Kunal";
        p.age = 100;
        p = new Person(20, "Rajesh");
    }
    public static void Main(string[] args)
    {
        Person p = new Person(32, "Rahul");
        p.Display();

        SendAPersonByValue(p);
        p.Display();
        Console.WriteLine(p.name);
    }
}