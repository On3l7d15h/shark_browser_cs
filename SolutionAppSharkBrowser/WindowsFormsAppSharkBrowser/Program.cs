using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//added
using EasyTabs;

namespace WindowsFormsAppSharkBrowser
{
    internal static class Program
    {
        public static bool AuthStartPage = false;
        public static bool AuthDoc = false;
        public static string UserUrl = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppCont container = new AppCont();

            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new frmMain
                    {
                        Text = "Shark Tab"
                    }
                }
            );

            //Set Initial tab the first one
            container.SelectedTabIndex = 0;

            //Create Tabs and start application
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
