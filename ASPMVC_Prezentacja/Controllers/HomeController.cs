using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVC_Prezentacja.ViewModels;

namespace ASPMVC_Prezentacja.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HelloName(string id)
        {
            ViewBag.Name = id;
            return View();
        }

        public ActionResult HelloNameViewModel(string firstname, string lastname)
        {
            NameViewModel vrlNameViewModel = new NameViewModel
            {
                FirstName = firstname,
                LastName = lastname
            };

            return View(vrlNameViewModel);
        }
    }
}
