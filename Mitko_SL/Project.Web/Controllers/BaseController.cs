using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class BaseController : Controller
    {
        //protected BaseController(IApplicationDbContext data)
        //{
        //    this.Data = data;
        //}

        //public IApplicationDbContext Data { get; private set; }

        protected BaseController(IApplicationData data)
        {
            this.Data = data;
        }

        public IApplicationData Data { get; private set; }
    }
}