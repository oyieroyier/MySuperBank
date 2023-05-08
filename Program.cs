using MySuperBank;

internal class Program
{
    private static void Main(string[] args)
    {
        var account = new BankAccount("Bob", 10000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

        account.MakeWithdrawal(12, DateTime.Now, "Coffee.");
        account.MakeWithdrawal(10, DateTime.Now, "Snacks.");
        account.MakeWithdrawal(20, DateTime.Now, "Groceries.");
        account.MakeWithdrawal(120, DateTime.Now, "Rent Money.");
        account.MakeWithdrawal(12, DateTime.Now, "Cab.");
        account.MakeWithdrawal(10, DateTime.Now, "Electrician Cost.");
        account.MakeWithdrawal(20, DateTime.Now, "Water Bill.");
        Console.WriteLine($"Your account balance is now {account.Balance}\n");

        account.MakeDeposit(10000, DateTime.Now, "Money from Salary");

        Console.WriteLine(account.GetAccountHistory());
    }
}