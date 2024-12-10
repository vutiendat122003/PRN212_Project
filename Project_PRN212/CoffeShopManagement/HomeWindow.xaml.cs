using CafeManager.BLL.Services;
using CafeManager.DAL.Models;
using CoffeShopManagement.Admin;
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
using static CafeManager.DAL.Repositories.FoodRepository;

namespace CoffeShopManagement
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void NavigateToTableStatus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NavigateToDashboard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NavigateToBills_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NavigateToProduct_Click(object sender, RoutedEventArgs e)
        {
            var dbContext = new CoffeeDbContext(); // Khởi tạo DbContext
            var productRepository = new ProductRepository(dbContext); // Repository
            var productService = new ProductService(productRepository); // Service

            frMain.Content = new ProductPage(productService);
        }

        private void NavigateToAccounts_Click(object sender, RoutedEventArgs e)
        {
            frMain.Content = new AccountPage();

        }

        private void NavigateToLogin_Click(object sender, RoutedEventArgs e)
        {

            // Nếu có sử dụng Cookies hoặc Session, xóa thông tin liên quan đến đăng nhập ở đó.

            // Đóng cửa sổ hiện tại và mở cửa sổ đăng nhập
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();  // Mở cửa sổ đăng nhập
            this.Close();  // Đóng cửa sổ hiện tại (nếu cần)
        }

    }
}
