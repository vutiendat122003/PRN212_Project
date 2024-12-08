using CafeManager.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.DAL.Repositories
{
    public class AccountRepository
    {
        private CoffeeDbContext _context;
        public Account GetOne(string user, string password)
        {
            //khởi tạo 1 vùng ram mới cho biến conect database
            using var _context = new CoffeeDbContext();
            // mã khóa mất khẩu
            string hashedPassword = PasswordHasher.HashPassword(password);

            // trả về 1 account duy nhất : username : email không phân biệt chữ hoa chữ thường , password chuẩn 
            return _context.Accounts.FirstOrDefault(x => x.Name.ToLower() == user.ToLower() && x.Password ==hashedPassword);
        }
        public Account GetByUserName(string userName)
        {
            using var _context = new CoffeeDbContext();
            return _context.Accounts.FirstOrDefault(x => x.Name.ToLower() == userName.ToLower());
        }

        public void AddAccount(string user, string password, bool gender)
        {
            try
            {
                using var context = new CoffeeDbContext();

                // Mã hóa mật khẩu trước khi lưu vào cơ sở dữ liệu
                string hashedPassword = PasswordHasher.HashPassword(password);

                // Tạo đối tượng Account mới
                var account = new Account
                {
                    Name = user,
                    Password = hashedPassword,
                    Gender = gender,
                };

                // Thêm tài khoản vào DbSet
                context.Accounts.Add(account);

                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding account: {ex.Message}");
                throw;
            }
        }
        public List<Account> GetAllAccounts()
        {
            using var context = new CoffeeDbContext();
            return context.Accounts.ToList(); // Trả về tất cả tài khoản từ cơ sở dữ liệu
        }

    }
}
