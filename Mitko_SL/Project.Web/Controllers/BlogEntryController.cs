using Project.Data;
using Project.Models;
using Project.Web.Extensions;
using Project.Web.InputModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class BlogEntryController : BaseController
    {
        public BlogEntryController(IApplicationData data)
            : base(data)
        {

        }
        // GET: BlogEntry
        public ActionResult Index()
        {

            var blogEntries = Data.BlogEntry.All();
            List<BlogEntryViewModel> model = new List<BlogEntryViewModel>();
            foreach (var item in blogEntries)
            {
                model.Add(MapToBlogEntryInputModel(item));
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlogEntryInputModel model)
        {
            return ImageValidation(model);
        }

        private ActionResult ImageValidation(BlogEntryInputModel model)
        {
            var validImageTypes = new string[] 
            {
                "image/jpeg",
                "image/pjpeg",
                "image/png"
            };

            if (model.ImageUpload == null || model.ImageUpload.ContentLength == 0)
            {
                this.AddNotification("Моля въведете валиден файл с разширение (jpeg; pjpeg; png)", NotificationType.ERROR);
                return View(model);
            }

            if (!validImageTypes.Contains(model.ImageUpload.ContentType))
            {
                this.AddNotification("Моля въведете валиден файл с разширение (jpeg; pjpeg; png)", NotificationType.ERROR);
                return View(model);
            }

            if (model != null && ModelState.IsValid)
            {
                var blogEntry = new BlogEntry()
                {
                    PublishDate = DateTime.Now,
                    TextContent = model.TextContent,
                    Title = model.Title,
                    ExpiryDate = DateTime.Now.AddMonths(2)
                };

                Data.BlogEntry.Add(blogEntry);
                Data.SaveChanges();

                var image = new Image()
                {
                    Title = model.ImageUpload.FileName,
                    AltText = model.ImageTitle,
                    BlogEntryID = blogEntry.ID,
                    DateUploaded = DateTime.Now,
                    Type = Common.Enumerators.ImageType.blogEntry
                };

                var uploadDir = "~/Images";
                var imageName = Guid.NewGuid() + model.ImageUpload.FileName;
                var imagePath = Path.Combine(Server.MapPath(uploadDir), imageName);
                var imageUrl = Path.Combine(uploadDir, imageName);

                model.ImageUpload.SaveAs(imagePath);
                // image.ImageFilePath = imageUrl;
                image.ImageFilePath = uploadDir + "/" + imageName;

                this.Data.Image.Add(image);
                this.Data.SaveChanges();

                model.ImageUpload.InputStream.Dispose();

                this.AddNotification("Успешно създадохте нова статия", NotificationType.SUCCESS);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        private BlogEntryViewModel MapToBlogEntryInputModel(BlogEntry item)
        {
            var image = Data.Image.All().Where(i => i.BlogEntryID == item.ID).FirstOrDefault();

            BlogEntryViewModel model = new BlogEntryViewModel()
            {
                ID = image != null ? "myModal" + image.ID : "",
                Author = item.Author,
                Category = item.Category,
                ExpiryDate = item.ExpiryDate,
                PublishDate = item.PublishDate,
                Title = item.Title,
                ImagePath = image != null ? image.ImageFilePath : "no title",
                ImageTitle = image != null ? image.AltText : "no title",
                ImageAltText = image != null ? image.Title : "no title",
                TextContent = item.TextContent
            };
            return model;
        }
    }
}