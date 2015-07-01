using SportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportSystem.Web.ViewModels
{
    public class BetViewModel
    {
        public int Id { get; set; }

        public decimal? BetHome { get; set; }

        public decimal? BetAway { get; set; }

        public string UserId { get; set; }

        public string User { get; set; }

        public int MatchId { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Bet, BetViewModel>()
                .ForMember(x => x.User, cnf => cnf.MapFrom(m => m.User.UserName));
        }
    }
}
