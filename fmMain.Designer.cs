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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
      this.pbImage = new System.Windows.Forms.PictureBox();
      this.cmRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.toggleFullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toggleOriginalSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutPeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
      this.cmRightClick.SuspendLayout();
      this.SuspendLayout();
      // 
      // pbImage
      // 
      this.pbImage.ContextMenuStrip = this.cmRightClick;
      this.pbImage.Location = new System.Drawing.Point(242, 115);
      this.pbImage.Name = "pbImage";
      this.pbImage.Size = new System.Drawing.Size(157, 133);
      this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbImage.TabIndex = 0;
      this.pbImage.TabStop = false;
      this.pbImage.Visible = false;
      this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDown);
      this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
      this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseUp);
      // 
      // cmRightClick
      // 
      this.cmRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWithToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toggleFullScreenToolStripMenuItem,
            this.toggleOriginalSizeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutPeekToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.cmRightClick.Name = "cmRightClick";
      this.cmRightClick.Size = new System.Drawing.Size(180, 148);
      // 
      // openWithToolStripMenuItem
      // 
      this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
      this.openWithToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.openWithToolStripMenuItem.Text = "Open &With...";
      this.openWithToolStripMenuItem.Click += new System.EventHandler(this.openWithToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
      // 
      // toggleFullScreenToolStripMenuItem
      // 
      this.toggleFullScreenToolStripMenuItem.Name = "toggleFullScreenToolStripMenuItem";
      this.toggleFullScreenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.toggleFullScreenToolStripMenuItem.Text = "Toggle &Full Screen";
      this.toggleFullScreenToolStripMenuItem.Click += new System.EventHandler(this.toggleFullScreenToolStripMenuItem_Click);
      // 
      // toggleOriginalSizeToolStripMenuItem
      // 
      this.toggleOriginalSizeToolStripMenuItem.Name = "toggleOriginalSizeToolStripMenuItem";
      this.toggleOriginalSizeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.toggleOriginalSizeToolStripMenuItem.Text = "Toggle &Original Size";
      this.toggleOriginalSizeToolStripMenuItem.Click += new System.EventHandler(this.toggleOriginalSizeToolStripMenuItem_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 6);
      // 
      // aboutPeekToolStripMenuItem
      // 
      this.aboutPeekToolStripMenuItem.Name = "aboutPeekToolStripMenuItem";
      this.aboutPeekToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.aboutPeekToolStripMenuItem.Text = "&About Peek";
      this.aboutPeekToolStripMenuItem.Click += new System.EventHandler(this.aboutPeekToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
      this.Load += new System.EventHandler(this.fmMain_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmMain_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
      this.cmRightClick.ResumeLayout(false);
      this.ResumeLayout(false);

    }
    #endregion

    private System.Windows.Forms.PictureBox pbImage;
    private System.Windows.Forms.ContextMenuStrip cmRightClick;
    private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toggleFullScreenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toggleOriginalSizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem aboutPeekToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}