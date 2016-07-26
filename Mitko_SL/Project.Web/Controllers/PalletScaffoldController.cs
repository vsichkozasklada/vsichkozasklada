using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class PalletScaffoldController : BaseController
    {
        public PalletScaffoldController(IApplicationData data)
            : base(data)
        {

        }
        // GET: PalletScaffold
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() 
        {
            return View();
        }
    }
}