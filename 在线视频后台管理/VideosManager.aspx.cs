using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OnlineVideoManager
{
    public class FileManager
    {
        #region 此类为单例模式
        private static FileManager Manager;
        private static object locker = new object();
        public static FileManager GetInstance()
        {
            if (null ==  Manager)
            {
                lock (locker)
                {
                    if (null == Manager)
                    {
                        Manager = new FileManager();
                    }
                }
            }
            return Manager;
        }
        #endregion
        private List<videoRec> _videoList = null;
        public List<videoRec> VideoList { get => _videoList; set => _videoList = value; }

        private FileManager()
        {
            _videoList = new List<videoRec>();
        }

        public void clear()
        {
            _videoList.Clear();
        }

        public void AddVideos(string Urls, string Author, string Major, string KeyWord, string VideoType)
        {           
            string[] stringArry = Urls.Split(new string[]{"\r\n"},StringSplitOptions.None);
            foreach(string url in stringArry)
            { 
                videoRec video = new videoRec();
                _videoList.Add(video);
                video.VideoUrl = url;
                video.VideoName = Path.GetFileNameWithoutExtension(url);
                FileInfo fiInf = new FileInfo(url);
                video.CreateDate = fiInf.CreationTime;
                video.UploadDate = DateTime.Now;
                video.Author = Author;
                video.Major = Major;
                video.Keyword = KeyWord;
                video.VideoType = VideoType;
            }
        }

        public void SaveToJson()
        {
            if (null != VideoList)
            {
                string str = JsonConvert.SerializeObject(VideoList);
            }
        }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFile_Click(object sender, EventArgs e)
        {
            //打开文件对话框
            OpenFileDialog file = new OpenFileDialog();            
            file.Filter = "视频文件 (*.MP4)|*.MP4|All files (*.*)|*.*";
            file.RestoreDirectory = true;            
            if (DialogResult.OK == file.ShowDialog())
            {                
                foreach (string url in file.FileNames)
                {
                    TxtVideoUrl.Text += url + "\r\n";                
                }                                     
            }
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            //  提交
            FileManager manager = FileManager.GetInstance();
            manager.AddVideos(TxtVideoUrl.Text, txtBoxAuthor.Text, ListBoxMajor.Text, TxtBoxKeyWord.Text, ListBoxVideoType.Text);
            manager.SaveToJson();
        }
    }
}