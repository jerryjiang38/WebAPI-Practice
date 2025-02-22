using System.Net;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;
//7-目標：回傳HttpStatusCode
[Route("[controller]/[action]")]
public class StatusController: ControllerBase
{
    public string Get1(string status) //在/Status/Get1?status=OK
    {
        Response.StatusCode = (int)HttpStatusCode.BadRequest;
        return status;
    }
    public IActionResult Get2(string status) //在/Status/Get2?status=OK
    {
        return Ok(status); //200
        return Created("url", status); //201
        return Unauthorized("Please login"); //401
        return BadRequest(status); //400
    }
}