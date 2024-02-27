using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class RollDiceController : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string Get(int m, int n)
        {
            if (m <= 0 || n <= 0)
            {
                return "Invalid input. Please provide positive values for m and n.";
            }

            int count = Enumerable.Range(1, m).SelectMany(i => Enumerable.Range(1, n).Where(j => i + j == 10)).Count();

            return $"There are {count} total ways to get the sum 10";
        }
    }
}
