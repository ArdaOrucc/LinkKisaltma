using Microsoft.EntityFrameworkCore;

namespace LinkKisaltma.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<TBLLink> Links { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-FEBL0K35\SQLEXPRESS;Database=LinkKisaltma;Trusted_Connection=true;encrypt=false");
        }
    }
}
