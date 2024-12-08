using CafeManager.DAL.Models;
using CafeManager.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.BLL.Services
{
    public class AccountService
    {
        private AccountRepository _accountRepository = new();
        public Account? Authenticate(string user, string password)
        {
            return _accountRepository.GetOne(user, password);
        }
        public bool Register(string userName, string password, bool gender)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            // Sử dụng GetByUserName để kiểm tra trùng lặp
            var existingAccount = _accountRepository.GetByUserName(userName);
            if (existingAccount != null)
            {
                return false;
            }

            try
            {
                _accountRepository.AddAccount(userName, password, gender);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering account: {ex.Message}");
                return false;
            }
        }
        public List<Account> GetAllAccounts()
        {
            return _accountRepository.GetAllAccounts(); // Gọi phương thức trong Repository để lấy tất cả tài khoản
        }

    }
}
