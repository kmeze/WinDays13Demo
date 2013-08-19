using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinDaysDemo.Models;

namespace WinDaysDemo.Filters
{
    public class IndexActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var db = new SpeakerContext();
            var speakers = db.Speakers.ToList();

            filterContext.Controller.ViewData.Model = speakers;
        }
    }
}