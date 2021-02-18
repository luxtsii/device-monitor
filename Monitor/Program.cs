using System;
using System.Windows.Forms;

namespace Monitor
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new MainForm());
        }
    }
}
