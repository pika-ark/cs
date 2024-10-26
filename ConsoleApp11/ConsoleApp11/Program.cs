using System;
class Car
{
    public string Brand { get; set; }
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
        Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Год: {Year}, Ставка за день: {DailyRate:C}");
    }
}
