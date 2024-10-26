using System;
abstract class BankAccount
{
    public decimal Balance { get; protected set; }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Успешное пополнение! Новый баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Некорректная сумма пополнения.");
        }
    }
    public abstract void Withdraw(decimal amount);
}
class SavingsAccount : BankAccount
{
    private readonly decimal _minimumBalance = 100m;
    public override void Withdraw(decimal amount)
    {
        if (Balance - amount >= _minimumBalance)
        {
            Balance -= amount;
            Console.WriteLine($"Успешное снятие! Новый баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств для поддержания минимального остатка.");
        }
    }
}
class CheckingAccount : BankAccount
{
    private readonly decimal _serviceCharge = 1.5m;

    public override void Withdraw(decimal amount)
    {
        decimal totalAmount = amount + _serviceCharge;

        if (Balance >= totalAmount)
        {
            Balance -= totalAmount;
            Console.WriteLine($"Успешное снятие! Применена плата за обслуживание. Новый баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств для снятия.");
        }
    }
}
