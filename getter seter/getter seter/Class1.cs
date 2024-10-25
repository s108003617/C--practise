using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter_seter
{
    
        class Video
        {
            public string title; 
            public string author;
            private string type;
            public static int video_count = 0;
            //限制4個類型 標題,其他,文字,音樂




            public Video(string title, string author, string type)
            {
                this.title = title;
                this.author = author;
                Type = type;
                video_count++;
            }

        public int getVideoCount()
        {
            return video_count;
        }
        public string Type
        {
            get { return type; } //回傳type屬性
            set {
                if(value== "教育" || value == "其他" || value == "文字"|| value == "音樂")
                {
                    type = value;
                }
                else
                {
                    type = "其他";
                }
                    
            } //設定type值
        }
        }
 
}
//public 可以在任何地方存取
//private 限制以下存取