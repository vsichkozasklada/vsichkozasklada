using SportSystem.Common.Mappings;
using SportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SportSystem.Web.ViewModels

{
    public class TeamViewModel : IMapFrom<Team>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string TeamName { get; set; }


        public string Website { get; set; }

        public int Votes{ get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Team, TeamViewModel>()
                .ForMember(x => x.Votes, cnf => cnf.MapFrom(m => m.Votes.Any() ? m.Votes.Sum(v => v.Value) : default(int)));
        }
    }
}