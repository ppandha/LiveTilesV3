using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LiveTilesV3.Models
{
    public class TileLayout
    {
        [Required]
        public int TileLayoutId { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public int NumberOfTiles { get; set; }
    }

    public class TileLayoutDbContext : DbContext
    {
        public TileLayoutDbContext()
            : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TileLayoutDbContext>());
        }

        public DbSet<TileLayout> TileLayouts { get; set; }
    }
}