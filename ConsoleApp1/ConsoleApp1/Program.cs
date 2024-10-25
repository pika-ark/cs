using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.
class Order
    {public string DishName { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerPortion { get; set; }
    public Order(string dishName, int quantity, decimal pricePerPortion)
    {DishName = dishName;
     Quantity = quantity;
     PricePerPortion = pricePerPortion;}
    public decimal CalculateTotalPrice()
  {return Quantity * PricePerPortion}
  public void DisplayOrderInfo()
  {Console.WriteLine($"Блюдо: {DishName}, Количество: {Quantity}, Цена за порцию: {PricePerPortion:C}, Общая стоимость: {CalculateTotalPrice():C}");}}
class Program
{static void Main(string[] args){
        Order order = new Order("Паста", 2, 250.00m);
        order.DisplayOrderInfo();}}
