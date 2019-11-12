using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ChargeTestController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public string GetCharging()
        {
            //File.AppendAllLines("",new []{"1234","asd"});
            return "success1";
        }
//        [HttpGet]
//        public string GetCharging()
//        {
//            //File.AppendAllLines("",new []{"1234","asd"});
//            return "success1";
//        }
    }
}