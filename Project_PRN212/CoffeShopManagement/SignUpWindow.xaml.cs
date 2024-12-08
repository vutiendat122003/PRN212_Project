using CafeManager.BLL.Services;
using CafeManager.DAL.Repositories;
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

                // Kiểm tra nếu tên người dùng hoặc mật khẩu bị trống
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username và Password không được để trống.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Kiểm tra mật khẩu có hợp lệ không
                if (!PasswordHasher.IsValidPassword(password))
                {
                    MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt.", "Lỗi xác thực", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Mã hóa mật khẩu trước khi lưu
                string hashedPassword = PasswordHasher.HashPassword(password);

                // Gọi phương thức đăng ký
                bool isSuccess = _accountService.Register(username, hashedPassword, isMale);

                if (isSuccess)
                {
                    MessageBox.Show("Tạo tài khoản thành công!", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close(); // Đóng cửa sổ sau khi đăng ký thành công
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản không thành công. Có thể tên người dùng đã tồn tại.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
