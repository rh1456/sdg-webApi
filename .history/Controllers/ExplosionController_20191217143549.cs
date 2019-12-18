using System;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionApi.Controllers
{


  [ApiController]
  [Route("api/[controller")]


  public class ExplosionController : ControllerBase
  {


    public ActionResult TestLine()
    {
      return Ok(new { message = "Api stuff!" });
    }

  }

}