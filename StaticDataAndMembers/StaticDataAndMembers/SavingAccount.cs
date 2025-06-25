using static System.Net.Mime.MediaTypeNames;

namespace StaticDataAndMembers;

class SavingAccount
{
    public double balance;
    private static double _currentInterestRate = 0.04;

    public SavingAccount(double balance)
    {
        //currentInterestRate = 0.023; // This will lead to reset the value of static member which looses purpose so its a bad practice
        this.balance = balance;
    }
    static SavingAccount()
    {
        _currentInterestRate = 0.04;
        // as the CoreCLR calls all static constructors before the first use (and never calls them again for 
        //that instance of the application).
    }

    public static double InterestRate
    {
        get => _currentInterestRate;
        set => _currentInterestRate = value;
    }
    //public static double GetInterestRate() => currentInterestRate;
    //public static void SetInterestRate(double currentInterestRate) => SavingAccount.currentInterestRate = currentInterestRate; // We are not allowed to use the this keyword in static member

}