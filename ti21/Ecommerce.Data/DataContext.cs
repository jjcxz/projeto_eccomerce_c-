using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class DataContext : DbContext
    {   
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { }

        public DbSet<Person> People { get; set; }
        public DbSet<PersonJ> PeopleJ { get; set; }
        public DbSet<PersonF> PeopleF { get; set; }
        public DbSet<Order> Orders { get; set; }  
        public DbSet<Object> Objects { get; set; }
        public DbSet<Address> Addresses { get; set; }  
    }
}