using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ComicBookApp.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ComicBook
    {
        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public ComicBook Favorite { get; set; }
    }
}
