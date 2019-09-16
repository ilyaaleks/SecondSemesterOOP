using System.Data.Entity;

namespace Lab12.Models
{
    public class MobileContext : DbContext
    {
        public MobileContext() : base("DefaultConnection")
        {

        }
        public DbSet<Phone> Phones { get; set; }
    }
}
