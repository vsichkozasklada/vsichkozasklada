using Project.Data;
using Project.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IApplicationData data)
            : base(data)
        {
            // THIS THE GITHUB PROJECT
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(Project.Models.ContactQuery model) 
        {
            if (ModelState.IsValid)
            {
                model.DateSubmitted = DateTime.Now;
                Data.ContactQuery.Add(model);
                Data.SaveChanges();
                
                this.AddNotification("Запитването е изпратено успешно", NotificationType.SUCCESS);
                return RedirectToAction("Index");
            }
            this.AddNotification("Запитването не е изпратено", NotificationType.ERROR);
            return View(model);
        }

        public ActionResult Clear(Project.Models.ContactQuery model) 
        {
            ModelState.Clear();
            return RedirectToAction("Contact");
        }
    }
}