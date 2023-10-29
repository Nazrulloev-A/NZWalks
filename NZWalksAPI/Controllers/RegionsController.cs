using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalksAPI.Data;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Controllers;

// https://localhost:8888/api/regions
[Route("api/[controller]")]
[ApiController]
public class RegionsController : ControllerBase
{
    private readonly NZWalksDbContext dbContext;

    //GET ALL REGIONS 
    // https://localhost:8888/api/regions

    public RegionsController(NZWalksDbContext  dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
       var regions = dbContext.Regions.ToList();

        return Ok(regions);
    }
   

}
