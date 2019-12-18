using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExplosionApi.Controllers
{
  [ApiController]
  [Route ("api/[controller"]")]

public class ExplosionController : ControllerBase
  {
    [HttpGet("{number}")]
    public ActionResult<string> GetExplosion(string s)
    {

    }
  }
}