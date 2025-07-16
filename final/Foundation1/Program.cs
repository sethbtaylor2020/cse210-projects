using System;
using System.Collections.Generic;
using System.Transactions;
class Program
{
    static void Main(string[] args)
    {//creating list of videos
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Waterfalls", "Bob Ross", 120);
            video1.AddComment(new UserComment("Dan", "This made my day."));
            video1.AddComment(new UserComment("Eve", "You should post more."));
        Video video2 = new Video("Happy little clouds", "Rick Ross", 100);
            video2.AddComment(new UserComment("Dan", "This made my day."));
            video2.AddComment(new UserComment("Eve", "You should post more."));
        Video video3 = new Video("WW2","History dude", 130);
            video3.AddComment(new UserComment("Dan", "This made my day."));
            video3.AddComment(new UserComment("Eve", "You should post more."));
//adding it into the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //holy crap i need to fix these names
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}