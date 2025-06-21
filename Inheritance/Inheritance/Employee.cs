using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        private double salary;
        public int IdNum { get; set; }

        public double Salary
        {
            set
            {
                const double MIN = 15_000;
                if (value < MIN) salary = MIN;
                else salary = value;
            }
            get { return salary; }
        }

        // Method
        public virtual string GetGreeting()
        {
            string greeting = $"Hello! I am a employee #{IdNum} and the salary is {salary}";
            return greeting;

        }
    } // Employee class ends

    // Extend class
    class CommisionEmployee : Employee
    {

        //Employee[] list; 
        //public CommisionEmployee(int id, int salary): base(salary) 
        public double CommisionRate { get; set; }

        public override string GetGreeting()
        {
            string greeting1 = base.GetGreeting();
            string greeting = $"I work on commision -> {CommisionRate}" + greeting1;
            return greeting;
        }
    }

    class SalesPerson : CommisionEmployee
    {
        public int SalesNumber { set; get; }
        public int GetCommisionRate()
        {
            base.GetHashCode();
            return 1;
        }
    }

}
