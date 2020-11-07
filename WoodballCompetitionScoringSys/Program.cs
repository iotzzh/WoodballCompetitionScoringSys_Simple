using System;
using System.Windows.Forms;
using WoodballCompetitionScoringSys.DAL;

namespace WoodballCompetitionScoringSys
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            DALContext.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IndexForm());
        }
    }
}