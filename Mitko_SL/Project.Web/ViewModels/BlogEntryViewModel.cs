using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web
{
    public class BlogEntryViewModel
    {
        public string ID { get; set; }

        public string Title { get; set; }

        public string TextContent { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public string ImageTitle { get; set; }

        public string ImagePath { get; set; }

        public string ImageAltText { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}