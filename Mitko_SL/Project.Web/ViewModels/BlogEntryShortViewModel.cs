﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web
{
    public class BlogEntryShortViewModel
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string TextContent { get; set; }

        public string Category { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}