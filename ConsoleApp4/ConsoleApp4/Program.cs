using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; private set; }
    public Employee(string name, string position, decimal salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }
    public void IncreaseSalary(decimal amount)
    {
        Salary += amount;
    }
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Имя: {Name}, Должность: {Position}, Зарплата: {Salary:C}");
    }}
class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Иван Иванов", "Разработчик", 50000.00m);
        employee.DisplayEmployeeInfo();
        employee.IncreaseSalary(5000.00m);
        employee.DisplayEmployeeInfo();
    }}
