using System;
interface IPaymentMethod
{
    void Pay(decimal amount);
}
class CreditCard : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount:C} с помощью кредитной карты.");
    }
}
class PayPal : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount:C} через PayPal.");
    }
}
class BankTransfer : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount:C} через банковский перевод.");
    }
}
