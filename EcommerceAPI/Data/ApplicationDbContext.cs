using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) { }


    }
}
