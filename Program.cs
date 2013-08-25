using System;
using System.Windows.Forms;

namespace Peek
{
  static class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new fmMain(args));
    }
  }
}
