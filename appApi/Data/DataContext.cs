
using appApi.Models;
using Microsoft.EntityFrameworkCore;


namespace appApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }

    
}

