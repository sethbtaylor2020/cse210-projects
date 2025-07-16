using System;

class Video
{
    public string Title { get; set; }
    public string Creator { get; set; }
    public int Length { get; set; }
    public List<UserComment> Comments { get; set; } = new List<UserComment>();

    public Video(string title, string creator, int length)
    {
        Title = title;
        Creator = creator;
        Length = length;
    }
    public void AddComment(UserComment comment)
    {
        Comments.Add(comment);
    }
    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Creator: {Creator}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comment Section: {Comments.Count}");

        foreach (var comment in Comments)
        {
            Console.WriteLine($"  - {comment.Username}: {comment.Comment}");
        }

        Console.WriteLine();
    }
}

//Comment Class

class UserComment
{
    public string Username { get; set; }
    public string Comment { get; set; }

    public UserComment(string username, string comment)
    {
        Username = username;
        Comment = comment;
    }
}