using Microsoft.EntityFrameworkCore;

namespace asp_first_project.Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
        {
        }
        public DbSet<Models.Item> Items { get; set; }
    }
}