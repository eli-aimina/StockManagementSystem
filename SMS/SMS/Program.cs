﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CategoryForm());
            //Application.Run(new ItemUi());
            //Application.Run(new CompanyUi());
            //Application.Run(new ViewUi());
            //Application.Run(new SearchUI());
            Application.Run(new HomeUI());

        }
    }
}
