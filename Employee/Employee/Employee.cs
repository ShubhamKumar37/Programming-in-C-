using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    abstract partial class Employee
    {

        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        public void GiveBonus(double amount)
        {
            //{ HireDate: { Year: > 2020 }, Age: >= 18, EmployeePayType: PayType.Hourly } => CurrPay += amount * .10F,
            //{ Age: >= 18, EmployeePayType: PayType.Salaried } => CurrPay += amount * 0.4F,
            //{ Age: >= 19, EmployeePayType: PayType.Comission } => CurrPay += amount * 1.1F,
            CurrPay = this switch
            {
                { EmployeePayType: PayType.Salaried } => CurrPay += amount * 0.1F,
                { EmployeePayType: PayType.Hourly } => CurrPay += amount * 0.3F,
                { EmployeePayType: PayType.Comission } => CurrPay += amount * 0.8F,
                { } => CurrPay += 0,

            }; // In switch case we need to make this syntax <variable : <comperassion operator> <value>> Need to observe the colon a lot
        }
        public void DisplayContant()
        {
            Console.WriteLine("{0}, your employee_id is {1} and your current pay is {2}", _name, _empId, _currPay);

        }

        public virtual void GiveBonus(float amount)
        {
            CurrPay += amount;
        }
    }

    class Car
    {
        private string _carName = "";

        public string CarName
        {
            get => _carName;
            set => _carName = value;
        }
    }
}
