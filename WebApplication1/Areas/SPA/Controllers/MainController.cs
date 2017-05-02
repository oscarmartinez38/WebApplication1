using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels.SPA;
using OldViewModel = WebApplication1.ViewModels;

namespace WebApplication1.Areas.SPA.Controllers
{
    public class MainController : Controller
    {
        
        public ActionResult Index()
        {
            MainViewModel v = new MainViewModel();
            v.UserName = User.Identity.Name;
            v.FooterData = new OldViewModel.FooterViewModel();
            v.FooterData.CompanyName = "Oscar Martinez";
            v.FooterData.Year = DateTime.Now.Year.ToString();
            return View("Index", v);
        }
    }
}