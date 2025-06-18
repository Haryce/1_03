class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
    }

    static void Main()
    {
        BankAccount account = new BankAccount
        {
            AccountNumber = "123456789",
            Balance = 1000
        };
        account.Deposit(500);
        account.Withdraw(300);
        System.Console.WriteLine($"Итоговый баланс: {account.Balance}");
    }
}