using System;
using System.Windows.Forms;

namespace France
{
  partial class France_Index
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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

    public Label label1 = new Label();

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    /// 
    public void InitializeComponent()
    {
      this.SuspendLayout();
      // 
      // France_Index
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(800, 800);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "France_Index";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "France Map";
      this.ResumeLayout(false);

      World world = new World();
      Map map = new Map(world);
      
      



//    label1.Text = "Time " + DateTime.Now.ToLongTimeString();



    }

    #endregion
  }
}

