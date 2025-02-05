using System;
using System.Collections.Generic;

public class Video
{
     public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

class Program
{
    static void Main(string[] args)
    {
    // Creating a list of videos
        List<Video> videos = new List<Video>();

     // Create video instances and adding comments
       
        Video video1 = new Video(" Basics for Beginners", "Bob Williams", 550);
        video1.AddComment(new Comment("Ronnie Mbayo", "This is exactly what I needed it's super nice thanks."));
        video1.AddComment(new Comment("Aminah Nakalyowa", "it's really awsome for the beginners."));
        video1.AddComment(new Comment("Ronald Kasango", "This is a good start for the beginners for sure, thanks."));
        videos.Add(video1);

        Video video2 = new Video("Understanding Polymorphism", "Alice Johnson", 360);
        video2.AddComment(new Comment("Francis Kato", "Very helpfull, thanks so much."));
        video2.AddComment(new Comment("Joan Kulabako", "I love watching this video it's super nice."));
        video2.AddComment(new Comment("Marvin Baliraine", " Super great explanation of polymorphism."));
        video2.AddComment(new Comment("Mariam Fatuma", " This is really understandable, thanks so much."));
        videos.Add(video2);

        Video video3 = new Video("Alice in wonderland", "Lorina Charlotte", 680);
        video3.AddComment(new Comment("Saleh Ntege", "I Love this video it's very educative."));
        video3.AddComment(new Comment("Violet Mariam", "Fantastic video and super cool with advanture."));
        video3.AddComment(new Comment("Willy Joseph", "This is super lovely to watch during free time."));
        video3.AddComment(new Comment("Nephi Sempala", "This mazing video it's super nice."));
        videos.Add(video3);

        // Iterating through the videos and displaying inf
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: \"{comment.Text}\"");
            }

            Console.WriteLine(); 
        }
    }
}