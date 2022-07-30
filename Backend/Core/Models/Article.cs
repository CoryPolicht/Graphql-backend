using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Article
    {
        public Article(int id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
