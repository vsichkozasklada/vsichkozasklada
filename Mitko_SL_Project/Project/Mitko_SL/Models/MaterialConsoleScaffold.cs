using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Common.Enumerators;

namespace Project.Models
{
    public class MaterialConsoleScaffold
    {
        public int ID { get; set; }

        public eMaterialType MaterialType { get; set; }

        public string Weight { get; set; }
    }
}
