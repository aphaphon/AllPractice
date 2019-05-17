using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FitBuzzController : ControllerBase
    {
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var obj = new FitBuzzLogic();
            return obj.Calculate(id);
        }
    }
}
