using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Gallery
    {
        private ICollection<Image> _images;

        public Gallery()
        {
            this._images = new HashSet<Image>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public ICollection<Image> Images 
        {
            get { return this._images; }
            set { this._images = value; }
        }
    }
}
