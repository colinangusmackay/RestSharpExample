using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestSharpExample.Server.Controllers
{
    public class ValuesFoundController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get(int count)
        {
            var result = Request.CreateResponse(HttpStatusCode.Found, Values.GetValues(count));
            return result;
        }


    }
}