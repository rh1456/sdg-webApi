using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExplosionApi.Controllers
{
  [ApiController]
  [Route ("api/[controller"]")]

public class ExplosionController : ControllerBase
  {
    [HttpGet("{numbers}")]
    public ActionResult<string> GetExplosion(numbers)
    {
      return string.Join
    }
  }
}