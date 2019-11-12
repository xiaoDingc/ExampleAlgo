using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class loginController : ApiController
    {
        // GET: login
        [HttpGet]
        public string Index()
        {
            return "OK";
        }
         public string login()
        {
            return "OK";
        }
    }
}