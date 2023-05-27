using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CRUD_Customers_app.Data
{
    /// <summary>
    /// Represents the database context for customers.
    /// </summary>
    public class CustomerDbContext : DbContext
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDbContext"/> class with the specified options.
        /// </summary>
        /// <param name="options">The options for configuring the customer database context.</param>
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Gets or sets the DbSet of customers.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
        #endregion

        #region Overridden methods
        /// <summary>
        /// Configures the model of the customer database context.
        /// </summary>
        /// <param name="modelBuilder">The model builder used to construct the model.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(GetCustomers());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Gets the initial customers data.
        /// </summary>
        /// <returns>An array of initial customer objects.</returns>
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