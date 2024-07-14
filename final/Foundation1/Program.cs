using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video = new Video
        {
            Title = "I ate 100000 chicken nuggets",
            Author = "xXgamermanXx",
            Length = 120,
        };
        video.AddComment("man that was probs too many ngl!");
        Console.WriteLine($"Video: {video.GetTitle()}, Author: {video.GetAuthor()}, Comments: {video.GetNumberOfComments()}");
    }
}