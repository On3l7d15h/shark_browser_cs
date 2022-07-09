using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added
using EasyTabs;

namespace WindowsFormsAppSharkBrowser
{
    public partial class AppCont : TitleBarTabs
    {
        public AppCont()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        //handle the method CreateTab aht allows the user
        // to Create a new tab on your app when clicking

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new frmMain
                {
                    Text = "Shark Tab"
                }
            };
        }
    }
}
