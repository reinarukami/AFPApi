using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFPApi.Function.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AFPApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
		// GET api/values
		[HttpGet]
		public ActionResult<string> GetAllFiles()
		{
			//Get All Files in blockchain
			FileContract.Test();

			//Validate filehash and get tampered Files

			return "string contract";
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			//Get File

			//Validate filehash 

			return "value";
		}

		// POST api/values
		[HttpPost]
		public bool AddFiles([FromBody] string value)
		{
		
			//Change bool status of add File
			bool status = true;

			return status;
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public bool EditFiles(int id, [FromBody] string value)
		{
			//Change bool status of edit File
			bool status = true;

			return status;
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public bool DeleteFiles(int id)
		{
			//Change bool status of delete File
			bool status = true;

			return status;
		}
	}
}
