// See https://aka.ms/new-console-template for more information

using System;

namespace ClassDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Employee emp1 = new Employee()
            //{
            //    EmployeeId = 1, Name = "Shubham Kumar", BasePay = 240000
            //};
            Employee emp1 = new Employee // We can remove the paranthesis
            {
                EmployeeId = 1, // This cann't happen due to init only.
                Name = "Shubham Kumar",
                BasePay = 240000
            };

            emp1.Display();

            //emp1.Name = "Shubham Kumar";
            //emp1.EmployeeId = 101;
            //emp1.BasePay = 2232;




            //Console.WriteLine("This is a console app");
            //Car car1;
            //car1 = new Car();
            //Car car2 = new Car();

            //car1.petName = "Shubham";
            //car2.petName = "Sparsh";

            //Console.WriteLine(car2.petName);
            //car1.PrintState();
            //car2.PrintState();  

            //car1.SpeedUp(10);
            //car2.SpeedUp(20);

            //car1.PrintState();
            //car2.PrintState();

            //car1.Color = "Green";
            //Console.WriteLine(car1.Color);

            //car1.CurrSpeed = 2;
            //car1.PetName = "shubham";

            //Console.Write(car1.CurrSpeed);
            //Console.Write(car1.PetName);
        }
    }
}