using System;

namespace StaticDataAndMembers;

class Program
{
    public static void Main(string[] args)
    {
        SavingAccount s1 = new SavingAccount(1000);
        SavingAccount s2 = new SavingAccount(3000); 

        Console.WriteLine("This is the current interest rate = {0} ", SavingAccount.InterestRate);
        SavingAccount.InterestRate = 32.31;
        Console.WriteLine("This is the current interest rate = {0} ", SavingAccount.InterestRate);
        SavingAccount s3 = new SavingAccount(3432.3232);
        Console.WriteLine("This is the current interest rate = {0} ", SavingAccount.InterestRate);
        TimeUtilClass.PrintTime();
        TimeUtilClass.PrintDate();

        //TimeUtilClass t = new TimeUtilClass(); // This will cause error because static class can not create a instance

    }
}