using CafeManager.BLL.Services;
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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        private AccountService _accountService = new();
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Lấy thông tin từ các trường nhập liệu
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Password; // PasswordBox
                bool isMale = rbMale.IsChecked == true; // RadioButton

                // Gọi phương thức đăng ký
                bool isSuccess = _accountService.Register(username, password, isMale);

                if (isSuccess)
                {
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close(); // Đóng cửa sổ sau khi đăng ký thành công
                }
                else
                {
                    MessageBox.Show("Failed to create account.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
