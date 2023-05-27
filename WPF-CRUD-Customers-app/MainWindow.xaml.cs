using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_CRUD_Customers_app.Data;

namespace WPF_CRUD_Customers_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerDbContext context;
        Customer NewCustomer = new Customer();
        Customer selectedCustomer = new Customer();


        public MainWindow(CustomerDbContext context)
        {
            this.context = context;
            InitializeComponent();
            GetCustomers();
            NewCustomerGrid.DataContext = NewCustomer;
        }


        private void GetCustomers()
        {
            CustomerDG.ItemsSource = context.Customers.ToList();
        }

        private void AddItem(object s, RoutedEventArgs e)
        {
            context.Customers.Add(NewCustomer);
            context.SaveChanges();
            GetCustomers();
            NewCustomer = new Customer();
            NewCustomerGrid.DataContext = NewCustomer;
        }

        private void UpdateItem(object s, RoutedEventArgs e)
        {
            context.Update(selectedCustomer);
            context.SaveChanges();
            GetCustomers();
        }

        private void SelectCustomerToEdit(object s, RoutedEventArgs e)
        {
            selectedCustomer = (s as FrameworkElement).DataContext as Customer;
            UpdateCustomerGrid.DataContext = selectedCustomer;
        }

        private void DeleteCustomer(object s, RoutedEventArgs e)
        {
            var customerToDelete = (s as FrameworkElement).DataContext as Customer;
            context.Customers.Remove(customerToDelete);
            context.SaveChanges();
            GetCustomers();
        }
    }
}
