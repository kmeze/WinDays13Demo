using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Reflection;

namespace WinDaysDemo
{
    public class WinDaysDemoBootstrapper
    {
        public static void Init()
        { 
            var pluginsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            var pluginRegistrations = AppDomain.CurrentDomain.GetAssemblies().ToList().SelectMany(s => s.GetTypes()).Where(p => typeof(IPluginRegistration).IsAssignableFrom(p) && p.IsClass);

            foreach (var pluginRegistration in pluginRegistrations)
            {
                var instance = Activator.CreateInstance(pluginRegistration) as IPluginRegistration;
                instance.RegisterPlugin();
            }
        }
    }
}