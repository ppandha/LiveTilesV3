using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LiveTilesV3.Models
{
    public class UserAccount
    {
        [Required]
        public int UserAccountId { get; set; }

        [Required]
        [Display(Name = "Organization Unit")]
        public string OrgUnit { get; set; }

        [Display(Name = "Organization Name")]
        public string OrgName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public int TileLayoutId { get; set; }
        public TileLayout TileLayout { get; set; }





    }

    public class UserAccountDbContext : DbContext
    {
        public UserAccountDbContext()
            : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<UserAccountDbContext>());
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}