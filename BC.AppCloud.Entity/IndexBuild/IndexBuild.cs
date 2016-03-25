using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BC.AppCloud.Entity.IndexBuild
{
    public class Frame
    {
        /// <summary>
        /// 
        /// </summary>
        public string url_template { get; set; }
    }

    public class Header
    {
        /// <summary>
        /// 页头
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Frame frame { get; set; }
    }

    public class ContentItem
    {
        /// <summary>
        /// 天气预报
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Frame frame { get; set; }
    }

    public class Footer
    {
        /// <summary>
        /// 页脚_底部导航
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Frame frame { get; set; }
    }

    public class Theme_A
    {
        /// <summary>
        /// 
        /// </summary>
        public Header header { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ContentItem> content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Footer footer { get; set; }
    }

    public class Theme_B
    {
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public Theme_A theme_A { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Theme_B theme_B { get; set; }
    }
}