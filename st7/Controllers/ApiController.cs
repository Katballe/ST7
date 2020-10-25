using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using st7.Models;

namespace st7.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // GET: api/Api
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World!" };
        }

        [HttpGet("GetClass")]
        public TestClass GetClass()
        {
            TestClass testClass = new TestClass(1, "Martin");
            return testClass;
        }

        // GET: api/Api/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST: api/Api
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
         
        // update
        // PUT: api/Api/5
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
