using System;
class Order
{
    public string DishName { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerPortion { get; set; }
    public Order(string dishName, int quantity, decimal pricePerPortion)
    {
        DishName = dishName;
        Quantity = quantity;
        PricePerPortion = pricePerPortion;
    }
    public decimal CalculateTotal()
    {
        return Quantity * PricePerPortion;
    }
    public void DisplayOrderInfo()
    {
        Console.WriteLine($"Блюдо: {DishName}, Количество порций: {Quantity}, Цена за порцию: {PricePerPortion:C}, Общая стоимость: {CalculateTotal():C}");
    }
}
