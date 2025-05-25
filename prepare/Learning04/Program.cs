using System;
using System.Collections.Generic;

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
    List<Word> words;
    Random random;

    public Scripture(string text, Reference refObj)
    {
        reference = refObj;
        words = new List<Word>();
        random = new Random();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            words.Add(new Word(part));
        }
    }

   public void HideRandomWord()
{
    List<Word> visible = new List<Word>();
    foreach (Word word in words)
    {
        if (!word.isHidden);
        {
            visible.Add(word);
        }
    }

    if (visible.Count > 0)
    {
        int index = random.Next(visible.Count);
        visible[index].Hide();
    }
}


    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.isHidden)
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string output = reference.GetDisplayText() + " - ";

        foreach (Word word in words)
        {
            output += word.Display() + " ";
        }

        return output.Trim();
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
            Console.WriteLine("Press Enter to hide a word.");
            Console.ReadLine();
            scripture.HideRandomWord();
            Console.WriteLine();
        }
    }
}
