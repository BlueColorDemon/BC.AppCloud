

using BC.AppCloud.DAL;
using BC.AppCloud.Entity.AppCloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.AppCloud.BLL.AppCloud
{
    public partial class AppCloud_BaseframeBLL : BaseBLL<AppCloud_Baseframe>
    {
        private readonly BaseDAL<AppCloud_Baseframe> _AppCloud_BaseframeDal;
        public AppCloud_BaseframeBLL()
            : base()
        {
            _AppCloud_BaseframeDal = base.Dal;
        }
    }
}
    