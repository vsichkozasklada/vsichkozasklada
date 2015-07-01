using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SportSystem.Models
{
    public class Bet
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Bet")]
        public decimal? BetHome { get; set; }

        [Display(Name = "Bet")]
        public decimal? BetAway { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int MatchId { get; set; }

        public virtual Match Match { get; set; }

    }
}
