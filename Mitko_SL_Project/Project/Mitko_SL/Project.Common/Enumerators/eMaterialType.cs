using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Enumerators
{
    public enum eMaterialType
    {
        [Display(Name = "Профил")]
        profile     = 1,

        [Display(Name = "Тръбен")]
        tube        = 2,

        [Display(Name = "Лист")]
        sheet       = 3,

        [Display(Name = "Контейнер")]
        container   = 4
    }
}
