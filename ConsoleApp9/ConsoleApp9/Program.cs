using System;
using System.IO;
class EventLogger
{
    private const string LogFile = "log.txt";
    public void LogEvent(string eventDescription)
    {
        File.AppendAllText(LogFile, $"{DateTime.Now}: {eventDescription}\n");
    }
    public void DisplayLog()
    {
        if (File.Exists(LogFile))
        {
            string[] logs = File.ReadAllLines(LogFile);
            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
        }
        else
        {
            Console.WriteLine("Журнал событий пуст.");
        }
    }
}
