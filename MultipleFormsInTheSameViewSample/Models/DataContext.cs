using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MultipleFormsInTheSameViewSample.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}