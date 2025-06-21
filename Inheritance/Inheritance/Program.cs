using System;

namespace Inheritance { 
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee clerk = new Employee();
            clerk.IdNum = 1002;
            clerk.Salary = 10000;
            Console.WriteLine(clerk.GetGreeting());

            CommisionEmployee emp1  = new CommisionEmployee();
            emp1.IdNum = 1;
            emp1.Salary = 2000;
            emp1.CommisionRate = 10;
            Console.WriteLine(emp1.GetGreeting());

            Employee salesEmployee = new SalesPerson();
        }
    }
}