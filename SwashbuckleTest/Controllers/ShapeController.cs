using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwashbuckleTest.Model;

namespace SwashbuckleTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public ActionResult<Shape> GetShape()
        {
            return Ok(new Circle() { Sides = 1, Radius = 2 }); 
        }
    }
}
