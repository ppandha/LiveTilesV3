using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
﻿using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LiveTilesV3.Models
{
    public class Twitter
    {
        public int TwitterId { get; set; }

        [Required]
        [Display(Name = "Search Criteria")]
        public string SearchCriteria { get; set; }

    }

    public class TwitterDbContext : DbContext
    {
        public TwitterDbContext()
            : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TwitterDbContext>());
        }

        public DbSet<Twitter> Twitters { get; set; }
    }
}