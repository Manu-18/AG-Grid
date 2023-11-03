using Microsoft.EntityFrameworkCore;

namespace AG_Grid.Models
{
    public class DataDBContext:DbContext
    {

        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) { }
        public DbSet<Data> Data { get; set; }
    }
}
