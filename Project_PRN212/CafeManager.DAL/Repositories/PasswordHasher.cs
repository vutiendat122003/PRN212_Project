using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CafeManager.DAL.Repositories
{
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                // Chuyển đổi mật khẩu thành mảng byte
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Mã hóa bằng SHA256
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                // Chuyển đổi mảng byte thành chuỗi dạng hex
                StringBuilder hash = new StringBuilder();
                foreach (var b in hashedBytes)
                {
                    hash.Append(b.ToString("x2"));
                }
                return hash.ToString();
            }
        }
        public static bool IsValidPassword(string password)
        {
            // Biểu thức chính quy để kiểm tra mật khẩu có ít nhất một chữ hoa, một chữ thường, một chữ số và một ký tự đặc biệt
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            // Kiểm tra mật khẩu với biểu thức chính quy
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }
    }
}
