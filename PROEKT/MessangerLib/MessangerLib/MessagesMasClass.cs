using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerLib
{
  public class MessagesMasClass
  {
    public List<MessageClass> data = new List<MessageClass>();
    public MessagesMasClass()
    {
      MessageClass mes = new MessageClass();
      mes.userName = "System";
      mes.messageText = "Server is running...";
      mes.timeStamp = DateTime.Now.ToString();
      //mes.timeStamp = DateTime.Now.ToString("HH:MM:SS");
      data.Add(mes);
    }
    public string GetMessage(int pos)
    {
      if ((pos >= 0) && (pos < data.Count))
      {
        return JsonConvert.SerializeObject(data[pos]);
      }
      else
        return "Not found";
    }
    public void AddMessage(MessageClass mes)
    {
      data.Add(mes);
    }

  }
}
