namespace Peek {
  partial class fmAbout {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lbVersion = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.linkLabel3 = new System.Windows.Forms.LinkLabel();
      this.linkLabel4 = new System.Windows.Forms.LinkLabel();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Peek.Properties.Resources.Favorities_icon_128;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(128, 128);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(171, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 55);
      this.label1.TabIndex = 1;
      this.label1.Text = "Peek";
      // 
      // lbVersion
      // 
      this.lbVersion.AutoSize = true;
      this.lbVersion.ForeColor = System.Drawing.Color.White;
      this.lbVersion.Location = new System.Drawing.Point(201, 86);
      this.lbVersion.Name = "lbVersion";
      this.lbVersion.Size = new System.Drawing.Size(66, 13);
      this.lbVersion.TabIndex = 2;
      this.lbVersion.Text = "Version XXX";
      // 
      // linkLabel1
      // 
      this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.ForeColor = System.Drawing.Color.White;
      this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(33, 19);
      this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.linkLabel1.Location = new System.Drawing.Point(202, 119);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(292, 17);
      this.linkLabel1.TabIndex = 3;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Tag = "pdnagilum@gmail.com";
      this.linkLabel1.Text = "Copyright (c) 2013 Stian Hanger (pdnagilum@gmail.com)";
      this.linkLabel1.UseCompatibleTextRendering = true;
      this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // linkLabel2
      // 
      this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.ForeColor = System.Drawing.Color.White;
      this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(20, 31);
      this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.linkLabel2.Location = new System.Drawing.Point(202, 136);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(265, 17);
      this.linkLabel2.TabIndex = 4;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Tag = "https://github.com/nagilum/Peek";
      this.linkLabel2.Text = "Source available at https://github.com/nagilum/Peek";
      this.linkLabel2.UseCompatibleTextRendering = true;
      this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // linkLabel3
      // 
      this.linkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.linkLabel3.AutoSize = true;
      this.linkLabel3.ForeColor = System.Drawing.Color.White;
      this.linkLabel3.LinkArea = new System.Windows.Forms.LinkArea(8, 9);
      this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.linkLabel3.Location = new System.Drawing.Point(202, 153);
      this.linkLabel3.Name = "linkLabel3";
      this.linkLabel3.Size = new System.Drawing.Size(86, 17);
      this.linkLabel3.TabIndex = 5;
      this.linkLabel3.TabStop = true;
      this.linkLabel3.Tag = "http://www.iconarchive.com/artist/itzikgur.html";
      this.linkLabel3.Text = "Icon by Itzik Gur";
      this.linkLabel3.UseCompatibleTextRendering = true;
      this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // linkLabel4
      // 
      this.linkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.linkLabel4.AutoSize = true;
      this.linkLabel4.ForeColor = System.Drawing.Color.White;
      this.linkLabel4.LinkArea = new System.Windows.Forms.LinkArea(27, 11);
      this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.linkLabel4.Location = new System.Drawing.Point(201, 180);
      this.linkLabel4.Name = "linkLabel4";
      this.linkLabel4.Size = new System.Drawing.Size(203, 17);
      this.linkLabel4.TabIndex = 6;
      this.linkLabel4.TabStop = true;
      this.linkLabel4.Tag = "http://en.wikipedia.org/wiki/MIT_License";
      this.linkLabel4.Text = "Peek is released under the MIT License";
      this.linkLabel4.UseCompatibleTextRendering = true;
      this.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // fmAbout
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
      this.ClientSize = new System.Drawing.Size(553, 235);
      this.Controls.Add(this.linkLabel4);
      this.Controls.Add(this.linkLabel3);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.lbVersion);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "fmAbout";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "fmAbout";
      this.Load += new System.EventHandler(this.fmMain_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmMain_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbVersion;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.LinkLabel linkLabel3;
    private System.Windows.Forms.LinkLabel linkLabel4;

  }
}