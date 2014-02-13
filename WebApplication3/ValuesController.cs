using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3
{
    public class ValuesController:ApiController
    {
        [HttpGet]
        public string GetString()
        {
            return "i am from api";
        }
    }
}