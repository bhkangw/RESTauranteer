using Microsoft.EntityFrameworkCore;

namespace RESTauranteer.Models
{
    public class RestContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public RestContext(DbContextOptions<RestContext> options) : base(options) { }

        public DbSet<Review> Reviews {get;set;}
    }

}