using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; private set; }
    public Book(string title, string author, bool isAvailable)
    {
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }
    public void ChangeAvailability()
    {
        IsAvailable = !IsAvailable;
    }
    public void DisplayBookInfo()
    {
        string availability = IsAvailable ? "Доступна" : "Выдана";
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Статус: {availability}");
    }}
class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Гарри Поттер", "Дж. К. Роулинг", true);
        book.DisplayBookInfo();
        book.ChangeAvailability();
        book.DisplayBookInfo();
    }}
