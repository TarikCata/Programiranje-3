﻿using DLWMS.WinForms.Forme;
using DLWMS.WinForms.IB200252;
using System;
using System.Windows.Forms;

namespace DLWMS.WinForms
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
            Form forma = new frmStudenti();
            Application.Run(forma);
        }
    }
}
