using CafeManager.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.DAL.Repositories
{
    public class DashboardRepository
    {
        private CoffeeDbContext _context=new();
        // Lấy tổng số lượng đơn hàng
        public int GetOrdersCount()
        {
            return _context.Bills.Count();
        }
        public decimal GetTotalRevenue()
        {
            return _context.BillInfos
                .Join(
                    _context.Foods,
                    billInfo => billInfo.IdFood,
                    food => food.Id,
                    (billInfo, food) => new { billInfo, food }
                )
                .Sum(item => (decimal)item.billInfo.Quantity * (decimal)item.food.Price);
        }
        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            // Lọc các hóa đơn trong khoảng thời gian từ startDate đến endDate
            var totalRevenue = _context.Bills
                                .Where(b => b.DateCheckIn >= startDate && b.DateCheckIn <= endDate)  // Lọc theo ngày
                                .Join(
                                    _context.BillInfos,
                                    bill => bill.Id,  // Giả sử Bill có Id làm khóa chính
                                    billInfo => billInfo.IdBill,  // Giả sử BillInfo có BillId
                                    (bill, billInfo) => new { bill, billInfo }  // Ghép Bill với BillInfo
                                )
                                .Join(
                                    _context.Foods,
                                    billInfo => billInfo.billInfo.IdFood,  // Giả sử BillInfo có FoodId
                                    food => food.Id,  // Giả sử Food có Id
                                    (billInfo, food) => new { billInfo, food }  // Ghép BillInfo với Food
                                )
                                 .Sum(item => (decimal)item.billInfo.billInfo.Quantity * (decimal)item.food.Price);  // Sử dụng item.billInfo.Quantity

            return totalRevenue;  // Trả về tổng doanh thu
        }
        // Lấy tất cả các hóa đơn trong khoảng thời gian
        public List<Bill> GetBillsInRange(DateTime startDate, DateTime endDate)
        {
            return _context.Bills
                           .Where(b => b.DateCheckIn >= startDate && b.DateCheckIn <= endDate)
                           .ToList();
        }
        // Lấy số lượng đơn hàng trong khoảng thời gian
        public int GetOrdersCount(DateTime startDate, DateTime endDate)
        {
            return _context.Bills
                           .Where(b => b.DateCheckIn >= startDate && b.DateCheckIn <= endDate)
                           .Count();
        }





    }
}
