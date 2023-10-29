using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Controllers;

// https://localhost:8888/api/regions
[Route("api/[controller]")]
[ApiController]
public class RegionsController : ControllerBase
{
    //GET ALL REGIONS 
    // https://localhost:8888/api/regions

    [HttpGet]
    public IActionResult GetAll()
    {

        var regions = new List<Region>
        {
            new Region
            {
                Id = Guid.NewGuid(),
                Name = "Auckland Region",
                Code = "AKL",
                RegionalmageUrl ="https://www.pexels.com/photo/sky-tower-in-auckland-831910/"

            },

              new Region
            {
                Id = Guid.NewGuid(),
                Name = "Wellington Region",
                Code = "WLG",
                RegionalmageUrl ="https://www.pexels.com/photo/wellington-sunset-18062809/"

            },

        };

        return Ok(regions);
    }
   

}
