using asp_crud_app.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace asp_crud_app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
