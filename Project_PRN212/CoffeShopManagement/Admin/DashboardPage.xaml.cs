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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoffeShopManagement.Admin
{
    /// <summary>
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    public partial class DashboardPage : Page
    {
        private DashboardService _dashboardService;

        public DashboardPage()
        {
            InitializeComponent();
            _dashboardService = new DashboardService(); // Khởi tạo DashboardService
            LoadDashboardData(); // Tải dữ liệu khi trang được mở
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Lấy khoảng thời gian từ các DatePicker
            DateTime? startDate = StartDatePicker.SelectedDate;
            DateTime? endDate = EndDatePicker.SelectedDate;

            if (startDate.HasValue && endDate.HasValue)
            {
                LoadFilteredData(startDate.Value, endDate.Value);
            }
            else
            {
                MessageBox.Show("Please select both start and end dates.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadFilteredData(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Lấy tổng doanh thu trong khoảng thời gian
                decimal totalRevenue = _dashboardService.GetTotalRevenue(startDate, endDate);
                txtTotalRevenue.Text = $"{totalRevenue:C}"; // Hiển thị tổng doanh thu (định dạng tiền tệ)

                // Lấy số lượng đơn hàng trong khoảng thời gian
                int ordersCount = _dashboardService.GetOrdersCount(startDate, endDate);
                txtOrdersCount.Text = ordersCount.ToString(); // Hiển thị số lượng đơn hàng

                /// Hiển thị tất cả các hóa đơn
                var bills = _dashboardService.GetBillsInRange(DateTime.MinValue, DateTime.MaxValue); // Lấy tất cả các hóa đơn
                RevenueDetailsDataGrid.ItemsSource = bills; // Binding vào DataGrid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading filtered data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                // Lấy số lượng đơn hàng
                int ordersCount = _dashboardService.GetOrdersCount();
                txtOrdersCount.Text = ordersCount.ToString(); // Hiển thị số lượng đơn hàng

                // Lấy tổng doanh thu
                decimal totalRevenue = _dashboardService.GetTotalRevenue();
                txtTotalRevenue.Text = $"{totalRevenue:C}"; // Hiển thị tổng doanh thu (định dạng tiền tệ)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    
}
}
