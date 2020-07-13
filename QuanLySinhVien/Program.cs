using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
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
            QuanLySinhVien qlsv=new QuanLySinhVien();
            qlsv.Size=new Size(1060,600);
            qlsv.FormBorderStyle = FormBorderStyle.FixedSingle;
            qlsv.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(qlsv);
        }
    }
}