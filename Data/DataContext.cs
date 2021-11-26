using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{
    public class DataContext : DbContext
    {
        
        // THIS LINE IS VERY IMPORTANT!
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }


        public DbSet<Person> person {get; set;}


    }
}