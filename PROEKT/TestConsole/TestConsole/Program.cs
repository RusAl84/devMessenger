using System;

namespace TestConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      MessangerLib.MessageClass mes = new MessangerLib.MessageClass();
      mes.userName = "Rusakov";
      mes.messageText = "Пример сообщения";
      mes.timeStamp = DateTime.Now.ToString();
      Console.WriteLine(mes);
    }
  }
}
