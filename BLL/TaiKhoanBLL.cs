using DAL;
using DTO;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL tkDAL;
        private readonly Random random = new Random();
        public TaiKhoanBLL()
        {
            tkDAL = new TaiKhoanDAL();
        }
        public DataTable getListTaiKhoan()
        {
            return tkDAL.getListTaiKhoan();
        }
        public bool insertTaiKhoan(TaiKhoanDTO tk)
        {
            return tkDAL.insertTaiKhoan(tk);
        }
        public string getLastMaTK()
        {
            string lastMaTK = tkDAL.getLastMaTK();
            if (!string.IsNullOrEmpty(lastMaTK))
            {
                string tempLastNumber = lastMaTK.Substring(2);
                if (int.TryParse(tempLastNumber, out int lastNumber))
                {
                    lastNumber++;
                    string nextNumber = lastNumber.ToString("D3");
                    string nextMaTK = "TK" + nextNumber;
                    return nextMaTK;
                }
            }
            return null;
        }
        
        public string GenerateRandomPassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*()-=_+[]{}|;:'\",.<>/?";

            // Sử dụng StringBuilder để hiệu quả khi cần thay đổi chuỗi nhiều lần
            StringBuilder password = new StringBuilder();

            // Thêm ít nhất một ký tự đặc biệt
            password.Append(GetRandomChar(specialChars));

            // Thêm ít nhất một số
            password.Append(GetRandomChar(digits));

            // Thêm các ký tự chữ còn lại
            for (int i = 0; i < 10; i++)
            {
                password.Append(GetRandomChar(chars));
            }

            // Trộn ngẫu nhiên các ký tự trong password
            string result = new string(password.ToString().ToCharArray().OrderBy(x => random.Next()).ToArray());

            return result;
        }

        private char GetRandomChar(string charSet)
        {
            int index = random.Next(charSet.Length);
            char selectedChar = charSet[index];

            // Loại bỏ ký tự đã chọn từ tập hợp
            charSet = charSet.Remove(index, 1);

            return selectedChar;
        }
    }
}
