using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peek {
  public partial class fmAbout : Form {
    public fmAbout() {
      InitializeComponent();

      foreach (Control ctrl in this.Controls)
        this.setKeyDown(ctrl);
    }

    /// <summary>
    /// Implements event_KeyDown().
    /// </summary>
    private void fmMain_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Escape:
          this.Close();
          break;
      }
    }

    /// <summary>
    /// Implements event_Load().
    /// </summary>
    private void fmMain_Load(object sender, EventArgs e) {
      this.lbVersion.Text = "Version " + Application.ProductVersion;
    }

    private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Label label = (Label)sender;
      
      string url = label.Tag.ToString();
      if (url.IndexOf("@") > -1)
        url = "mailto:" + url;

      Process.Start(
          new ProcessStartInfo(
            url));
    }

    /// <summary>
    /// Sets the KeyDown callback for the specified control and cycle its children to set the same.
    /// </summary>
    /// <param name="control">The control to set</param>
    private void setKeyDown(Control control) {
      control.KeyDown += new KeyEventHandler(this.fmMain_KeyDown);

      foreach (Control ctrl in control.Controls)
        this.setKeyDown(ctrl);
    }
  }
}
