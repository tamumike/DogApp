using Microsoft.EntityFrameworkCore;
using Review.API.Models;

namespace Review.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<User>  Users { get; set; }
        
    }
}