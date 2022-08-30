using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACD_Construction.ORM.Context;

namespace ACD_Construction
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
            using (ProjectContext ACD = new ProjectContext())
            {
                //ACD.Database.Create();
            }
            Application.Run(new Login());
        }
    }
}
