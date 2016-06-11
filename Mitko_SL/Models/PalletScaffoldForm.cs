using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class PalletScaffoldForm
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Дължина", GroupName = "Размери на товар")]
        public decimal LoadLength { get; set; }

        [Display(Name = "Широчина", GroupName = "Размери на товар")]
        public decimal LoadWidth { get; set; }

        [Display(Name = "Височина", GroupName = "Размери на товар")]
        public decimal LoadHeight { get; set; }

        [Display(Name = "Дължина", GroupName = "Размери на стелаж")]
        public decimal ShelfLength { get; set; }

        [Display(Name = "Дълбочина", GroupName = "Размери на стелаж")]
        public decimal ShelfDepth { get; set; }

        [Display(Name = "Височина", GroupName = "Размери на стелаж")]
        public decimal ShelfHeight { get; set; }

        [Display(Name = "Брой нива с включен под", GroupName = "Размери на стелаж")]
        public int ShelfNumber { get; set; }

        [Display(Name = "Натоварване на двойна греда", GroupName = "Размери на стелаж")]
        public decimal BeamWeightCapacity { get; set; }

        [Display(Name = "Натоварване на m2", GroupName = "Размери на стелаж")]
        public decimal MeterSquareWeightCapacity { get; set; }

        [Display(Name = "Размери")]
        public bool IsDimensionsKnown { get; set; }

        public ICollection<Project.Common.Enumerators.еProduct> Products { get; set; }

        public int BusinessPartnerID { get; set; }

        public virtual BusinessPartner BusinessPartner { get; set; }
    }
}
