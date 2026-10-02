using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BasicThreading
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {

            AllocConsole();

            ApplicationConfiguration.Initialize();

            Application.Run(new FrmBasicThread());
        }
    }
}