using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
﻿using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace LiveTilesV3.Models
{
    public class Noticeboard
    {
        public int NoticeboardId { get; set; }

        [Required]
        public string Heading { get; set; }

        [Required]
        public string Contents { get; set; }
    }

    public class NoticeboardDbContext : DbContext
    {
        public NoticeboardDbContext()
            : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<NoticeboardDbContext>());
        }

        public DbSet<Noticeboard> Noticeboards { get; set; }

    }
}
