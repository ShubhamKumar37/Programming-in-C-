using System.Security.Cryptography;

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
        //Employee emp1 = new Employee("Shubham Kumar", 21, 1002, 1200000, "223223442", PayType.Comission);
        //emp1.DisplayContant();
        //emp1.GiveBonus(20000);
        //emp1.DisplayContant();


        //Employee.BenefitPackage.BenefitsPackageLevels EmployeePackageLevelType = Employee.BenefitPackage.BenefitsPackageLevels.Gold;
        //SalesPerson sp1 = new SalesPerson { Age = 22, Name = "Shubham Kumar", SalesNumber = 43 };
        Manager Chucky = new Manager("Shubham Kumar", 22, 101, 1000000, "323432423", 12221);
        Console.WriteLine("This is the benefit cost = {0}", Chucky.GetBenefitCost());
        Chucky.GiveBonus(323);
        Chucky.DisplayContant();
        //SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
        //fran.GiveBonus(200);
        //fran.DisplayContant();

        //Employee emp1 = new Employee(); // This is because the abstract class can not be use to create object

    }
}

//OuterClass.publicInnerClass inner; // This will work 
//OuterClass.PrivateInnerClass inner; // Really not OK , compilation error, cann't access the private class
