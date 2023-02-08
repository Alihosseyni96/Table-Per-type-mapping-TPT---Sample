using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class TPTContext:DbContext
    {
        public TPTContext(DbContextOptions<TPTContext> context):base(context)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder opBuilder)
        {
            opBuilder.UseSqlServer("Data source=.; Initial Catalog= ZabanAmozDb; Integrated Security= True; MultipleActiveResultSets=True");
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
