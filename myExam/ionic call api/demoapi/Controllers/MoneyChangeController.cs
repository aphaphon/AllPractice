using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyChangeController : ControllerBase
    {
        [HttpGet("{totalMoney}/{price}")]
        public CalculationResult Change(double totalMoney, double price)
        {
            var logic = new ChangeLogic();
            var r = logic.Change(totalMoney, price);

            var x = new CalculationResult();
            x.Result = r;

            return x;
        }


        [HttpPost]
        public CalculationResult Change([FromBody]ChangeInput data)
        {
            var logic = new ChangeLogic();
            var r = logic.Change(data.TotalMoney, data.Price);

            var x = new CalculationResult();
            x.Result = r;

            return x;
        }
    }
}
