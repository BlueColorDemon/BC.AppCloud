using BC.AppCloud.DAL;
using BC.AppCloud.Entity.AppCloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.AppCloud.BLL.AppCloud
{
    public partial class AppCloud_OrgGroupItemBLL : BaseBLL<AppCloud_OrgGroupItem>
    {
        private readonly BaseDAL<AppCloud_OrgGroupItem> _AppCloud_OrgGroupItemDal;
        public AppCloud_OrgGroupItemBLL()
            : base()
        {
            _AppCloud_OrgGroupItemDal = base.Dal;
        }
    }
}
    