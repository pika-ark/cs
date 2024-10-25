using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Car
{   public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal DailyRate { get; set; }
    public Car(string brand, string model, int year, decimal dailyRate)
    {
 Brand = brand;
Model = model;
 Year = year;
 DailyRate = dailyRate;
    }
    public decimal CalculateRentalCost(int days)
    {
        return days * DailyRate;
    }
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Год: {Year}, Цена за день: {DailyRate:C}");
    }
}
class Program
{ static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Camry", 2020, 1000.00m);
        car.DisplayCarInfo();
        Console.WriteLine($"Стоимость аренды на 5 дней: {car.CalculateRentalCost(5):C}");
    }}
