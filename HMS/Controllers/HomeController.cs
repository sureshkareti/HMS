using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMS.Controllers
{
    public class HomeController : ApiController
    {
        // GET api/values/5  
        public string Get(int id)
        {
            return "id";
        }
    }
}
