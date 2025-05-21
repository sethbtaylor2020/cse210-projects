using System;
using System.IO;

public class JournalEntry
{
    public DateTime EntryDate { get; set; }
    public string JournalBody { get; set; }
    public JournalEntry(string body)
    {
        EntryDate = DateTime.Now;
        JournalBody = body;
    }

    public string FormattedEntry()
    {
        return $"Entry on {EntryDate:G} ===\n{JournalBody}\n\n";
    }
}

public class ReadJournal
{
    private string _filepath;

    public ReadJournal(string filepath)
    {
        _filepath = filepath;
    }

    public void DisplayEntries()
    {
        if (!File.Exists(_filepath))
        {
            Console.WriteLine("No entries found.");
            return;
        }

        string content = File.ReadAllText(_filepath);
        Console.WriteLine("\nAll Entries:");
        Console.WriteLine(content);
    }
}

class Program
{
    static void Main(string[] args)
    {
        JournalEntry currentEntry = null;
        string[] prompts = { "School", "Work", "Friends", "Family", "Church" };
        bool running = true;
        while (running)
        {
            Console.WriteLine("Type the number associated with the option:");
            Console.WriteLine("1. Make a Journal Entry");
            Console.WriteLine("2. Read Entries");
            Console.WriteLine("3. Save Entry");
            Console.WriteLine("4. Quit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Random rand = new Random();
                string prompt = prompts[rand.Next(prompts.Length)];

                Console.WriteLine("Prompt: " + prompt);
                Console.WriteLine("Write your journal entry below:");
                string body = Console.ReadLine();

                currentEntry = new JournalEntry(body);
                Console.WriteLine("Entry recorded. Choose option 3 to save.");
            }
            else if (input == "2")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                ReadJournal reader = new ReadJournal(filename);
                reader.DisplayEntries();
            }
            else if (input == "3")
            {
                if (currentEntry == null)
                {
                    Console.WriteLine("No entry to save. Please write one first.");
                }
                else
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    File.AppendAllText(filename, currentEntry.FormattedEntry());
                    Console.WriteLine("Entry saved to " + filename);
                }
            }
            else if (input == "4")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a number between 1 and 4.");
            }
        }
    }
}
