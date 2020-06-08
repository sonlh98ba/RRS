using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader
{
    public class NewsType
    {
        // Ý tưởng muốn get thông tin qua Singleton design partern với 1 thể hiện duy nhất tại 1 thời điểm
        public NewsType(string id, string name, string newsType)
        {
            this.ID = id;
            this.Name = name;
            this.NewsType1 = newsType;
        }
        private string id;
        private string name;
        private string newsType;

        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string NewsType1 { get => newsType; set => newsType = value; }


        public NewsType(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.Name = row["NAME"].ToString();
            this.NewsType1 = row["NEWSTYPE"].ToString();
        }
    }
}
