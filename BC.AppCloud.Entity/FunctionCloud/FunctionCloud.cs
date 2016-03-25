using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BC.AppCloud.Entity.FunctionCloud
{
    public class Baseframe
    {
    }

    public class Init
    {
    }

    public class ListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Init init { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isSingle { get; set; }
    }

    public class StartPage
    {
        /// <summary>
        /// 启动页
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Login
    {
        /// <summary>
        /// 登录
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Index
    {
        /// <summary>
        /// 首页
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class About
    {
        /// <summary>
        /// 关于
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Update
    {
        /// <summary>
        /// 更新
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Contacts
    {
        /// <summary>
        /// 通讯录
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Notice
    {
        /// <summary>
        /// 通知公告
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class News
    {
        /// <summary>
        /// 新闻中心
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class TimeTable
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Salary
    {
        /// <summary>
        /// 工资
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class OnlineSurvey
    {
        /// <summary>
        /// 在线调查
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class ToDo
    {
        /// <summary>
        /// 待办事项
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Mail
    {
        /// <summary>
        /// 站内信
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class WorkPlan
    {
        /// <summary>
        /// 工作计划
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Log
    {
        /// <summary>
        /// 工作日志
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Sign
    {
        /// <summary>
        /// 签到（是否需要自动签到）
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class YunFile
    {
        /// <summary>
        /// 云盘
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Workflow
    {
        /// <summary>
        /// 审批
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    
    public class TelMeeting
    {
        /// <summary>
        /// 电话会议
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class CustomerInfo
    {
        /// <summary>
        /// 客户信息
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class VisitPlan
    {
        /// <summary>
        /// 拜访计划
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Chat
    {
        /// <summary>
        /// 聊天
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }
    

    public class Message
    {
        /// <summary>
        /// 消息
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> list { get; set; }
    }

    public class CustomGroup
    {
        /// <summary>
        /// 
        /// </summary>
        public StartPage startPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Login login { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Index index { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public About about { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Update update { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Contacts contacts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Notice notice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public News news { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TimeTable timeTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Salary salary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OnlineSurvey onlineSurvey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ToDo toDo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mail mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public WorkPlan workPlan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Log log { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Sign sign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public YunFile yunFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Workflow workflow { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TelMeeting telMeeting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CustomerInfo customerInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public VisitPlan visitPlan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Chat chat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Message message { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 功能池
        /// </summary>
        public string functionCloud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Baseframe baseframe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CustomGroup customGroup { get; set; }
    }
}