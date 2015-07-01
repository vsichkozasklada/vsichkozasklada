using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSystem.Models
{
    public class Team
    {
        private ICollection<Player> players;
        private ICollection<Vote> votes;
        private ICollection<Match> matches;

        public Team()
        {
            this.players = new HashSet<Player>();
            this.votes = new HashSet<Vote>();
            this.matches = new HashSet<Match>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Team")]
        public string TeamName { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Nick Name")]
        public string TeamNickName { get; set; }

        public string Website { get; set; }

        // [Required]
        public DateTime DateFounded { get; set; }

        public virtual ICollection<Match> Matches 
        {
            get { return this.matches; }
            set { this.matches = value; }
        }

        public virtual ICollection<Player> Players 
        {
            get { return this.players; }
            set { this.players = value; }
        }

        public virtual ICollection<Vote> Votes
        {
            get { return this.votes; }
            set { this.votes = value; }
        }
    }
}
