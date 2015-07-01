using SportSystem.Common.Mappings;
using SportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportSystem.Web.ViewModels
{
    public class MatchDetailsViewModel : IMapFrom<Match>
    {
        public int Id { get; set; }

        public DateTime DateTimeMatch { get; set; }

        public string HomeTeamTeamName { get; set; }

        public string AwayTeamTeamName { get; set; }
        
        public IEnumerable<CommentViewModel> Comments {get; set;}
    }
}