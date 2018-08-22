using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AFPApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {

			return "string member";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public bool Register([FromBody] string value)
        {
			//Change bool status of Register
			bool status = true;

			return status;

		}
		
        // PUT api/values/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] string value)
        {
			//Change bool status of edit Member
			bool status = true;

			return status;
		}

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
			//Change bool status of Deactivate Member
			bool status = true;

			return status;
		}
    }
}
