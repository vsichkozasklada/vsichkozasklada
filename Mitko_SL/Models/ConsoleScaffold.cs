using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Web.Validators;

namespace Project.Models
{
    public class ConsoleScaffold
    {
        [Key]
        public int ID { get; set; }

        [CustomIntValidationAttribute]
        [Display(Name = "Дължина", GroupName = "Размери на товар")]      
        public int? LoadLength { get; set; }

        [CustomIntValidationAttribute]
        [Display(Name = "Широчина", GroupName = "Размери на товар")]
        public int? LoadWidth { get; set; }

        [CustomIntValidationAttribute]
        [Display(Name = "Височина", GroupName = "Размери на товар")]
        public int? LoadHeight { get; set; }

        [CustomIntValidationAttribute]
        [Display(Name = "Дължина", GroupName = "Размери на стелаж")]
        public int? MaterialLength { get; set; }

        [CustomIntValidationAttribute]
        [Display(Name = "Дълбочина", GroupName = "Размери на стелаж")]
        public int? MaterialDepth { get; set; }

        [CustomIntValidationAttribute]
        [Display(Name = "Височина", GroupName = "Размери на стелаж")]
        public int? MaterialHeight { get; set; }

        [Display(Name = "Едностранна колона")]
        public bool OneSideColumn { get; set; }

        [Display(Name = "Двустранна колона")]
        public bool TwoSideColumn { get; set; }

        [CustomIntValidationAttribute]
        [Display(Name = "Брой нива", GroupName = "Размери на стелаж")]
        public int? ShelfNumber { get; set; }
        
        [Display(Name = "Размери")]
        public bool IsDimensionsKnown { get; set; }

        public DateTime DateSubmitted { get; set; }

        public ICollection<Project.Common.Enumerators.еProduct> Products { get; set; }

        public int MaterialConsoleScaffoldID { get; set; }

        public virtual ICollection<MaterialConsoleScaffold> MaterialConsoleScaffold { get; set; }

        public int BusinessPartnerID { get; set; }

        public virtual BusinessPartner BusinessPartner { get; set; }
    }
}
