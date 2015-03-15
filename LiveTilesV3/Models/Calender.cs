using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
﻿using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace LiveTilesV3.Models
{
    public class Calender
    {
        public int CalenderId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Contents { get; set; }

        public string Location { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

    }

    public class CalenderDbContext : DbContext
    {
        public CalenderDbContext()
            : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CalenderDbContext>());
        }

        public DbSet<Calender> Calenders { get; set; }

    }
}