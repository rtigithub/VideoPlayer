namespace ComputerVisionVideoPlayer
{
     using System;
     using System.Windows.Forms;

     internal static class Program
     {
          #region Private Methods

          [STAThread]
          private static void Main()
          {
               if (Environment.OSVersion.Version.Major >= 6)
                    SetProcessDPIAware();

               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new MainForm());
          }

          [System.Runtime.InteropServices.DllImport("user32.dll")]
          private static extern bool SetProcessDPIAware();

          #endregion Private Methods
     }
}