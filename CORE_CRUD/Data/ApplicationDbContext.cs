using CORE_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CORE_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
