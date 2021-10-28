using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerGUI
{
  public partial class Form1 : Form
  {
    DateTime saveTime = new DateTime();

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      startButton.Visible = true;
      stopButton.Visible = false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {

      TimeSpan differenceTime = DateTime.Now.Subtract(saveTime);
      DateTime diffDateTime = Convert.ToDateTime(differenceTime.ToString());
      string str1 = textBox1.Text;
      DateTime timeInterval = DateTime.ParseExact(str1, "mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);

      TimeSpan outputTime = timeInterval.Subtract(diffDateTime);
      DateTime outputDateTime = Convert.ToDateTime(outputTime.ToString());

      label1.Text = outputDateTime.ToString("mm:ss");
      DateTime zeroTime = DateTime.ParseExact("00:01", "mm:ss",
                                 System.Globalization.CultureInfo.InvariantCulture);
      if (zeroTime >= outputDateTime)
      {
        timer1.Enabled = false;
        startButton.Visible = true;
        stopButton.Visible = false;
        System.Media.SoundPlayer snd = new System.Media.SoundPlayer("1.wav");
        snd.Play();
        MessageBox.Show("Timer");

      }
    }

    private void startButton_Click(object sender, EventArgs e)
    {
      saveTime = DateTime.Now;
      timer1.Enabled = true;
      startButton.Visible = false;
      stopButton.Visible = true;
    }

    private void stopButton_Click(object sender, EventArgs e)
    {
      timer1.Enabled = false;
      startButton.Visible = true;
      stopButton.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {

      System.Media.SoundPlayer snd = new System.Media.SoundPlayer("1.wav");
      snd.Play();
    }
  }
}
