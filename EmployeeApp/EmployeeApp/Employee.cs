using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        private string _name;
        private int _empId;
        private double _currPay;

        public Employee() { }
        public Employee(string name, int id, double pay)
        {
            _name = name;
            _empId = id;
            _currPay = pay;
        }

        public string GetName() => _name;
        public void SetName(string newName)
        {
            if (newName.Length < 5) Console.WriteLine("New name must have the length at least 6 char");
            else _name = newName;
        }

        public int EmpId
        {
            get { return _empId; }
            set
            {
                if (value < 10) Console.WriteLine("Employee id must be correct");
                else _empId = value;
            }
        }

        public double CurrPay
        {
            get => _currPay;
            set
            {
                if (value < 100000) Console.WriteLine("Upskill yourself and do not worry about result");
                else _currPay = value; // This value contain the same value written after assingment operator at caller
            }
        }

        public void GiveBonus(double bonus) => _currPay += bonus;
        public void DisplayContant()
        {
            Console.WriteLine("{0}, your employee_id is {1} and your current pay is {2}", _name, _empId, _currPay);

        }
    }
}
