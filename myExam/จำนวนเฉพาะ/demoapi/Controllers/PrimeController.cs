using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PrimeController : ControllerBase
    {
        [HttpGet]
        public string CheckPrime(int number)
        {
            //อยากใช้ class ไหนก็ใช้ชื่อ new ชื่อclass นั้นแล้วเก็บไว้ในตัวแปร
            var a = new PrimeLogic();
            var result = a.prime(number);
            return result;

            
        }
    }
}