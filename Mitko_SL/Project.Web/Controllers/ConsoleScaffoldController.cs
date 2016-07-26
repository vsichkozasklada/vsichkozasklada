using Project.Data;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class ConsoleScaffoldController : BaseController
    {
        public ConsoleScaffoldController(IApplicationData data)
            : base(data)
        {

        }
        // GET: ConsoleScaffold
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.BusinessPartnerID = new SelectList(Data.BusinessPartners.All(), "ID", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ConsoleScaffold model)
        {
            if (ModelState.IsValid)
            {
                AddBusinessPartner(model);

                if (model.BusinessPartner.ID > 0)
                {
                    model.BusinessPartnerID = model.BusinessPartner.ID;
                    model.DateSubmitted = DateTime.Now;

                    Data.ConsoleScaffold.Add(model);
                    Data.SaveChanges();

                    return RedirectToAction("Index");
                }
                return this.View(model);
            }

            return this.View(model);
        }

        private void AddBusinessPartner(ConsoleScaffold model)
        {
            Data.BusinessPartners.Add(model.BusinessPartner);
            Data.SaveChanges();
        }
    }
}