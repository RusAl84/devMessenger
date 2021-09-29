using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PashaController : ControllerBase
  {
    // GET: api/<PashaController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Pasha uehal v Kabul" };
    }

    // GET api/<PashaController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "Паша съел " + id + " ёжиков";
    }

    // POST api/<PashaController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<PashaController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<PashaController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
