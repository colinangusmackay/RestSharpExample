using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestSharpExample.Server.Controllers
{
    public class ValuesOkController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get(int count)
        {
            var result = Request.CreateResponse(HttpStatusCode.OK, Values.GetValues(count));
            return result;
        }

    }
}