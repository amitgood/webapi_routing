using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapi_routing.Controllers
{
    [RoutePrefix("api/v{version}")]
    public class TestController : ApiController
    {
        [Route("item/price")]
        [HttpGet]
        public int GetItemprice(int itemId)
        {
            return 30;
        }
        [Route("item")]
        [HttpGet]
        public string GetItemdescription(int itemId, int version)
        {
            return "item v1";
        }
        [Route("~/api/v2/item")]
        [HttpGet]
        public string GetItemdescription1(int itemId)
        {
            return "item v2" ;
        }
        [Route("~/api/v3/item")]
        [HttpGet]
        public string GetItemdescription2(int itemno, int version)
        {
            return "item v3";
        }

    }
}
