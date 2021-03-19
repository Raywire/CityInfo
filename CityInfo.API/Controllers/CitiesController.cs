using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")] // or [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        //[HttpGet("api/cities")]
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>() {
                new { id = 1, Name = "New York City" },
                new { id = 2, Name = "Nairobi" }
            });
        }
    }
}
