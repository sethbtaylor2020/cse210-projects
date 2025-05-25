using System;

class Reference
{
    string book;
    int chapter;
    int verse;

    public Reference(string theBook, int theChapter, int theVerse)
    {
        book = theBook;
        chapter = theChapter;
        verse = theVerse;
    }

    public string GetDisplayText()
    {
        return book + " " + chapter + ":" + verse;
    }
}

class Word
{
    public string text;
    public bool isHidden;

    public Word(string theText)
    {
        text = theText;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public string Display()
    {
        if (isHidden)
        {
            return "_____";
        }
        else
        {
            return text;
        }
    }
}

class Scripture
{
    Reference reference;
    Word[] words;
    int nextToHide = 0;

    public Scripture(string text, Reference refObj)
    {
        reference = refObj;
        string[] parts = text.Split(' ');
        words = new Word[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            words[i] = new Word(parts[i]);
        }
    }

    public void HideNextWord()
    {
        
        if (nextToHide < words.Length); 
        {
            words[nextToHide].Hide();  
            nextToHide++;
        }
    }

    public bool AllWordsHidden()
    {
        return nextToHide >= words.Length;
    }

    public string GetDisplayText()
    {
        string output = reference.GetDisplayText() + " - ";

        for (int i = 0; i < words.Length; i++)
        {
            output += words[i].Display() + " ";
        }

        return output;
    }
}

class Program
{
    static void Main()
    {
        Reference reference = new Reference("Nephi", 10, 20);
        string verse = "Therefore remember, O man, for all thy doings thou shalt be brought into judgment.";
        Scripture scripture = new Scripture(verse, reference);

        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide the next word.");
            Console.ReadLine();
            scripture.HideNextWord();
            Console.WriteLine();
        }

    }
}
