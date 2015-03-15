using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
﻿using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace LiveTilesV3.Models
{
    public class Newsfeed
    {
        public int NewsfeedId { get; set; }

        [Required]
        [Display(Name = "RSS Source URL")]
        public string RssUrl { get; set; }
    }

    public class NewsfeedDbContext : DbContext
    {
        public NewsfeedDbContext()
            : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<NewsfeedDbContext>());
        }

        public DbSet<Newsfeed> Newsfeeds { get; set; }
    }
}