using System;
using System.Text;
using System.Windows.Forms;


namespace View
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            //Console.InputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
