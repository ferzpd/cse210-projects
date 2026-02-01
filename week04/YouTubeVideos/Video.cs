using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;
        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }
        public int GetNumberOfComments()
        {
            return _comments.Count;
        }
        public void DisplayVideoInfo()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds ({GetLengthInMinutes()} minutes)");
            Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
            Console.WriteLine("\nComments:");
            Console.WriteLine("---------");
            foreach (Comment comment in _comments)
            {
                Console.WriteLine($"- {comment.GetDisplayText()}");
            }
        }       
         private string GetLengthInMinutes()
        {
            int minutes = _length / 60;
            int seconds = _length % 60;
            return $"{minutes}:{seconds:D2}";
        }
    }
}