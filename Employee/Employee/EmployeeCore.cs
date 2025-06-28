using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    partial class Employee
    {
        internal class BenefitPackage
        {
            public enum BenefitsPackageLevels
            {
                Standard, Gold, Platinum
            }
            public double ComputePayDeduction()
            {
                return 125D;
            }
        }
        protected string _name;
        protected int _empId;
        protected double _currPay;
        protected int _empAge;
        protected string _SSN;
        protected PayType _payType;
        protected DateTime _hireDate;
        protected BenefitPackage EmpBenefits = new BenefitPackage();

        public BenefitPackage Benefits
        {
            get => EmpBenefits;
            set => EmpBenefits = value;
        }   
        public Employee() { }
        public Employee(string name, int id, double pay, string SSN) : this(name, 0, id, pay, SSN, PayType.Salaried) { }
        public Employee(string name, int age, int id, double pay, string SSN, PayType payType)
        {
            //_name = name; // Instead of this we can use the properties
            //_empId = id;
            //_currPay = pay;
            Name = name;
            EmpId = id;
            CurrPay = pay;
            //SocialSecurityNumber = SSN; // This is not possible as the property is for read-only
            EmployeePayType = payType;

        }

        public DateTime HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }

        public PayType EmployeePayType
        {
            get => _payType;
            set => _payType = value;
        }
        public string SocialSecurityNumber
        {
            get => _SSN; // If we omit the set keyword then this property will make the variable read-only property vice versa
            set => _SSN = value; // Now this value can only changed by the class inside itself
        }
        // Those property which are only read-only we can create them like this 
        //public string SocialSecurityNumber => _SSN;
        public int Age
        {
            get => _empAge;
            set => _empAge = value;
        }
        //public string GetName() => _name;
        //public void SetName(string newName)
        //{
        //    if (newName.Length < 5) Console.WriteLine("New name must have the length at least 6 char");
        //    else _name = newName;
        //}

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 5) Console.WriteLine("Name should not be less then 5 char");
                else _name = value;
            }
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

    }
}
