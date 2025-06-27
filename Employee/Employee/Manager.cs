using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Manager : Employee
    {
        public int StockOptions { get; set; }

        //public Manager(string fullName, int age, int empId, float currPay, string ssn, int numbOfOpts)
        //{
        //    StockOptions = numbOfOpts;
        //    Name = fullName;
        //    Age = age;
        //    EmpId = empId;
        //    CurrPay = currPay;
        //    SocialSecurityNumber = ssn; // As the social security number is already write as private which mean value can be set by class itself
        //} // We can follow another approach to do this 
        public Manager() { }
        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numbOfOpts) : base(fullName, age, empId, currPay, ssn, PayType.Salaried)
        {
            StockOptions = numbOfOpts;
        }
    }
}
