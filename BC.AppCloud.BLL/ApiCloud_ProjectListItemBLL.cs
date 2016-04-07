using BC.AppCloud.DAL;
using BC.AppCloud.Entity.ApiCloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.AppCloud.BLL.ApiCloud
{
    public partial class ApiCloud_ProjectListItemBLL : BaseBLL<ApiCloud_ProjectListItem>
    {
        private readonly BaseDAL<ApiCloud_ProjectListItem> _ApiCloud_ProjectListItemDal;
        public ApiCloud_ProjectListItemBLL()
            : base()
        {
            _ApiCloud_ProjectListItemDal = base.Dal;
        }
    }
}
    