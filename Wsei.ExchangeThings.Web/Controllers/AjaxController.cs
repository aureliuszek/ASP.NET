using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.ExchangeThings.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wsei.ExchangeThings.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AjaxController : ControllerBase
    {
        public AjaxResult Post()
        {
            var res = new AjaxResult();
            res.success = true;

            return res;
        }

    }



}
