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
    public class ApiItemController : ApiController
    {
        ApiCloud_ApiListItemBLL bll = new ApiCloud_ApiListItemBLL();

        // GET api/user
        [HttpGet]
        public IEnumerable<ApiCloud_ApiListItem> Get()
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
        public bool Post(ApiCloud_ApiListItem newModel)
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
        public bool Put(ApiCloud_ApiListItem newModel)
        {
            ApiCloud_ApiListItem model = bll.Single(e => e.Id == newModel.Id);
            model.apiCode = newModel.apiCode;
            model.apiName = newModel.apiName;
            model.apiDesc = newModel.apiDesc;
            model.apiInfo = newModel.apiInfo;
            model.apiUrl = newModel.apiUrl;
            model.apiRequestMethod = newModel.apiRequestMethod;
            //model.apiRequestInput = newModel.apiRequestInput;
            model.apiRequestSample = newModel.apiRequestSample;
            model.apiRequestRemarks = newModel.apiRequestRemarks;
            //model.apiResponseOutput = newModel.apiResponseOutput;
            model.apiResponseSample = newModel.apiResponseSample;
            model.apiResponseRemarks = newModel.apiResponseRemarks;
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
