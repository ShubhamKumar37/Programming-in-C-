using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Employee
    {
        public Employee() { }
        public Employee(int employeeId, string name, int basePay) { 
            this.EmployeeId = employeeId;
            this.Name = name;
            this.BasePay = basePay;
        }

        public int EmployeeId { get; init; } // By this we can initialize the variable at the time of creating the instace .
        public string Name { get; set; }
        public int BasePay{ get; set; }

        public void Display()
        {

            Console.WriteLine($"Employee Id {EmployeeId}, Name = {Name}, BasicPay = {BasePay}");
        }
    }
}
