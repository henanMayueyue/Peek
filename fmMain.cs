using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Peek {
  public partial class fmMain : Form {
    string filepath = "";
    List<string> files = new List<string>();
    bool fullScreen = false;
    Image image = null;
    int offsetX = 0;
    int offsetY = 0;
    bool originalSize = false;
    int screenIndex = 0;

    /// <summary>
    /// Constructor.
    /// </summary>
    public fmMain(string[] args) {
      if (args.Length > 0)
        for (int i = 0; i < args.Length; i++)
          this.filepath += args[i] + (i < (args.Length - 1) ? " " : "");

      InitializeComponent();
    }

    /// <summary>
    /// Implements event_KeyDown().
    /// </summary>
    private void fmMain_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Left:
          this.selectPreviousFile();
          break;

        case Keys.Right:
          this.selectNextFile();
          break;

        case Keys.Delete:
          this.deleteFile(e.Shift);
          break;

        case Keys.W:
          if (e.Control) { Application.Exit(); }
          break;

        case Keys.Q:
        case Keys.Escape:
          Application.Exit();
          break;

        case Keys.Enter:
          if (e.Alt) { this.toggleFullScreen(); }
          break;

        case Keys.F:
          this.toggleFullScreen();
          break;

        case Keys.O:
          this.toggleOriginalSize();
          break;

        case Keys.D0:
        case Keys.D1:
        case Keys.D2:
        case Keys.D3:
        case Keys.D4:
        case Keys.D5:
        case Keys.D6:
        case Keys.D7:
        case Keys.D8:
        case Keys.D9:
          this.screenIndex = (int)e.KeyCode;
          this.setWindowSize();
          break;
      }
    }

    /// <summary>
    /// Implements event_Load().
    /// </summary>
    private void fmMain_Load(object sender, EventArgs e) {
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.setWindowSize();
    }

    /// <summary>
    /// Implements event_MouseDown().
    /// </summary>
    private void pbImage_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == System.Windows.Forms.MouseButtons.Left) {
        this.offsetX = e.X;
        this.offsetY = e.Y;

        this.Cursor = Cursors.NoMove2D;
      }
    }

    /// <summary>
    /// Implements event_MouseMove().
    /// </summary>
    private void pbImage_MouseMove(object sender, MouseEventArgs e) {
      if (e.Button == System.Windows.Forms.MouseButtons.Left) {
        Point p = this.PointToClient(Cursor.Position);

        int newX = p.X - this.offsetX;
        int newY = p.Y - this.offsetY;

        this.pbImage.Location = new Point(
          newX,
          newY);
      }
    }

    /// <summary>
    /// Implements event_MouseUp().
    /// </summary>
    private void pbImage_MouseUp(object sender, MouseEventArgs e) {
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Moves the selected file to the Recyclin Bin.
    /// </summary>
    private void deleteFile(bool force) {
      if (this.files.Count > 0) {
        int position = -1;

        for (int i = 0; i < this.files.Count; i++) {
          if (this.files[i] == this.filepath) {
            position = i;
            break;
          }
        }

        if (position > -1) {
          this.files.RemoveAt(position);

          this.pbImage.Visible = false;

          this.image.Dispose();
          this.image = null;

          try {
            if (force)
              File.Delete(this.filepath);
            else
              FileIO.MoveToRecycleBin(this.filepath);
          }
          catch (Exception ex) {
            MessageBox.Show(ex.Message);
          }

          if (position == this.files.Count)
            position = 0;

          this.filepath = this.files[position];

          this.loadImageFromArguments();
        }
      }
    }

    /// <summary>
    /// Load and display the image stored in the global filepath.
    /// </summary>
    private void loadImageFromArguments() {
      if (string.IsNullOrWhiteSpace(this.filepath)) {
        Application.Exit();
        return;
      }

      if (this.files.Count == 0)
        this.scanForImageFiles();

      try {
        this.image = Image.FromFile(this.filepath);

        string filename = this.filepath.Substring(this.filepath.LastIndexOf(@"\") + 1);

        int imageHeight = image.Height;
        int imageWidth = image.Width;

        int setHeight = 0;
        int setLeft = 0;
        int setTop = 0;
        int setWidth = 0;

        if (imageHeight > this.ClientSize.Height ||
            imageWidth > this.ClientSize.Width) {
          if (imageHeight > this.ClientSize.Height &&
              imageWidth > this.ClientSize.Width) {
            decimal percentHeight = (((decimal)100 / (decimal)imageHeight) * (decimal)this.ClientSize.Height) / (decimal)100;
            decimal percentWidth = (((decimal)100 / (decimal)imageWidth) * (decimal)this.ClientSize.Width) / (decimal)100;

            if (percentWidth < percentHeight) {
              setHeight = (int)((decimal)imageHeight * percentWidth);
              setWidth = this.ClientSize.Width;
            }
            else {
              setHeight = this.ClientSize.Height;
              setWidth = (int)((decimal)imageWidth * percentHeight);
            }
          }
          else if (imageHeight > this.ClientSize.Height) {
            decimal percent = (((decimal)100 / (decimal)imageHeight) * (decimal)this.ClientSize.Height) / (decimal)100;

            setHeight = this.ClientSize.Height;
            setWidth = (int)((decimal)imageWidth * percent);
          }
          else {
            decimal percent = (((decimal)100 / (decimal)imageWidth) * (decimal)this.ClientSize.Width) / (decimal)100;

            setHeight = (int)((decimal)imageHeight * percent);
            setWidth = this.ClientSize.Width;
          }
        }
        else {
          setHeight = imageHeight;
          setWidth = imageWidth;
        }

        if (this.originalSize) {
          setHeight = image.Height;
          setWidth = image.Width;
        }

        setLeft = (this.ClientSize.Width - setWidth) / 2;
        setTop = (this.ClientSize.Height - setHeight) / 2;

        this.pbImage.Visible = false;
        this.pbImage.Location = new Point(setLeft, setTop);
        this.pbImage.Size = new Size(setWidth, setHeight);
        this.pbImage.Image = this.image;
        this.pbImage.Visible = true;

        this.Text =
          filename +
          " (" + imageWidth.ToString() + "x" + imageHeight.ToString() + ")" +
          " - Peek";
      }
      catch (Exception ex) {
        MessageBox.Show(
          ex.Message,
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
    }

    /// <summary>
    /// Scan the folder of the given file to make it possible to navigate the folder.
    /// </summary>
    private void scanForImageFiles() {
      string path = this.filepath.Substring(0, this.filepath.LastIndexOf(@"\"));

      if (Directory.Exists(path)) {
        List<string> extensions = "png,jpg,jpe,jpeg,gif,bmp,tif,tiff,ico,cur".Split(new char[] { ',' }).ToList();

        for (int i = 0; i < extensions.Count; i++) {
          string[] temp = Directory.GetFiles(path, "*." + extensions[i], SearchOption.TopDirectoryOnly);

          for (int j = 0; j < temp.Length; j++)
            this.files.Add(temp[j]);
        }

        this.files.Sort();
      }
    }

    /// <summary>
    /// Activate the next file in the folder.
    /// </summary>
    private void selectNextFile() {
      string temp = "";

      if (this.files.Count > 0) {
        for (int i = 0; i < this.files.Count; i++) {
          if (this.files[i] == this.filepath) {
            if (i == (this.files.Count - 1))
              temp = this.files[0];
            else
              temp = this.files[i + 1];

            break;
          }
        }
      }

      if (temp != "" &&
          temp != this.filepath) {
        this.filepath = temp;
        this.loadImageFromArguments();
      }
    }

    /// <summary>
    /// Activate the previous file in the folder.
    /// </summary>
    private void selectPreviousFile() {
      string temp = "";

      if (this.files.Count > 0) {
        for (int i = 0; i < this.files.Count; i++) {
          if (this.files[i] == this.filepath) {
            if (i == 0)
              temp = this.files[this.files.Count - 1];
            else
              temp = this.files[i - 1];

            break;
          }
        }
      }

      if (temp != "" &&
          temp != this.filepath) {
        this.filepath = temp;
        this.loadImageFromArguments();
      }
    }

    /// <summary>
    /// Sets the main window size based on settings.
    /// </summary>
    private void setWindowSize() {
      int screenHeight = 0;
      int screenLeft = 0;
      int screenTop = 0;
      int screenWidth = 0;
      Screen screen = null;

      if (this.screenIndex > 0)
        if ((this.screenIndex - 1) <= Screen.AllScreens.Length)
          screen = Screen.AllScreens[this.screenIndex - 1];

      if (screen == null) {
        foreach (Screen scr in Screen.AllScreens) {
          if (MousePosition.X >= scr.Bounds.Left &&
              MousePosition.X <= (scr.Bounds.Left + scr.Bounds.Width) &&
              MousePosition.Y >= scr.Bounds.Top &&
              MousePosition.Y <= (scr.Bounds.Top + scr.Bounds.Height)) {
                screen = scr;
                break;
          }
        }
      }

      if (screen != null) {
        if (this.fullScreen) {
          screenHeight = screen.Bounds.Height;
          screenLeft = screen.Bounds.Left;
          screenTop = screen.Bounds.Top;
          screenWidth = screen.Bounds.Width;
        }
        else {
          screenHeight = screen.WorkingArea.Height;
          screenLeft = screen.WorkingArea.Left;
          screenTop = screen.WorkingArea.Top;
          screenWidth = screen.WorkingArea.Width;
        }
      }

      if (screenHeight == 0) {
        MessageBox.Show(
          "Unable to locate screen to render too! This really should not happen and is most likely a bug.",
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
          );

        Application.Exit();
      }

      this.Location = new Point(
        screenLeft,
        screenTop);

      this.Size = new Size(
        screenWidth,
        screenHeight);

      this.loadImageFromArguments();
    }

    /// <summary>
    /// Toggles between maximized window and full screen.
    /// </summary>
    private void toggleFullScreen() {
      this.fullScreen = !this.fullScreen;
      this.setWindowSize();
    }

    /// <summary>
    /// Toggles between original size and scaled on the image preview.
    /// </summary>
    private void toggleOriginalSize() {
      this.originalSize = !this.originalSize;
      this.loadImageFromArguments();
    }
  }
}
