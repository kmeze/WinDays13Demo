using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WinDaysDemo;
using WinDaysDemo.Filters;

namespace WinDaysDemoPlugin
{
    public class PluginRegistration : IPluginRegistration
    {
        public void RegisterPlugin()
        {
            var defaultProvider = FilterProviders.Providers.Where(fp => fp.GetType() == typeof(FilterAttributeFilterProvider)).FirstOrDefault();
            FilterProviders.Providers.Remove(defaultProvider);
            FilterProviders.Providers.Add(new CustomFilterAttributeFilterProvider());
        }
    }
}