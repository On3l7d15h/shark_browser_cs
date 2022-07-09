using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
//added
using EasyTabs;
using CefSharp;
using CefSharp.WinForms;
using WindowsFormsAppSharkBrowser.Forms.Settings;

namespace WindowsFormsAppSharkBrowser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (Program.AuthDoc == false)
            {
                InitializeChromium();
            }
            else
            {
                InitializeDoc();
            }

        }

        public ChromiumWebBrowser chromeBrowser;

        public void InitializeDoc()
        {
            //Program.AuthDoc = false;
            CefSettings settings = new CefSettings();
            //Initialize cef with he provide settings
            if (!Cef.IsInitialized)
            {
                Cef.Initialize(settings);
            }

            chromeBrowser = new ChromiumWebBrowser();
            chromeBrowser.LoadUrl("https://github.com/On3l7d15h/shark_browser_cs");

            //add to the form and fill it to the form window
            gpnl_main.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

            //Adding events
            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
        }

        public void InitializeChromium()
        {
            Program.AuthDoc = false;
            CefSettings settings = new CefSettings();
            //Initialize cef with he provide settings
            if (!Cef.IsInitialized)
            {
                Cef.Initialize(settings);
            }

            chromeBrowser = new ChromiumWebBrowser();

            if (Program.AuthStartPage)
            {
                chromeBrowser.LoadUrl(Program.UserUrl);
            } 
            else
            {
                chromeBrowser.LoadUrl("https://sharkbrowser.netlify.app/");
            }

            //add to the form and fill it to the form window
            gpnl_main.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

            //Adding events
            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
        
        }

        private void ChromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                gpir_main.Visible = e.IsLoading;
                gtxt_searcher.Text = chromeBrowser.Address;
            });
        }

        //important Declare ParentTabs
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }   

        private void frmMain_Load(object sender, EventArgs e)
        {
            //rotating the btn of back
            gbtn_back.Image.RotateFlip((RotateFlipType.Rotate180FlipNone));
        }

        private void gtxt_searcher_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loadUrl(gtxt_searcher.Text.Trim());
            }
        }

        void loadUrl(string url)
        {
            if (url.StartsWith("http"))
            {
                chromeBrowser.Load(url);
            } else
            {
                switch (Program.UserUrl)
                {
                        case "www.google.com":
                        {
                            chromeBrowser.Load($"https://www.google.com/search?q={url}");
                            break;
                        }

                        case "www.bing.com":
                        {
                            chromeBrowser.Load($"https://www.bing.com/search?q={url}");
                            break;
                        }

                        case "www.yandex.com":
                        {
                            chromeBrowser.Load($"https://yandex.com/search/?text={url}");
                            break;
                        }

                        case "www.swisscows.com":
                        {
                            chromeBrowser.Load($"https://swisscows.com/web?query=h{url}");
                            break;
                        }

                        default:
                        { 
                            chromeBrowser.Load($"https://duckduckgo.com/?q={url}&t=hs&va=l&ia=web");
                            break;
                        }
                }
            }
        }

        private void gbtn_back_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoBack)
            {
                chromeBrowser.Back();
            }
        }

        private void gbtn_forward_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoForward)
            {
                chromeBrowser.Forward();
            }
        }

        private void gbtn_home_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://sharkbrowser.netlify.app/");
        }

        private void gbtn_update_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        private void gbtn_update_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        private void gbtn_settings_Click(object sender, EventArgs e)
        {
            new frmSettings().Show();
        }
    }
}
