using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Common.Enumerators
{
    public enum еProduct
    {
        [Display(Name = "Опаковка")]
        package             = 1,

        [Display(Name = "Кутия/Кашон")]
        box                 = 2,

        [Display(Name = "Контейнер")]
        container           = 3,

        [Display(Name = "Пале")]
        pallet              = 4,

        [Display(Name = "Единичен Товар")]
        singleLoad          = 5,

        [Display(Name = "Различни")]
        various             = 6
    }
}
