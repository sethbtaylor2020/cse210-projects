using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class Activity
{
    public string StartMessage;
    public string EndMessage;
    public string AnimationText;

    public Activity(string startMessage, string endMessage, string animationText)
    {
        StartMessage = startMessage;
        EndMessage = endMessage;
        AnimationText = animationText;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"This is the:");
    }

    public void DisplayEndMessage()
    {
        Thread.Sleep(500);
        Console.WriteLine($"Good Job! You just completed the:");
    }

    public void Animation()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}
//BREATHING ACTIVITY-----------------------------------------------------------------------------------------------------------------
public class Breathing : Activity
{
    public string BreathingMessage;

    public Breathing(string breathingMessage)
        : base("Breathing Start", "Breathing End", "Breathing Anim")
    {
        BreathingMessage = breathingMessage;
    }

    public void DisplayBreathingMessage()
    {
        DisplayStartMessage();
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking through some breathing techniques");
    }
    public void BreathingAnimation()
    {
        Console.Write("How long do you want breathing intervals to last?");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int loopCount))
        {
            Console.WriteLine("Breathe in...");
            for (int i = 0; i < loopCount; i++)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        {
            Console.WriteLine("Breathe out...");
            for (int i = 0; i < loopCount; i++)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        {
            Console.WriteLine("Breathe in...");
            for (int i = 0; i < loopCount; i++)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        {
            Console.WriteLine("Breathe out...");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    public new void DisplayEndMessage()
    {
        base.DisplayEndMessage();
        Console.WriteLine("Breathing Activity");
    }
}
public class RunBreathingActivity
{
    public void Execute()
    {
        Breathing breathActivity = new Breathing("Breathing Activity");
        breathActivity.DisplayBreathingMessage();
        breathActivity.BreathingAnimation();
        breathActivity.DisplayEndMessage();
    }
}
//BREATHING ACTIVITY-----------------------------------------------------------------------------------------------------------------

//------------------------Reflecting Activity-----------------------------------------------------------------------------------------
public class Reflecting : Activity
{
    public string ReflectingMessage;

    public Reflecting(string reflectingMessage)
        : base("Reflecting Start", "Reflecting End", "Reflecting Anim")
    {
        ReflectingMessage = reflectingMessage;
    }

    public void DisplayReflectingMessage()
    {
        DisplayStartMessage();
        Console.WriteLine("Reflecting Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength. You will reflect on those times to capture the essense of what makes you a stronger person.");
    }
    public void ReflectingAnimation()
    {
        Console.Write("How long would you like each question of the reflecting activity to last? ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int loopCount))
        {
            Console.WriteLine("Think of a time where you were struggling. How did you overcome it?");
            for (int i = 0; i < loopCount; i++)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine("Think of a time where you felt uncertain or afraid. What gave you the courage to move forward?");
        for (int i = 0; i < loopCount; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
            Console.WriteLine("Recall a moment when you failed at something important. What did you learn from that experience");
            for (int i = 0; i < loopCount; i++)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    
    public new void DisplayEndMessage()
    {
        for (int i = 0; i < 5; i++)
         {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }

        base.DisplayEndMessage();
        Console.WriteLine("Reflecting Activity");
    }
}
public class RunReflectingActivity
{
    public void Execute()
    {
        Reflecting reflectActivity = new Reflecting("Reflecting Activity");
        reflectActivity.DisplayReflectingMessage();
        reflectActivity.ReflectingAnimation();
        reflectActivity.DisplayEndMessage();
    }
}
//--------------------------------------------------Listening Activity------------------------------------------------
public class Listening : Activity
{
    public string ListeningMessage;

    public Listening(string listeningMessage)
        : base("Reflecting Start", "Reflecting End", "Reflecting Anim")
    {
        ListeningMessage = listeningMessage;
    }

    public void DisplayListeningMessage()
    {
        DisplayStartMessage();
        Console.WriteLine("Listening Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }
    public void ReflectingAnimation()
    {
        {
            Console.WriteLine("What are personal strengths of yours?");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine("Who are people that you have helped this week?");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
            Console.WriteLine("When have you felt the Holy Ghost this month?");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }

    public new void DisplayEndMessage()
    {
        for (int i = 0; i < 5; i++)
         {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }

        base.DisplayEndMessage();
        Console.WriteLine("Listening Activity");
    }
}
public class RunListeningActivity
{
    public void Execute()
    {
        Listening listeningActivity = new Listening("Listening Activity");
        listeningActivity.DisplayListeningMessage();
        listeningActivity.ReflectingAnimation();
        listeningActivity.DisplayEndMessage();
    }
}

