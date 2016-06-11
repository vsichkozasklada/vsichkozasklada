using Project.Common.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Image
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string AltText { get; set; }

        public string ImageFilePath { get; set; }

        public ImageType Type { get; set; }

        public string Category { get; set; }

        public DateTime DateUploaded { get; set; }

        public int? BlogEntryID { get; set; }

        public BlogEntry BlogEntry { get; set; }

        public int? GellryID { get; set; }

        public virtual Gallery Gallery { get; set; }
    }
}
