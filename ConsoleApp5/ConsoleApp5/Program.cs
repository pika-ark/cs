using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите задачу:");
            Console.WriteLine("1 - Планировщик бюджета");
            Console.WriteLine("2 - Индикатор здоровья");
            Console.WriteLine("3 - Управление задачами");
            Console.WriteLine("4 - Выйти");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BudgetPlanner();
                    break;
                case 2:
                    HealthIndicator();
                    break;
                case 3:
                    TaskManager();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                    break;
            }
        }
    }
    static void BudgetPlanner()
    {
        Console.WriteLine("Введите расходы на аренду:");
        double rent = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите расходы на еду:");
        double food = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите расходы на транспорт:");
        double transport = double.Parse(Console.ReadLine());
        double totalExpenses = rent + food + transport;
        Console.WriteLine("Общая сумма расходов: " + totalExpenses);
        Console.WriteLine("Введите ваш доход:");
        double income = double.Parse(Console.ReadLine());
        double remaining = income - totalExpenses;
        Console.WriteLine("Оставшиеся средства: " + remaining);
    }
    static void HealthIndicator()
    {
        Console.WriteLine("Введите ваш вес (кг):");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите ваш рост (м):");
        double height = double.Parse(Console.ReadLine());
        double bmi = weight / (height * height);
        Console.WriteLine("Ваш ИМТ: " + bmi);
        if (bmi < 18.5)
            Console.WriteLine("Рекомендация: Наберите вес.");
        else if (bmi >= 18.5 && bmi <= 24.9)
            Console.WriteLine("Рекомендация: У вас нормальный вес.");
        else
            Console.WriteLine("Рекомендация: Снизьте вес.");
    }
    static void TaskManager()
    {
        List<Task> tasks = new List<Task>();
        while (true)
        {
            Console.WriteLine("1 - Добавить задачу");
            Console.WriteLine("2 - Удалить задачу");
            Console.WriteLine("3 - Изменить статус задачи");
            Console.WriteLine("4 - Показать все задачи");
            Console.WriteLine("5 - Назад");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Введите описание задачи: ");
                    string description = Console.ReadLine();
                    Console.Write("Введите срок задачи: ");
                    string dueDate = Console.ReadLine();
                    tasks.Add(new Task(description, dueDate));
                    break;
                case 2:
                    Console.Write("Введите номер задачи для удаления: ");
                    int removeIndex = int.Parse(Console.ReadLine()) - 1;
                    if (removeIndex >= 0 && removeIndex < tasks.Count)
                    {
                        tasks.RemoveAt(removeIndex);
                        Console.WriteLine("Задача удалена.");
                    }
                    else
                    {
                        Console.WriteLine("Неверный номер задачи.");
                    }
                    break;
                case 3:
                    Console.Write("Введите номер задачи для изменения статуса: ");
                    int statusIndex = int.Parse(Console.ReadLine()) - 1;
                    if (statusIndex >= 0 && statusIndex < tasks.Count)
                    {
                        tasks[statusIndex].ToggleStatus();
                    }
                    else
                    {
                        Console.WriteLine("Неверный номер задачи.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Список задач:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                    break;
            }
        }
    }
    class Task
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public Task(string description, string dueDate)
        {
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }
        public void ToggleStatus()
        {
            IsCompleted = !IsCompleted;
            Console.WriteLine("Статус изменен: " + (IsCompleted ? "Выполнена" : "Не выполнена"));
        }
        public override string ToString()
        {
            return $"Описание: {Description}, Срок: {DueDate}, Статус: {(IsCompleted ? "Выполнена" : "Не выполнена")}";
        }
    }
}
