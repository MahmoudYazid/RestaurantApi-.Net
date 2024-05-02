using Microsoft.EntityFrameworkCore;

namespace Restaurant.model
{
    public class Db_Context:DbContext
    {
        public DbSet<menuItemEntity> menu { get; set; }
        public DbSet<orderEntity> orders { get; set; }
        public DbSet<Person> customers { get; set; }
        public Db_Context(DbContextOptions options): base(options) { }
    }
}
