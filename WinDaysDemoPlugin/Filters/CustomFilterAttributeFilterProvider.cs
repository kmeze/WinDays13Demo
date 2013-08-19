using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinDaysDemo.Filters;

namespace WinDaysDemo.Filters
{
    public class CustomFilterAttributeFilterProvider : FilterAttributeFilterProvider
    {
        protected override IEnumerable<FilterAttribute> GetActionAttributes(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            var attributes = new List<FilterAttribute>();
            
            if (actionDescriptor.ActionName == "Index" && actionDescriptor.ControllerDescriptor.ControllerName == "Home")
            {
                attributes.Add(new CustomIndexActionFilterAttribute());
            }
            else
            {
                attributes = base.GetActionAttributes(controllerContext, actionDescriptor) as List<FilterAttribute>;
            }

            return attributes;
        }
    }
}