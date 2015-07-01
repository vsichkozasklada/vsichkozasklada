using AutoMapper.QueryableExtensions;
using PagedList;
using SportSystem.Common;
using SportSystem.Data;
using SportSystem.Web.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace SportSystem.Web.Controllers
{

    [Authorize]
    public class MatchesController : BaseController
    {
        public MatchesController(ISportSystemData data)
            : base(data)
        {

        }
        // GET: Matches
        public ActionResult Index(int? page)
        {
            var matches = Data.Matches
                .All()
                .OrderBy(m => m.DateTimeMatch)
                .Project()
                .To<MatchViewModel>()
                .ToPagedList(page ?? GlobalConstants.PageStart, GlobalConstants.ElementsPerPage);
            return View(matches);
        }

        public ActionResult Details(int id)
        {
            var matches = this.Data.Matches
                .All()
                .Where(x => x.Id == id)
                .Project()
                .To<MatchDetailsViewModel>();

            return this.View(matches);
        }
    }
}