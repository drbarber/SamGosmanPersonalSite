using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalSite.WebUI.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        
        public ViewResult Index()
        { 
            return View();
        }
       
        public ViewResult Resume()
        {
            return View();
        }
        
        public ViewResult FourOhFour()
        {
            return View();
        }
       
        public ViewResult SocialMedia()
        {
            return View();
        }
        
        public ViewResult Contact()
        {
            return View();
        }
        
        public PartialViewResult Menu()
        {
            
            return PartialView();
        }

    }
}