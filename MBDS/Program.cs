using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace MBDS
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new ServerPanel());
        }
    }
}