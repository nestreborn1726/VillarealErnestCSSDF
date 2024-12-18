using Microsoft.EntityFrameworkCore;
using VillarealErnestCSSDF.Models;

namespace VillarealErnestCSSDF.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
