using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace RssReader
{
    public partial class Form1 : Form
    {
        String CurrentUser = Login.UserName;
        public Form1()
        {
            InitializeComponent();
            if (Login.AccountType == 0) tsmiReport.Enabled = false;
            else tsmiReport.Enabled = true;
            LoadListNewsType();
            ShowInfo();
            string query = "UPDATE nguoi_dung SET luot_dang_nhap = " + (Login.LuotDangNhap + 1).ToString() + " WHERE id = '" + CurrentUser + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            this.Text = "RSS Reader V0.1 - Account: " + CurrentUser;
            MessageBox.Show("Chào " + Login.DisplayName + "!\nChúc bạn một ngày tốt lành!");
        }

        // Hàm hiển thị thông tin lên dtgv
        void ShowInfo()
        {
            DataTable data = GetInfo(cbbNewsType.Text);
            dtgvInfo.DataSource = data;
            dtgvInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvInfo.AllowUserToResizeRows = false;
        }

        // Hàm load danh sách loại tin
        void LoadListNewsType()
        {
            cbbNewsType.Items.Clear();
            List<NewsType> customerList = LoadNewsType();
            foreach (var item in customerList)
            {
                cbbNewsType.Items.Add(item.NewsType1);
            }
            cbbNewsType.SelectedIndex = 0;
        }

        // Hàm truy vấn
        public List<NewsType> LoadNewsType()
        {
            List<NewsType> newsTypeList = new List<NewsType>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM the_loai");

            foreach (DataRow item in data.Rows)
            {
                NewsType newsType = new NewsType(item);
                newsTypeList.Add(newsType);
            }

            return newsTypeList;
        }

        // Lấy nội dung trang web
        public string GetWebContent(string strLink)
        {
            string strContent = "";
            try
            {
                WebRequest objWebRequest = WebRequest.Create(strLink);
                objWebRequest.Credentials = CredentialCache.DefaultCredentials;
                WebResponse objWebResponse = objWebRequest.GetResponse();
                Stream receiveStream = objWebResponse.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, System.Text.Encoding.UTF8);
                strContent = readStream.ReadToEnd();
                objWebResponse.Close();
                readStream.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return strContent;
        }

        // Lấy nội dung bài viết sử dụng Regex
        public string GetContent(string Content)
        {
            string result = "";
            string pattern = @"<p.*?>(.*?)<\/p>";
            foreach (Match m in Regex.Matches(Content, pattern))
            {
                result = result + m.Value;
            }

            result = DelTag(result);
            return result;
        }

        // Xóa các tag
        public string DelTag(string Strfix)
        {
            // Xuống dòng
            while (Strfix.Contains(@"</p>"))
            {
                Strfix = Strfix.Replace(@"</p>", "\n");
            }

            // Loại bỏ các tag còn lại
            string pattern = @"<.*?>";
            foreach (Match m in Regex.Matches(Strfix, pattern))
            {
                Strfix = Strfix.Replace(m.Value, "");
            }

            return Strfix;
        }

        // Lấy dữ liệu
        public void UpdateInfo(string url, string table)
        {
            DataProvider.Instance.ExecuteNonQuery("delete from " + table);

            // URL RSS
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            int i = 0;
            int sum = feed.Items.Count();
            foreach (SyndicationItem item in feed.Items)
            {
                String subject = item.Title.Text.Replace("'","");
                String summary = item.Summary.Text.Substring(item.Summary.Text.LastIndexOf("</br>") + 5).Replace("'","");
                String link = item.Id.ToString();
                string content = GetWebContent(link);
                String detail = GetContent(content).Replace("'", "");
                i++;
                DataProvider.Instance.ExecuteNonQuery("INSERT INTO " + table + " (id,title,summary,link,detail) VALUES(" + i + ",N'" + subject + "', N'" + summary + "','" + link + "', N'" + detail + "')");
            }
        }

        // Lấy dữ liệu theo loại tin
        public DataTable GetInfo(string table)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT title as [Tiêu đề], summary as [Tóm tắt], link as [Link], detail as [Nội dung] FROM " + table);
        }

        private void dtgvInfo_SelectionChanged(object sender, EventArgs e)
        {
            txtTitle.Text = dtgvInfo.Rows[dtgvInfo.CurrentRow.Index].Cells[0].Value.ToString();
            txtSummary.Text = dtgvInfo.Rows[dtgvInfo.CurrentRow.Index].Cells[1].Value.ToString();
            txtLink.Text = dtgvInfo.Rows[dtgvInfo.CurrentRow.Index].Cells[2].Value.ToString();
            rtbDetail.Text=dtgvInfo.Rows[dtgvInfo.CurrentRow.Index].Cells[3].Value.ToString();
            // Truy xuất thẳng dữ liệu từ web
            //string Content = GetWebContent(txtLink.Text);
            //rtbDetail.Text = GetContent(Content);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfoByNewsType(cbbNewsType.Text);
        }

        // Update theo loại tin
        void UpdateInfoByNewsType(string newstype)
        {
            label5.Text = "Trạng thái: Đang cập nhật...";
            UpdateInfo("https://vnexpress.net/rss/" + newstype.Replace("_", "-") + ".rss", newstype);
            ShowInfo();
            MessageBox.Show("Đã thực hiện cập nhật!");
            label5.Text = "Trạng thái: Đã cập nhật!";
        }

        private void cbbNewsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void btnViewWeb_Click(object sender, EventArgs e)
        {
            Process.Start(txtLink.Text);
        }

        private void tsmiLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiPersonalInfo_Click(object sender, EventArgs e)
        {
            PersonalInfomationForm PIF = new PersonalInfomationForm();
            PIF.ShowDialog();
        }

        private void tsmiReport_Click(object sender, EventArgs e)
        {
            ReportForm RF = new ReportForm();
            RF.ShowDialog();
        }
    }
}
