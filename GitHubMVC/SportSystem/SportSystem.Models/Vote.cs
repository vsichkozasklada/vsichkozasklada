﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SportSystem.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }

        public int Value { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
