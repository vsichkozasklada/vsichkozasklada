using Project.Data;
using Project.Models;
using Project.Web.Extensions;
using Project.Web.ViewModels;
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
            var blogEntries = Data.BlogEntry.All()
                .OrderByDescending(b => b.PublishDate)
                .Take(3);

            IList<BlogEntryShortViewModel> modelList = new List<BlogEntryShortViewModel>();

            foreach (var item in blogEntries)
            {
                var model = MapBlogEntryShortViewModel(item);
                if (model != null)
                {
                    modelList.Add(model);
                }
            }
            return View(modelList);
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

        private BlogEntryShortViewModel MapBlogEntryShortViewModel(BlogEntry item)
        {
            BlogEntryShortViewModel model = new BlogEntryShortViewModel()
            {
                ID = item.ID,
                Category = item.Category,
                ExpiryDate = item.ExpiryDate,
                PublishDate = item.PublishDate,
                Title = item.Title,
                TextContent = string.IsNullOrEmpty(item.TextContent) ? string.Empty
                    : item.TextContent.Length < 51 ? item.TextContent
                    : string.Format("{0}...", item.TextContent.Remove(50))
            };
            return model;
        }
    }
}