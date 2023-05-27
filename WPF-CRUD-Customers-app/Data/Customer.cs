using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CRUD_Customers_app.Data
{
    /// <summary>
    /// Represents a customer entity.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the customer's surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the customer's age.
        /// </summary>
        public double Age { get; set; }

        /// <summary>
        /// Gets or sets the number of books owned by the customer.
        /// </summary>
        public int Books { get; set; }
    }
}