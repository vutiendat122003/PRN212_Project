using CafeManager.BLL.Services;
using CafeManager.DAL.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoffeShopManagement.Admin
{
    /// <summary>
    /// Interaction logic for AccountPage.xaml
    /// </summary>
    public partial class AccountPage : Page
    {
        private AccountService _accountService = new();
        public AccountPage()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Assuming you are retrieving a list of accounts from the service.
                var accounts = _accountService.GetAllAccounts();
                AccountsDataGrid.ItemsSource = accounts;  // Binding data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading accounts: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AccountsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AccountsDataGrid.SelectedItem is Account selectedAccount)
            {
                // Gán dữ liệu từ dòng được chọn
                AccountIdTextBox.Text = selectedAccount.Id.ToString();
                NameTextBox.Text = selectedAccount.Name;
                PasswordBox.Password = selectedAccount.Password;
                


                // Gán Gender (Male/Female) vào ComboBox
                GenderComboBox.SelectedValue = selectedAccount.Gender== true  ? "Male" : "Female";

                // Gán Type (Admin/Staff) vào ComboBox
                TypeComboBox.SelectedValue = selectedAccount.Type == 1 ? "Admin" : "Staff";
            }
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra xem có chọn tài khoản nào không
            if (AccountsDataGrid.SelectedItem is not Account selectedAccount)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Kiểm tra các trường thông tin có hợp lệ không
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                MessageBox.Show("Tên và Mật khẩu không được để trống.", "Lỗi xác thực", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Kiểm tra mật khẩu có hợp lệ không
            string newPassword = PasswordBox.Password;
            if (!PasswordHasher.IsValidPassword(newPassword))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt.", "Lỗi xác thực", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Lấy dữ liệu từ form
            string newUserName = NameTextBox.Text;

            // Mã hóa mật khẩu trước khi lưu
            string hashedPassword = PasswordHasher.HashPassword(newPassword);

            bool? newGender = GenderComboBox.SelectedValue.ToString() == "Male" ? (bool?)true : (bool?)false;  // true nếu giới tính là Male, false nếu Female
            int? newType = TypeComboBox.SelectedValue.ToString() == "Admin" ? (int?)1 : (int?)0; // 1 nếu loại là Admin, 0 nếu là Staff

            try
            {
                // Gọi phương thức Update từ AccountService để lưu thay đổi
                _accountService.UpdateAccount(selectedAccount.Id, newUserName, hashedPassword, newGender, newType);

                MessageBox.Show("Cập nhật tài khoản thành công!", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);
                RefreshDataGrid();  // Cập nhật lại DataGrid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật tài khoản: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        // Phương thức làm mới DataGrid
        private void RefreshDataGrid()
        {
            var accounts = _accountService.GetAllAccounts();  // Lấy danh sách tài khoản mới nhất
            AccountsDataGrid.ItemsSource = accounts;  // Cập nhật lại nguồn dữ liệu cho DataGrid
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra xem có chọn tài khoản nào không
            if (AccountsDataGrid.SelectedItem is not Account selectedAccount)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            // Nếu người dùng chọn Yes, thực hiện xóa
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    // Gọi phương thức xóa tài khoản từ AccountService
                    _accountService.DeleteAccount(selectedAccount.Id);

                    MessageBox.Show("Tài khoản đã được xóa thành công!", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Làm mới DataGrid sau khi xóa
                    RefreshDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa tài khoản: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

    }
}
