using SportSystem.Common;
using SportSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using SportSystem.Web.ViewModels;

namespace SportSystem.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ISportSystemData data)
            : base(data)
        {

        }

        public ActionResult Index()
        {
            var teams = Data.Teams.All()
                .OrderByDescending(m => m.Votes.Sum(v => v.Value))
                .Take(GlobalConstants.TopThreeTeamsByVotes)
                .Project()
                .To<TeamViewModel>();

            var matches = Data.Matches.All()
                .OrderByDescending(m => m.HomeTeam.TeamName)
                .Take(GlobalConstants.TopThreeTeamsByVotes)
                .Project().To<MatchViewModel>();


            return this.View(new StartPageView { Team = teams, Match = matches });
        }

    }
}