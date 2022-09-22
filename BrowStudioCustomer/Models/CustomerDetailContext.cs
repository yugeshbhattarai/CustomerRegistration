using Microsoft.EntityFrameworkCore;

namespace BrowStudioCustomer.Models
{
    public class CustomerDetailContext: DbContext
    {
        public CustomerDetailContext(DbContextOptions<CustomerDetailContext> options) : base(options)
        { }

        public DbSet<CustomerDetail> CustomerDetails { get; set; }
    }
}
