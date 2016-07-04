using Project.Common.Enumerators;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.ViewModels
{
    public class ImageViewModel 
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string AltText { get; set; }

        public string ImageFilePath { get; set; }

        public ImageType Type { get; set; }

        public string Category { get; set; }
    }
}