using System;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; private set; }
    public Book(string title, string author, bool isAvailable = true)
    {
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }
    public void ChangeStatus(bool status)
    {
        IsAvailable = status;
    }
    public void DisplayBookInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Доступна: {(IsAvailable ? "Да" : "Нет")}");
    }
}
