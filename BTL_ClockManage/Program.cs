using BTL_ClockManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_ClockManage
{
    static class Program
    {
        public static Model1 context = new Model1();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.viewLogin());
            //Application.Run(new Views.viewAccountManage());
        }
    }
}
