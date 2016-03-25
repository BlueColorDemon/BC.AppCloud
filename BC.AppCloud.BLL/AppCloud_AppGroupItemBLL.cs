using BC.AppCloud.DAL;
using BC.AppCloud.Entity.AppCloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.AppCloud.BLL.AppCloud
{
    public partial class AppCloud_AppGroupItemBLL : BaseBLL<AppCloud_AppGroupItem>
    {
        private readonly BaseDAL<AppCloud_AppGroupItem> _AppCloud_AppGroupItemDal;
        public AppCloud_AppGroupItemBLL()
            : base()
        {
            _AppCloud_AppGroupItemDal = base.Dal;
        }
    }
}
    