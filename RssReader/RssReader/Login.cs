using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace RssReader
{
    public partial class Login : Form
    {
        // Biến truyền thông tin
        public static string UserName; 
        public static string DisplayName;
        public static string StartTime;
        public static int LuotDangNhap;
        public static int AccountType = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;

            if (isLogin(userName, passWord))
            {
                UserName = userName;
                Form1 MI = new Form1();
                Hide();
                MI.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        
        // Hàm check login và get thông tin toàn cục
        bool isLogin(string userName, string passWord)
        {
            string query = "Select * from nguoi_dung where id = '" + userName + "' and mk = '" + passWord + "'";
            if (DataProvider.Instance.ExecuteScalar(query) != null)
            {
                query = "Select luot_dang_nhap from nguoi_dung where id = '" + userName + "' and mk = '" + passWord + "'";
                LuotDangNhap = (int)DataProvider.Instance.ExecuteScalar(query);
                query = "Select name from nguoi_dung where id = '" + userName + "' and mk = '" + passWord + "'";
                DisplayName = DataProvider.Instance.ExecuteScalar(query).ToString(); ;
                query = "Select ngay_khoi_tao from nguoi_dung where id = '" + userName + "' and mk = '" + passWord + "'";
                StartTime = DataProvider.Instance.ExecuteScalar(query).ToString();
                query = "Select loai_tai_khoan from nguoi_dung where id = '" + userName + "'";
                AccountType = (int)DataProvider.Instance.ExecuteScalar(query);
                return true;
            }    
            else
                return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
