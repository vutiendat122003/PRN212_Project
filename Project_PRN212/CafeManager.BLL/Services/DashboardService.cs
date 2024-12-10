using CafeManager.DAL.Models;
using CafeManager.DAL.Repositories;
using System;
using System.Collections.Generic;

namespace CafeManager.BLL.Services
{
    public class DashboardService
    {
        private DashboardRepository _dashboardRepository;

        public DashboardService()
        {
            _dashboardRepository = new DashboardRepository();
        }

        // Lấy tổng số lượng đơn hàng
        public int GetOrdersCount()
        {
            return _dashboardRepository.GetOrdersCount();
        }

        // Lấy tổng doanh thu
        public decimal GetTotalRevenue()
        {
            return _dashboardRepository.GetTotalRevenue();
        }

        // Lấy tổng doanh thu trong khoảng thời gian
        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            return _dashboardRepository.GetTotalRevenue(startDate, endDate);
        }

        // Lấy tất cả các hóa đơn trong khoảng thời gian
        public List<Bill> GetBillsInRange(DateTime startDate, DateTime endDate)
        {
            return _dashboardRepository.GetBillsInRange(startDate, endDate);
        }

        // Lấy số lượng đơn hàng trong khoảng thời gian
        public int GetOrdersCount(DateTime startDate, DateTime endDate)
        {
            return _dashboardRepository.GetOrdersCount(startDate, endDate);
        }
    }
}
