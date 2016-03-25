using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BC.AppCloud.Entity.AppCloud
{
    public class AppCloud_Baseframe : BaseModel
    {
    }

    public class AppCloud_Config : BaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        public AppCloud_Baseframe baseframe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> custom { get; set; }
    }

    public class AppCloud_AppGroupItem : BaseModel
    {
        /// <summary>
        /// 行政app
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AppCloud_Config config { get; set; }
    }

    public class AppCloud_OrgGroupItem : BaseModel
    {
        /// <summary>
        /// 企业A
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AppCloud_AppGroupItem> appGroup { get; set; }
    }

    public class AppCloud_Root : BaseModel
    {
        /// <summary>
        /// App池
        /// </summary>
        public string appCloud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AppCloud_OrgGroupItem> orgGroup { get; set; }
    }
}