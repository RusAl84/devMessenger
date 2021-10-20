using MessangerLib;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWF
{
  public partial class Form1 : Form
  {
    public int pos = 0;


    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessangerLib.MessageClass mes = new MessangerLib.MessageClass();
      mes.userName = userNameTB.Text;
      mes.messageText = messageTextTB.Text;
      mes.timeStamp = DateTime.Now.ToString();
      var client = new RestClient("http://localhost:5000");
      var request = new RestRequest("/api/SendMessage", Method.POST);
      string jsonString = JsonConvert.SerializeObject(mes);
      request.AddJsonBody(jsonString);
      var res = client.Execute(request);

    }

    private void button2_Click(object sender, EventArgs e)
    {
      
    }

    public void UpdateLB()
    {
      string jsonString = "";
      while (jsonString != "\"Not found\"")
      {
        var client = new RestClient("http://localhost:5000");
        var request = new RestRequest("api/GetMessages/" + pos.ToString(), Method.GET);
        var res = client.Execute(request);
        if (res.IsSuccessful)
        {
          //MessageBox.Show($"Успех: {res.Content}");
          jsonString = res.Content;
          if (jsonString != "\"Not found\"")
          {
            jsonString = jsonString.Replace("\\", "");
            MessageClass mes = new MessageClass();
            string str1 = "";
            for (int i = 1; i < jsonString.Length - 1; i++)
              str1 += jsonString[i];
            mes = JsonConvert.DeserializeObject<MessageClass>(str1);
            listBox1.Items.Add(mes);
            pos++;
          }
        }
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      UpdateLB();
    }
  }
}
