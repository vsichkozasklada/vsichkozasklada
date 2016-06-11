using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class BlogEntry
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string TextContent { get; set; }

        public string Category { get; set; }
        
        public string Author { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
