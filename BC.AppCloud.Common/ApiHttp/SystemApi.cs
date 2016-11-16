//using System;
//using System.Text;
//using System.Net;
//using System.IO;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using Mvc_Common.ToolsHelper;

//namespace Mvc_Common.ApiHelper
//{
//    /// <summary>
//    /// 系统接口调用类
//    /// </summary>
//    public class SystemApi
//    {
//        #region 跨域访问（简单json）+PostSchoolJsonDatasign
//        /// <summary>
//        /// 学校接口跨域访问（简单Json）
//        /// </summary>
//        /// <param name="url">url地址</param>
//        /// <param name="param">接口附带参数Json列表</param>
//        /// <returns>返回连接学校接口返回的Json数据</returns>
//        protected static string PostSchoolJsonDatasign(string url, string param)
//        {
//            Uri address = new Uri(url);
//            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
//            request.Method = "POST";
//            request.ContentType = "application/json;charset=utf-8"; //"application/x-www-form-urlencoded";
//            request.Timeout = 60000;
//            byte[] byteData = UTF8Encoding.UTF8.GetBytes(param == null ? "" : param);
//            request.ContentLength = byteData.Length;
//            string Result = string.Empty;
//            HttpWebResponse respons = null;
//            request.KeepAlive = false;
//            try
//            {
//                request.Proxy = null;//服务器是否设置代理
//                using (Stream postStream = request.GetRequestStream())
//                {
//                    postStream.Write(byteData, 0, byteData.Length);
//                }
//                respons = (HttpWebResponse)request.GetResponse();
//            }
//            catch (WebException ex)
//            {
//                respons = (HttpWebResponse)ex.Response;
//            }
//            if (respons != null)
//            {
//                StreamReader reader = new StreamReader(respons.GetResponseStream());
//                Result = reader.ReadToEnd();
//            }
//            return Result;
//        }

//        #endregion

//        #region 根据传入的功能代码以及错误代码自动返回错误Json错误数据 +ErrorMes

//        /// <summary>
//        /// 根据传入的功能代码以及错误代码自动返回错误Json错误数据
//        /// </summary>
//        /// <param name="FunctionCode">功能代码</param>
//        /// <param name="ErrorCode">错误代码</param>
//        /// <returns></returns>
//        protected static string ErrorMes(string FunctionCode, object ErrorMes)
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append(@"{""status"":" + FunctionCode + "" + "0" +
//                      ((Error)Enum.Parse(typeof(Error), ErrorMes.ToString())).GetHashCode() + ",");
//            sb.Append(@"""msg"":""" + ErrorMes + @"""}");
//            return sb.ToString();
//        }

//        #endregion

//        /// <summary>
//        /// 系统接口跨域访问（简单Json）
//        /// </summary>
//        /// <param name="url">url地址</param>
//        /// <param name="param">接口附带参数Json列表</param>
//        /// <returns>返回连接学校接口返回的Json数据</returns>
//        protected static string PostSystemJsonDatasign(string FunctionCode, string param)
//        {
//            string Result = string.Empty;
//            JObject JpostData = (JObject)JsonConvert.DeserializeObject(param);
//            int InterfaceNumber = Int32.Parse(FunctionCode);
//            string CallInterfaceUser = JpostData["UserName"].ToString();
//            string CallInterfaceOrg = JpostData["SchoolNumber"].ToString();
//            DateTime IdeaDate = Convert.ToDateTime(JpostData["CollectDate"].ToString());
//            string CollectIdeaContent = JpostData["CollectIdeaContent"].ToString();
//            if (1 == 1)
//            {
//                Result = @"{
//    ""status"": 9010101,
//    ""msg"": ""意见反馈成功，谢谢您的添砖加瓦！""
//}";
//            }
//            else
//            {
//                Result = @"{
//    ""status"": 9010102,
//    ""msg"": ""反馈失败，请稍后再试！""
//}";
//            }
//            return Result;
//        }     


//        /// <summary>
//        /// 对学校接口返回的数据进行处理
//        /// </summary>
//        /// <param name="FunctionCode">功能点代码（由5为组成，前3为功能代码，后2为十位流水号）</param>
//        /// <param name="AppData">所有带入接口的参数集合，格式为累加所有的参数字符串</param>
//        /// <param name="SchoolNumber">学校代码</param>
//        /// <param name="UserName">登录用户名</param>
//        /// <param name="PutSchoolData">带入学校接口的Json参数列表</param>
//        /// <returns>返回学校接口程序处理后的Json字符串</returns>
//        public static string DisPoseResult(string FunctionCode, string AppData, string SchoolNumber, string UserName, string PutSchoolData)
//        {
//            //变量
//            string returnData = ErrorMes(FunctionCode, Error.数据加载失败);

//            //检查数据合法性
//            if (Tools.IsValidInput(ref AppData, true) == false)
//            {
//                returnData = ErrorMes(FunctionCode, Error.app发回的数据不合法);
//            }
//            else
//            {
//                //根据学校编码和功能点编码获取学校相同功能的接口地址
//                string GetSchoolInte = SchoolApiUrl.GetSchoolInterface(SchoolNumber, FunctionCode);
//                if (string.IsNullOrEmpty(GetSchoolInte))
//                {
//                    returnData = ErrorMes(FunctionCode, Error.学校代号或信息API错误);
//                }
//                else
//                {
//                    //跨域访问学校接口数据，并返回结果
//                    string postData = PostSchoolJsonDatasign(GetSchoolInte, PutSchoolData);
//                    if (postData == string.Empty)
//                    {
//                        returnData = ErrorMes(FunctionCode, Error.学校服务器网络错误);
//                    }
//                    else if (Tools.IsValidInput(ref postData, true) == false)
//                    {
//                        returnData = ErrorMes(FunctionCode, Error.学校平台返回的数据不合法);
//                    }
//                    else
//                    {
//                        JObject JpostData = new JObject();
//                        try
//                        {
//                            //对学校返回数据进行处理
//                             JpostData = (JObject)JsonConvert.DeserializeObject(postData);
//                        }
//                        catch
//                        {
//                            BC.CommonConfig.LogUtil.WriteLogFile(postData, "#SchoolError.log");
//                        }

//                        //根据学校返回错误代码重新定义错误信息
//                        string status = JpostData["status"].ToString();
//                        if (status == FunctionCode + "01")//需要将status 改为1010001
//                        {
//                            //插入数据库
                            
//                            returnData = postData;
//                        }
//                        else if (status == FunctionCode + "02")//需要将status 改为1010002
//                        {
//                            //不成功，需要将学校接口不成功的提示输出到APP端
//                            returnData = postData;
//                        }
//                        else if (status == FunctionCode + "05")
//                        {
//                            returnData = postData;
//                        }
//                        else if (status == FunctionCode + "06")
//                        {
//                            returnData = ErrorMes(FunctionCode, Error.请求数据错误);
//                        }
//                        else if (status == FunctionCode + "07")
//                        {
//                            returnData = ErrorMes(FunctionCode, Error.请求数据含有危险字符);
//                        }
//                    }
//                    //returnData = postData;
//                }
//            }

//            //写入日志
//            //JObject JpData = (JObject)JsonConvert.DeserializeObject(returnData);
//            //string StateCode = JpData["status"].ToString();
//            //WriteLog(int.Parse(FunctionCode), UserName, SchoolNumber, StateCode);


//            //写入缓存
//            //判断缓存中的临时表是否存在

//            //if (Cache["Data"] == null)
//            //{
//            //    //不存在则新建临时表Table,用来存放日志信息
//            //    DataTable dt = new DataTable();
//            //    DataColumn dcFCode = new DataColumn("FunctionCode", Type.GetType("System.Int32"));
//            //    DataColumn dcUName = new DataColumn("UserName", Type.GetType("System.String"));
//            //}


//            return returnData;
//        }

//        /// <summary>
//        /// 对系统接口数据进行处理
//        /// </summary>
//        /// <param name="FunctionCode">功能点代码（由5为组成，前3为功能代码，后2为十位流水号）</param>
//        /// <param name="AppData">所有带入接口的参数集合，格式为累加所有的参数字符串</param>
//        /// <param name="SchoolNumber">学校代码</param>
//        /// <param name="UserName">登录用户名</param>
//        /// <param name="PutSchoolData">带入Json参数列表</param>
//        /// <returns>返回系统接口程序处理后的Json字符串</returns>
//        public static string SystemDisPoseResult(string FunctionCode, string AppData, string SchoolNumber, string UserName, string PutSchoolData)
//        {
//            //变量
//            string returnData = ErrorMes(FunctionCode, Error.数据加载失败);

//            //检查数据合法性
//            if (Tools.IsValidInput(ref AppData, true) == false)
//            {
//                returnData = ErrorMes(FunctionCode, Error.app发回的数据不合法);
//            }
//            else
//            {

//                //跨域访问学校接口数据，并返回结果
//                string postData = PostSystemJsonDatasign(FunctionCode, PutSchoolData);

//                //对学校返回数据进行处理
//                JObject JpostData = (JObject)JsonConvert.DeserializeObject(postData);
//                //根据学校返回错误代码重新定义错误信息
//                string status = JpostData["status"].ToString();
//                if (status == FunctionCode + "01")//需要将status 改为1010001
//                {
//                    returnData = postData;
//                }
//                else if (status == FunctionCode + "02")//需要将status 改为1010002
//                {
//                    //不成功，需要将学校接口不成功的提示输出到APP端
//                    returnData = postData;
//                }
//                else if (status == FunctionCode + "05")
//                {
//                    returnData = postData;
//                }
//                else if (status == FunctionCode + "06")
//                {
//                    returnData = ErrorMes(FunctionCode, Error.请求数据错误);
//                }
//                else if (status == FunctionCode + "07")
//                {
//                    returnData = ErrorMes(FunctionCode, Error.请求数据含有危险字符);
//                }
//                returnData = postData;
//            }

//            //写入日志
//            JObject JpData = (JObject)JsonConvert.DeserializeObject(returnData);
//            string StateCode = JpData["status"].ToString();
//            //WriteLog(int.Parse(FunctionCode), UserName, SchoolNumber, StateCode);


//            //写入缓存
//            //判断缓存中的临时表是否存在

//            //if (Cache["Data"] == null)
//            //{
//            //    //不存在则新建临时表Table,用来存放日志信息
//            //    DataTable dt = new DataTable();
//            //    DataColumn dcFCode = new DataColumn("FunctionCode", Type.GetType("System.Int32"));
//            //    DataColumn dcUName = new DataColumn("UserName", Type.GetType("System.String"));
//            //}


//            return returnData;
//        }

//    }
//}
