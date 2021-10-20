using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerASPCORE
{
  [Route("api/[controller]")]
  [ApiController]
  public class SendMessage : ControllerBase
  {
    // POST api/<SendMessage>
    [HttpPost]
    public void Post([FromBody] MessangerLib.MessageClass mes)
    {
      Console.WriteLine(mes);
      Program.listOfMessages.AddMessage(mes);
    }

  }
}
