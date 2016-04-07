using BC.AppCloud.BLL.ApiCloud;
using BC.AppCloud.Entity.ApiCloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BC.ApiCloud.Web.Controllers.api
{
    public class ProjectController : ApiController
    {
        ApiCloud_ProjectListItemBLL bll = new ApiCloud_ProjectListItemBLL();

        // GET api/user
        [HttpGet]
        public IEnumerable<ApiCloud_ProjectListItem> Get()
        {
            return bll.GetQuery();
        }

        // GET api/user/5
        [HttpDelete]
        public bool Delete(int id)
        {
            var model = bll.GetEntityByID(id);
            if (model != null)
            {
                bll.Delete(model);
                return true;
            }
            return false;
        }

        [HttpPost]
        public bool Post(ApiCloud_ProjectListItem newModel)
        {
            newModel.CreateTime = DateTime.Now;
            newModel.UpdateTime = DateTime.Now;
            newModel.State = 0;
            var result = bll.Add(newModel);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // PUT api/user/5
        [HttpPut]
        public bool Put(ApiCloud_ProjectListItem newModel)
        {
            ApiCloud_ProjectListItem model = bll.Single(e => e.Id == newModel.Id);
            model.projectCode = newModel.projectCode;
            model.projectName = newModel.projectName;
            model.UpdateTime = DateTime.Now;
            var result = bll.Update(model);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
