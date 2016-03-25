using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BC.AppCloud.Entity.ApiCloud
{
    public class ApiItem
    {
        /// <summary>
        /// 接口-编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 接口-代码
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 功能-名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 功能-描述
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 接口-地址
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 接口-地址参数说明
        /// </summary>
        public string urlParam { get; set; }
        /// <summary>
        /// 第三方地址
        /// </summary>
        public string platformUrl { get; set; }
        /// <summary>
        /// 接口-调试地址
        /// </summary>
        public string debugUrl { get; set; }
        /// <summary>
        /// 接口-说明
        /// </summary>
        public string readMe { get; set; }
        /// <summary>
        /// 注意事项
        /// </summary>
        public string attention { get; set; }
        /// <summary>
        /// 调用示例
        /// </summary>
        public string demoJson { get; set; }
        /// <summary>
        /// 返回-示例数据
        /// </summary>
        public string backData { get; set; }
        /// <summary>
        /// 返回-参数说明
        /// </summary>
        public string backParam { get; set; }
        /// <summary>
        /// 开发者-api
        /// </summary>
        public string authorApi { get; set; }
    }

    public class PageListItem
    {
        /// <summary>
        /// 页面编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 效果图
        /// </summary>
        public string designSketch { get; set; }
        /// <summary>
        /// 开发者-页面
        /// </summary>
        public string authorPage { get; set; }
        /// <summary>
        /// 页面
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 示例-页面
        /// </summary>
        public string demoUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ApiItem> api { get; set; }
    }

    public class FunctionListItem
    {
        /// <summary>
        /// 功能编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PageListItem> pageList { get; set; }
    }

    public class ModuleListItem
    {
        /// <summary>
        /// 模块编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FunctionListItem> functionList { get; set; }
    }

    public class ProjectListItem
    {
        /// <summary>
        /// 项目编号
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ModuleListItem> moduleList { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 接口池
        /// </summary>
        public string apiCloud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ProjectListItem> projectList { get; set; }
    }
}