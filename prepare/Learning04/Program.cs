using System;

<<<<<<< HEAD
=======
class Reference  //updated constructor for the reference class I think this what you were talking about. if not let me know please
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1; 
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
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

>>>>>>> 255aa32a693911316c9f399def4d0ba5bf458c0c
class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jack Black","History");
        Console.WriteLine(a1.GetTopic());

        Mathassignment a2 = new Mathassignment("Barry Benson","Multiplication","11-13");
        Console.WriteLine(a2.GetTopic());
        Console.WriteLine(a2.GetProblems());

        Writing a3 = new Writing("Mike Smith","History","ww2");
        Console.WriteLine(a3.GetTopic());
        Console.WriteLine(a3.GetWritingAssignment());
    }
}