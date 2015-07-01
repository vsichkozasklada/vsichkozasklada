using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportSystem.Web.ViewModels
{
    public class StartPageView
    {
        public IEnumerable<MatchViewModel>  Match { get; set; }
        public IEnumerable<TeamViewModel> Team { get; set; }
    }
}