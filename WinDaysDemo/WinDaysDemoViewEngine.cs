﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WinDaysDemo
{
    public class WinDaysDemoViewEngine : RazorViewEngine
    {
        public WinDaysDemoViewEngine()
        {
            List<string> viewLocationFormats = new List<string> 
            { 
                "~/Views/Overrides/{1}/{0}.cshtml",
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml" 
            };

            ViewLocationFormats = viewLocationFormats.ToArray();

            
        }
    }
}