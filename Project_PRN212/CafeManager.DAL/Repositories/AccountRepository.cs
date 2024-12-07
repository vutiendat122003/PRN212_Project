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
            _context = new();
            // trả về 1 account duy nhất : username : email không phân biệt chữ hoa chữ thường , password chuẩn 
            return _context.Accounts.FirstOrDefault(x => x.Name.ToLower() == user.ToLower() && x.Password ==password);
        }
    }
}
