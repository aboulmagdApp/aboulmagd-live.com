using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class firstController : ControllerBase
    {
        public string Data(){
            return "welcome dotNet Core web API author aboulmagd data";
        }
    }
}