using Microsoft.EntityFrameworkCore;

namespace schhedulerApp.Models
{
    public class SchedulerAppContext : DbContext
    {
        public SchedulerAppContext(DbContextOptions<SchedulerAppContext> options) :
            base(options)
        { }

        //Begin Defining your models that will be generated into tables
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
