using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Web.InputModels
{
    public class BlogEntryInputModel
    {        
        [Required]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string TextContent { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public string ImageTitle { get; set; }

        public DateTime PublishDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        public HttpPostedFileBase ImageUpload { get; set; }
    }
}