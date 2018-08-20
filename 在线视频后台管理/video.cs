using System;
using System.Collections;
using System.Text;
using PengeSoft.Data;

namespace OnlineVideoManager
{
    /// <summary>
    /// videoRecRec 的摘要说明。
    /// </summary>
    public class videoRec : DataPacket
    {
        #region 私有字段

        private string _VideoUrl;      // 视频链接
        private string _VideoName;      // 视频名称
        private DateTime _CreateDate;      // 创建日期
        private DateTime _UploadDate;      // 上传日期
        private string _Author;      // 作者
        private string _Major;      // 所属专业
        private string _Keyword;      // 关键字
        private string _VideoType;      // 类型

        #endregion

        #region 属性定义

        /// <summary>
        /// 视频链接 
        /// </summary>
        public string VideoUrl { get { return _VideoUrl; } set { _VideoUrl = value; } }
        /// <summary>
        /// 视频名称 
        /// </summary>
        public string VideoName { get { return _VideoName; } set { _VideoName = value; } }
        /// <summary>
        /// 创建日期 
        /// </summary>
        public DateTime CreateDate { get { return _CreateDate; } set { _CreateDate = value; } }
        /// <summary>
        /// 上传日期 
        /// </summary>
        public DateTime UploadDate { get { return _UploadDate; } set { _UploadDate = value; } }
        /// <summary>
        /// 作者 
        /// </summary>
        public string Author { get { return _Author; } set { _Author = value; } }
        /// <summary>
        /// 所属专业 
        /// </summary>
        public string Major { get { return _Major; } set { _Major = value; } }
        /// <summary>
        /// 关键字 
        /// </summary>
        public string Keyword { get { return _Keyword; } set { _Keyword = value; } }
        /// <summary>
        /// 类型 
        /// </summary>
        public string VideoType { get { return _VideoType; } set { _VideoType = value; } }

        #endregion

        #region 重载公共函数

        /// <summary>
        /// 清除所有数据。
        /// </summary>
        public override void Clear()
        {
            base.Clear();

            _VideoUrl = null;
            _VideoName = null;
            _CreateDate = DateTime.MinValue;
            _UploadDate = DateTime.MinValue;
            _Author = null;
            _Major = null;
            _Keyword = null;
            _VideoType = null;
        }

        /// <summary>
        /// 用指定节点序列化整个数据对象。
        /// </summary>
        /// <param name="node">用于序列化的 XmlNode 节点。</param>
        public override void XMLEncode(System.Xml.XmlNode node)
        {
            base.XMLEncode(node);

            WriteXMLValue(node, "VideoUrl", _VideoUrl);
            WriteXMLValue(node, "VideoName", _VideoName);
            WriteXMLValue(node, "CreateDate", _CreateDate);
            WriteXMLValue(node, "UploadDate", _UploadDate);
            WriteXMLValue(node, "Author", _Author);
            WriteXMLValue(node, "Major", _Major);
            WriteXMLValue(node, "Keyword", _Keyword);
            WriteXMLValue(node, "VideoType", _VideoType);
        }

        /// <summary>
        /// 用指定节点反序列化整个数据对象。
        /// </summary>
        /// <param name="node">用于反序列化的 XmlNode 节点。</param>
        public override void XMLDecode(System.Xml.XmlNode node)
        {
            base.XMLDecode(node);

            ReadXMLValue(node, "VideoUrl", ref _VideoUrl);
            ReadXMLValue(node, "VideoName", ref _VideoName);
            ReadXMLValue(node, "CreateDate", ref _CreateDate);
            ReadXMLValue(node, "UploadDate", ref _UploadDate);
            ReadXMLValue(node, "Author", ref _Author);
            ReadXMLValue(node, "Major", ref _Major);
            ReadXMLValue(node, "Keyword", ref _Keyword);
            ReadXMLValue(node, "VideoType", ref _VideoType);
        }

        /// <summary>
        /// 复制数据对象
        /// </summary>
        /// <param name="sou">源对象,需从DataPacket继承</param>
        public override void AssignFrom(DataPacket sou)
        {
            base.AssignFrom(sou);

            videoRec s = sou as videoRec;
            if (s != null)
            {
                _VideoUrl = s._VideoUrl;
                _VideoName = s._VideoName;
                _CreateDate = s._CreateDate;
                _UploadDate = s._UploadDate;
                _Author = s._Author;
                _Major = s._Major;
                _Keyword = s._Keyword;
                _VideoType = s._VideoType;
            }
        }

        #endregion
    }
}