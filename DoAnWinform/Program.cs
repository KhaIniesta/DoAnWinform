﻿using System;
using System.Windows.Forms;

namespace DoAnWinform
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_dangnhap());
            //Application.Run(new staff_hoadon());
            //Application.Run(new frmHoaDon());
        }
    }
}
