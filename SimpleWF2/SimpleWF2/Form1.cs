using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWF2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void trackBar1_TabIndexChanged(object sender, EventArgs e)
    {
      
    }

    private void trackBar1_LocationChanged(object sender, EventArgs e)
    {

    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
      progressBar2.Value = trackBar1.Value*10;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      int pValue = progressBar1.Value + (int)(progressBar2.Value / 10);
      if (pValue <= 100) { 
        progressBar1.Value = pValue;
        label1.Visible = false;
      }
      else
      {
        label1.Visible = true;
      }

    }

    private void button2_Click(object sender, EventArgs e)
    {
      progressBar1.Value = 0;
    }
  }
}
