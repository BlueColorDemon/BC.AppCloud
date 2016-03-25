using BC.AppCloud.DAL;
using BC.AppCloud.Entity.AppCloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.AppCloud.BLL.AppCloud
{
    public partial class AppCloud_ConfigBLL : BaseBLL<AppCloud_Config>
    {
        private readonly BaseDAL<AppCloud_Config> _AppCloud_ConfigDal;
        public AppCloud_ConfigBLL()
            : base()
        {
            _AppCloud_ConfigDal = base.Dal;
        }
    }
}
    