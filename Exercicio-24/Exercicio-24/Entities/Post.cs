﻿using Exercicio_24.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_24
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }
        public Post(DateTime date, string title, string content, int likes)
        {
            Moment = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes + " Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
