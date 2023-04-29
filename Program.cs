using MySuperBank;

internal class Program
{
    private static void Main(string[] args)
    {
        var account = new BankAccount("Bob", 10000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

        account.MakeWithdrawal(120, DateTime.Now, "Rent Money.");
        Console.WriteLine($"Your account balance is now {account.Balance}");
    }
}