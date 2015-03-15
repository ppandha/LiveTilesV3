using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LiveTilesV3.Models
{
    public class TileLayoutUserLink
    {
        [Required]
        public int TileLayoutUserLinkId { get; set; }

        [Required]
        public int UserId { get; set; }



        public UserAccount User { get; set; }
    }

    public class TileLayoutUserLinkDbContext : DbContext
    {
        public TileLayoutUserLinkDbContext()
            : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TileLayoutUserLinkDbContext>());
        }

        public DbSet<TileLayoutUserLink> TileLayoutUserLinks { get; set; }
    }
}