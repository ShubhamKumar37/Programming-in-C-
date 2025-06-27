namespace Employee;

class Program
{
    public static void Main(string[] args)
    {
        //Employee emp1 = new Employee("Shubham Kumar", 1002, 1200000);
        //emp1.GiveBonus(21110);
        //emp1.DisplayContant();
        ////Console.WriteLine("Your name is {0}", emp1._name); // Wrong again
        //Console.WriteLine("Your name is {0}", emp1.GetName());
        //emp1.SetName("Spar");
        //Console.WriteLine("Your name is {0}", emp1.GetName());
        ////emp1._name = "Shubham Kumar"; // We will get compilation error because it is private

        //emp1.EmpId = 21213;
        //emp1.CurrPay = 32233234;
        //emp1.DisplayContant();
        Employee emp1 = new Employee("Shubham Kumar", 21, 1002, 1200000, "223223442", PayType.Comission);
        emp1.DisplayContant();
        emp1.GiveBonus(20000);
        emp1.DisplayContant();
    }
}