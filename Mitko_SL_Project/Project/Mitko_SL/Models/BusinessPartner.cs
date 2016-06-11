using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class BusinessPartner
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150)]
        [Required(ErrorMessage = "Полето е задължително")]    
        [Display(Name="Име")]
        public string Name { get; set; }

        [MaxLength(250)]
        [Display(Name="Адрес")]
        public string Address { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Полето е задължително")]
        [EmailAddress(ErrorMessage="Въведете валиден имейл")]        
        [Display(Name="Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [Display(Name="Телефон")]
        public string Phone { get; set; }

        [Display(Name="Фирма")]
        public string Company { get; set; }
    }
}
