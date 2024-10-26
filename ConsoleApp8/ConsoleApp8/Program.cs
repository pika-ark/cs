using System;
class OrderProcessor
{
    public void ProcessOrder()
    {
        try
        {
            Console.Write("Введите количество: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Введите цену за единицу товара: ");
            decimal price = decimal.Parse(Console.ReadLine());

            if (quantity < 0 || price < 0)
                throw new ArgumentException("Количество и цена должны быть неотрицательными.");
            decimal total = quantity * price;
            Console.WriteLine($"Общая стоимость заказа: {total:C}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод. Введите числовые значения.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
