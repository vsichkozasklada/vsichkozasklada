using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ContactQuery
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage="Полето е задължително")]
        [MaxLength(75, ErrorMessage = "Максимум 75 символа")]
        public string Name { get; set; }
                
        [Required(ErrorMessage = "Полето е задължително")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Въведете валиден имейл")]
        public string Email { get; set; }
               
        [Required(ErrorMessage = "Полето е задължително")]
        [MaxLength(500, ErrorMessage = "Максимум 500 символа")]
        [MinLength(10, ErrorMessage = "Въведете минимум 10 символа")]
        [DataType(DataType.MultilineText)]
        public string MessageText { get; set; }

        public DateTime DateSubmitted { get; set; }
    }
}
