using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSystem.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Height { get; set; }


        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
