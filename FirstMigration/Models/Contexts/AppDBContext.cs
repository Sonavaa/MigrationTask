using FirstMigration.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstMigration.Contexts
{
    public class AppDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string cString = "Server = DESKTOP-JFOAGE0\\SQLEXPRESS;Database = MigrateTask;Trusted_Connection = true;Trustservercertificate = true;";
            optionsBuilder.UseSqlServer(cString);
        }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brands> Brands { get; set; }
    }
}
