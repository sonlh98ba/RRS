using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader
{
    class DataProvider
    {
        // Singleton Design Pattern
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        private string conSTR = @"Data Source=DESKTOP-D4NNJNI;Initial Catalog=RSS;Integrated Security=True";

        // Truy vấn bằng Query và Trả ra 1 DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(conSTR))
            {
                connection.Open(); // Mở kết nối đến csdl

                SqlCommand command = new SqlCommand(query, connection); // Câu truy vấn vào csdl kèm theo kết nối

                SqlDataAdapter adapter = new SqlDataAdapter(command); // Trung gian lấy dữ liệu

                adapter.Fill(data); // Đổ dữ liệu vào Datatable

                connection.Close();
            }

            return data;
        }

        // Truy vấn trả ra số dòng thành công
        public int ExecuteNonQuery(string query)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(conSTR))
            {
                connection.Open(); // Mở kết nối đến csdl

                SqlCommand command = new SqlCommand(query, connection); // Câu truy vấn vào csdl kèm theo kết nối

                result = command.ExecuteNonQuery(); // Đếm số dòng thành công

                connection.Close();
            }

            return result;
        }

        // Truy vấn trả ra hàm count
        public object ExecuteScalar(string query)
        {
            object result = 0;

            using (SqlConnection connection = new SqlConnection(conSTR))
            {
                connection.Open(); // Mở kết nối đến csdl

                SqlCommand command = new SqlCommand(query, connection); // Câu truy vấn vào csdl kèm theo kết nối

                result = command.ExecuteScalar(); // Trả ra kết quả ô đầu tiên trong bảng (phù hợp để count)

                connection.Close();
            }

            return result;
        }
    }
}
