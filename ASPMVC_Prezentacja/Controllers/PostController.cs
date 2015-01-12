using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVC_Prezentacja.ViewModels;

namespace ASPMVC_Prezentacja.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Index()
        {
            return View(new NameViewModel());
        }

        [HttpPost]
        public ActionResult AcceptValue(NameViewModel nameViewModel)
        {
            return View("~/Views/Home/HelloNameViewModel.cshtml", nameViewModel);
        }
    }
}