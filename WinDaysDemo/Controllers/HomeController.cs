using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinDaysDemo.Models;
using WinDaysDemo.Filters;

namespace WinDaysDemo.Controllers
{
    public class HomeController : Controller
    {
        [IndexActionFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}
