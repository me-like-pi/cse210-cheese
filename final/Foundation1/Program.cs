using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>
        {
            new Video
            {
                Title = "I ate 100000 chicken nuggets",
                Author = "xXgamermanXx",
                Length = 120
            },
            new Video
            {
                Title = "Speedrunning Minecraft in 10 minutes",
                Author = "speedrunMaster",
                Length = 15
            },
            new Video
            {
                Title = "How to cook the perfect steak",
                Author = "Master Chef",
                Length = 45
            },
            new Video
            {
                Title = "Top 10 travel destinations for 2024",
                Author = "TravelDan",
                Length = 180
            }
        };

        videos[0].AddComment("John Halo", "man that was probs too many ngl!");
        videos[0].AddComment("Melikpi", "Epic video!");
        videos[0].AddComment("taulover", "I'm hungry now.");

        videos[1].AddComment("Dream", "Amazing run!");
        videos[1].AddComment("Pewdiepie", "How did you do that?");
        videos[1].AddComment("urmum6969696", "Incredible!");

        videos[2].AddComment("lookbehindyou", "That looks delicious!");
        videos[2].AddComment("master cheeks", "Great tips.");
        videos[2].AddComment("burgrlovr", "Can't wait to try this!");

        videos[3].AddComment("ihvaqustn", "I want to go to all these places!");
        videos[3].AddComment("tom", "Great suggestions.");
        videos[3].AddComment("jerry", "Thanks for the info!");

        foreach (var video in videos)
        {
            Console.WriteLine($"Video: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} minutes");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}