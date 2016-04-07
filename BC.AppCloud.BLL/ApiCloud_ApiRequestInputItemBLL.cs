

using BC.AppCloud.DAL;
using BC.AppCloud.Entity.ApiCloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.AppCloud.BLL.ApiCloud
{
    public partial class ApiCloud_ApiRequestInputItemBLL : BaseBLL<ApiCloud_ApiRequestInputItem>
    {
        private readonly BaseDAL<ApiCloud_ApiRequestInputItem> _ApiCloud_ApiRequestInputItemDal;
        public ApiCloud_ApiRequestInputItemBLL()
            : base()
        {
            _ApiCloud_ApiRequestInputItemDal = base.Dal;
        }
    }
}
    