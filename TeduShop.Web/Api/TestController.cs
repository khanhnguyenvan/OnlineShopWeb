﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TeduShop.Web.Api
{
    public class TestController : ApiController
    {
        public string GetAPI()
        {
            return "Map";
        }
    }
}
