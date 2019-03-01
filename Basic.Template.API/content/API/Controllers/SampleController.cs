using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class SampleController : Controller
        {

            [HttpGet]
            [Route("")]
            [ProducesResponseType(200)]
            public IActionResult ExampleGet([FromQuery] List<string> portfolioPolicy)
            {
                return Ok();
            }
    }
}