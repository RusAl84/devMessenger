
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
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.progressBar2 = new System.Windows.Forms.ProgressBar();
      this.progressBar3 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(434, 167);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(326, 80);
      this.progressBar1.TabIndex = 0;
      // 
      // progressBar2
      // 
      this.progressBar2.Location = new System.Drawing.Point(73, 39);
      this.progressBar2.Name = "progressBar2";
      this.progressBar2.Size = new System.Drawing.Size(228, 90);
      this.progressBar2.TabIndex = 1;
      // 
      // progressBar3
      // 
      this.progressBar3.Location = new System.Drawing.Point(73, 298);
      this.progressBar3.Name = "progressBar3";
      this.progressBar3.Size = new System.Drawing.Size(228, 90);
      this.progressBar3.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.progressBar3);
      this.Controls.Add(this.progressBar2);
      this.Controls.Add(this.progressBar1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.ProgressBar progressBar2;
    private System.Windows.Forms.ProgressBar progressBar3;
  }
}

