using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BC.AppCloud.Entity.ApiCloud
{
    public class ApiCloud_ApiRequestInputItem : BaseModel
    {
        /// <summary>
        /// 排序号
        /// </summary>
        public string inputNo { get; set; }
        /// <summary>
        /// 参数名
        /// </summary>
        public string inputName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string inputDesc { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string inputType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inputRequired { get; set; }
        /// <summary>
        /// 参数位置
        /// </summary>
        public string inputPosition { get; set; }
        /// <summary>
        /// 范围
        /// </summary>
        public string inputRange { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        public string inputDefault { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string inputExplain { get; set; }
    }

    public class ApiCloud_ApiResponseOutputItem : BaseModel
    {
        /// <summary>
        /// 排序号
        /// </summary>
        public string outputNo { get; set; }
        /// <summary>
        /// 参数名
        /// </summary>
        public string outputName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string outputDesc { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string outputType { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string outputExplain { get; set; }
    }

    public class ApiCloud_ApiListItem : BaseModel
    {
        /// <summary>
        /// 接口-代码
        /// </summary>
        public string apiCode { get; set; }
        /// <summary>
        /// 接口-名称
        /// </summary>
        public string apiName { get; set; }
        /// <summary>
        /// 接口-描述
        /// </summary>
        public string apiDesc { get; set; }
        /// <summary>
        /// 接口-介绍
        /// </summary>
        public string apiInfo { get; set; }
        /// <summary>
        /// 接口-地址
        /// </summary>
        public string apiUrl { get; set; }
        /// <summary>
        /// 接口-请求方法
        /// </summary>
        public string apiRequestMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ApiCloud_ApiRequestInputItem> apiRequestInput { get; set; }
        /// <summary>
        /// 接口-请求示例
        /// </summary>
        public string apiRequestSample { get; set; }
        /// <summary>
        /// 接口-请求备注
        /// </summary>
        public string apiRequestRemarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ApiCloud_ApiResponseOutputItem> apiResponseOutput { get; set; }
        /// <summary>
        /// 接口-响应示例
        /// </summary>
        public string apiResponseSample { get; set; }
        /// <summary>
        /// 接口-响应备注
        /// </summary>
        public string apiResponseRemarks { get; set; }
    }

    public class ApiCloud_ProjectListItem : BaseModel
    {
        /// <summary>
        /// 项目代码
        /// </summary>
        public string projectCode { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string projectName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ApiCloud_ApiListItem> apiList { get; set; }
    }

    public class ApiCloud_Root : BaseModel
    {
        /// <summary>
        /// 接口池
        /// </summary>
        public string apiCloud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ApiCloud_ProjectListItem> projectList { get; set; }
    }
}