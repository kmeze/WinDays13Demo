using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WinDaysDemo.Models
{
    public class SpeakerContext : DbContext
    {
        public SpeakerContext() : base("WinDaysDemoConnectionString") { }

        public DbSet<Speaker> Speakers { get; set; }
    }
}