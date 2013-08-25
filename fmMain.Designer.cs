namespace Peek
{
  partial class fmMain
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
      this.pbImage = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
      this.SuspendLayout();
      // 
      // pbImage
      // 
      this.pbImage.Location = new System.Drawing.Point(242, 115);
      this.pbImage.Name = "pbImage";
      this.pbImage.Size = new System.Drawing.Size(157, 133);
      this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbImage.TabIndex = 0;
      this.pbImage.TabStop = false;
      // 
      // fmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.ClientSize = new System.Drawing.Size(672, 402);
      this.Controls.Add(this.pbImage);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "fmMain";
      this.Text = "fmMain";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmMain_KeyDown);
      this.Load += new System.EventHandler(this.fmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
      this.ResumeLayout(false);

    }
    #endregion

    private System.Windows.Forms.PictureBox pbImage;
  }
}