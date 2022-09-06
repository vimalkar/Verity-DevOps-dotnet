using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sample_ui_pipeline_v1.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sample_ui_pipeline_v1.API
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestEndpointController : ControllerBase
	{
		// GET: api/<TestEndpointController>

		private readonly TestService _testService;

		public TestEndpointController(TestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
		public IEnumerable<string> Get()
		{

			return _testService.Get();
		}

		// GET api/<TestEndpointController>/5
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]

		public async Task<ActionResult> Get(int id)
		{
			/** Success Case */
			var result = _testService.GetById(id);
			return Ok(new { result });

			/*Failure Case */

			/*
			var result = _testService.GetById(id);
			return Ok(result);
			*/

		}

		// POST api/<TestEndpointController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<TestEndpointController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<TestEndpointController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
