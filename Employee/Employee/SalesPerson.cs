using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class SalesPerson : Employee 
    {
        public int SalesNumber { get; set; }
        public SalesPerson(string Name, int Age, int empId, double CurrPay, string SSN, int numOfOpts) :base(Name, Age, empId, CurrPay, SSN, PayType.Comission){
            SalesNumber = numOfOpts;
        }
        public void DisplayContant()
        {
            Console.WriteLine("{0}, your employee_id is {1} and your current pay is {2}", _name, _empId, _currPay);

        }
    }
}
