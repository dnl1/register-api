using Microsoft.AspNetCore.Mvc;
using System;

namespace Register.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentController : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Get()
        {
            return new
            {
                Environment.MachineName,
                OSVersion = Environment.OSVersion.VersionString
            };
        }
    }
}