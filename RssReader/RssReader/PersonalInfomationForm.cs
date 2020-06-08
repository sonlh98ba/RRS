using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class PersonalInfomationForm : Form
    {
        public PersonalInfomationForm()
        {
            InitializeComponent();
            // Lấy thông tin cá nhân từ form Login
            txtUserName.Text = Login.UserName;
            txtDisplayName.Text = Login.DisplayName;
            txtCount.Text = (Login.LuotDangNhap+1).ToString();
            txtStartDate.Text = Login.StartTime;
        }
    }
}
