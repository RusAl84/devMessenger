using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleASP.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NikitaController : ControllerBase
  {
    // GET: api/<NikitaController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Ёжик  сьел Никиту" };
    }

    // GET api/<NikitaController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "Никита получил " +id.ToString()+ " раз оценку отлично";
    }

    // POST api/<NikitaController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<NikitaController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<NikitaController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
