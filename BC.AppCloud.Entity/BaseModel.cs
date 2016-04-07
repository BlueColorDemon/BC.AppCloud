using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BC.AppCloud.Entity
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public int State { get; set; }
    }
}