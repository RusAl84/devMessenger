
namespace SimpleWF2
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Button button2;
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.progressBar2 = new System.Windows.Forms.ProgressBar();
      this.progressBar3 = new System.Windows.Forms.ProgressBar();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.label1 = new System.Windows.Forms.Label();
      button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      this.SuspendLayout();
      // 
      // button2
      // 
      button2.Location = new System.Drawing.Point(563, 329);
      button2.Name = "button2";
      button2.Size = new System.Drawing.Size(190, 74);
      button2.TabIndex = 6;
      button2.Text = "Очистить бочку";
      button2.UseVisualStyleBackColor = true;
      button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(427, 175);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(326, 80);
      this.progressBar1.TabIndex = 0;
      // 
      // progressBar2
      // 
      this.progressBar2.Location = new System.Drawing.Point(85, 51);
      this.progressBar2.Name = "progressBar2";
      this.progressBar2.Size = new System.Drawing.Size(228, 64);
      this.progressBar2.TabIndex = 1;
      // 
      // progressBar3
      // 
      this.progressBar3.Location = new System.Drawing.Point(85, 297);
      this.progressBar3.Name = "progressBar3";
      this.progressBar3.Size = new System.Drawing.Size(228, 61);
      this.progressBar3.TabIndex = 2;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 600;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(85, 143);
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(228, 56);
      this.trackBar1.TabIndex = 3;
      this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
      this.trackBar1.LocationChanged += new System.EventHandler(this.trackBar1_LocationChanged);
      this.trackBar1.TabIndexChanged += new System.EventHandler(this.trackBar1_TabIndexChanged);
      // 
      // trackBar2
      // 
      this.trackBar2.Location = new System.Drawing.Point(85, 382);
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(228, 56);
      this.trackBar2.TabIndex = 4;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(143, 206);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(148, 24);
      this.checkBox1.TabIndex = 7;
      this.checkBox1.Text = "Таймер включен";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(418, 51);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(324, 62);
      this.label1.TabIndex = 8;
      this.label1.Text = "Бочка полная";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(button2);
      this.Controls.Add(this.trackBar2);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.progressBar3);
      this.Controls.Add(this.progressBar2);
      this.Controls.Add(this.progressBar1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.ProgressBar progressBar2;
    private System.Windows.Forms.ProgressBar progressBar3;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.TrackBar trackBar2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label label1;
  }
}

