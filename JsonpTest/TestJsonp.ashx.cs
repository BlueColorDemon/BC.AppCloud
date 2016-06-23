using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonpTest
{
    /// <summary>
    /// TestJsonp 的摘要说明
    /// </summary>
    public class TestJsonp : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/javascript";
            context.Response.Write("callback('Get成功');");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}