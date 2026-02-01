using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== YouTube Video Tracking System ===\n");
            List<Video> videos = new List<Video>();
            Video video1 = new Video("C# Tutorial for Beginners", "Programming Academy", 600);
            video1.AddComment(new Comment("Alice", "Great tutorial! Very helpful for beginners."));
            video1.AddComment(new Comment("Bob", "I learned a lot, thank you!"));
            video1.AddComment(new Comment("Charlie", "Could you make a video about inheritance?"));
            video1.AddComment(new Comment("Diana", "Clear explanations, well done!"));
            videos.Add(video1);
            Video video2 = new Video("ASP.NET Core MVC Crash Course", "WebDev Master", 1200);
            video2.AddComment(new Comment("Ethan", "Perfect timing! Starting a new project."));
            video2.AddComment(new Comment("Fiona", "The database section was especially helpful."));
            video2.AddComment(new Comment("George", "Would love to see more advanced topics."));
            videos.Add(video2);
            Video video3 = new Video("Entity Framework Explained", "Data Guru", 900);
            video3.AddComment(new Comment("Hannah", "Finally understand migrations!"));
            video3.AddComment(new Comment("Ian", "Great examples, very practical."));
            video3.AddComment(new Comment("Julia", "Can you cover performance optimization?"));
            video3.AddComment(new Comment("Kevin", "Best EF tutorial I've seen!"));
            videos.Add(video3);
            
            
            Video video4 = new Video("Blazor WebAssembly Basics", "Frontend Pro", 750);
            video4.AddComment(new Comment("Liam", "Excited to try Blazor!"));
            video4.AddComment(new Comment("Mia", "Nice comparison with other frameworks."));
            video4.AddComment(new Comment("Noah", "Looking forward to the advanced course."));
            videos.Add(video4);
            
         
            foreach (Video video in videos)
            {
                Console.WriteLine("========================================");
                video.DisplayVideoInfo();
                Console.WriteLine();
            }
            
            Console.WriteLine("========================================");
            Console.WriteLine($"Total Videos Tracked: {videos.Count}");
        }
    }
}