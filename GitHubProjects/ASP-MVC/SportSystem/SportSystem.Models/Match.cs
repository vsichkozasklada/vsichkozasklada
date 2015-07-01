﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSystem.Models
{
    public class Match
    {
        private ICollection<Comment> comments;
        private ICollection<Bet> bets;

        public Match()
        {
            this.comments = new HashSet<Comment>();
            this.bets = new HashSet<Bet>();

        }

        [Key]
        public int Id { get; set; }

        public DateTime DateTimeMatch { get; set; }

        [Required]
        public int HomeTeamId { get; set; }

        public virtual Team HomeTeam { get; set; }

        [Required]
        public int AwayTeamId { get; set; }

        public virtual Team AwayTeam { get; set; }

        public virtual ICollection<Comment> Comments 
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public virtual ICollection<Bet> Bets
        {
            get { return this.bets; }
            set { this.bets = value; }
        }
    }
}
