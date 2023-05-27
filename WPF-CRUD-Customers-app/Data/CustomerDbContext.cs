using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CRUD_Customers_app.Data
{
    public class CustomerDbContext : DbContext
    {
        #region Constructor
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public DbSet<Customer> Customers { get; set; }
        #endregion

        #region Overridden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(GetCustomers());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        private Customer[] GetCustomers()
        {
            return new Customer[]
            {
                new Customer { Id = 1, FirstName = "John", Surname = "Doe", Age = 30, Books = 5 },
                new Customer { Id = 2, FirstName = "Alice", Surname = "Smith", Age = 25, Books = 3 },
                new Customer { Id = 3, FirstName = "Michael", Surname = "Johnson", Age = 45, Books = 10 },
                new Customer { Id = 4, FirstName = "Emily", Surname = "Brown", Age = 35, Books = 7 },
                new Customer { Id = 5, FirstName = "David", Surname = "Miller", Age = 28, Books = 2 },
                new Customer { Id = 6, FirstName = "Sophia", Surname = "Wilson", Age = 32, Books = 4 },
                new Customer { Id = 7, FirstName = "Daniel", Surname = "Taylor", Age = 40, Books = 6 }
            };
        }
        #endregion
    }
}
