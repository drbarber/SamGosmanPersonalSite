using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalSite.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ViewResult Index()
        { 
            return View();
        }
        [HandleError]
        public ViewResult Resume()
        {
            return View();
        }
        [HandleError]
        public ViewResult FourOhFour()
        {
            return View();
        }
        [HandleError]
        public ViewResult SocialMedia()
        {
            return View();
        }
        [HandleError]
        public ViewResult Contact()
        {
            return View();
        }
        [HandleError]
        public PartialViewResult Menu()
        {
            
            return PartialView();
        }

    }
}