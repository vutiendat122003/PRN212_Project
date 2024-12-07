using CafeManager.DAL.Models;
using CafeManager.BLL.Services;
using Microsoft.IdentityModel.Tokens;
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
using System.Windows.Shapes;

namespace CoffeShopManagement
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private AccountService _accountService = new();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // check if user didn't enter anything
            if (txtEmail.Text.IsNullOrEmpty() || txtPassword.Password.IsNullOrEmpty())
            {
                MessageBox.Show("Username and Password cannot be empty", "Wrong credentials", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Successfully authenticated; proceed to the appropriate home screen based on role
            Account? account = _accountService.Authenticate(txtEmail.Text, txtPassword.Password);
            if (account == null)
            {
                MessageBox.Show("Invalid Username or Wrong Password", "Wrong credentials", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Check the role of the authenticated user
            if (account.Type == 0)
            {
                StaffWindow adminWindow = new StaffWindow(); // Assuming you have an Admin window
                adminWindow.Show();
            }
            else if (account.Type == 1)
            {
                HomeWindow homeWindow = new HomeWindow(); // User's home screen
                homeWindow.Show();
            }
            else
            {
                MessageBox.Show("Your account does not have permission to access the system.", "Access Denied", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            this.Hide();
        }
    }
}
