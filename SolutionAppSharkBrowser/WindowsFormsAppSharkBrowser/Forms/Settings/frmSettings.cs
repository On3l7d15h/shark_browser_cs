using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppSharkBrowser.Forms;

namespace WindowsFormsAppSharkBrowser.Forms.Settings
{
    public partial class frmSettings : Form
    {

        #region functions

        public void SecurityOption()
        {
            if (IsSecurityStrict())
            {
                DialogResult SharkDialogResult = MessageBox.Show("Usted ha seleccionado la función de navegación estrícta, ¿Está de acuerdo?", "SharkBrowser v.0.0.1", MessageBoxButtons.YesNo);

                if(SharkDialogResult == DialogResult.No)
                {
                    rbtn_normal.Checked = true;
                    MessageBox.Show("Usted ha cancelado la operación", "SharkBrowser v.0.0.1");
                }
            } 
            else if(IsSecurityLow())
            {
                DialogResult SharkDialogResult = MessageBox.Show("Usted ha seleccionado la función de navegación Baja, ¿Está de acuerdo?", "SharkBrowser v.0.0.1", MessageBoxButtons.YesNo);

                if (SharkDialogResult == DialogResult.No)
                {
                    rbtn_normal.Checked = true;
                    MessageBox.Show("Usted ha cancelado la operación", "SharkBrowser v.0.0.1");
                }
            }
            else if (IsSecurityNone())
            {
                DialogResult SharkDialogResult = MessageBox.Show("Usted ha seleccionado la función de ninguna forma de seguridad de navegación, ¿Está de acuerdo?", "SharkBrowser v.0.0.1", MessageBoxButtons.YesNo);

                if (SharkDialogResult == DialogResult.No)
                {
                    rbtn_normal.Checked = true;
                    MessageBox.Show("Usted ha cancelado la operación", "SharkBrowser v.0.0.1");
                }
            }
        }
        public void MainStartPage()
        {
            if (gcbo_searcher.Enabled)
            {
                if (gcbo_searcher.Text != "Selecccione 1")
                {
                    Program.UserUrl = gcbo_searcher.Text;
                }
                else
                {
                    MessageBox.Show("El campo no puede ser seleccione uno, cambielo", "SharkBrowser v.0.0.1");
                }
            } 
            if (IsStartCheckBoxChecked())
            {
                gcbo_searcher.Enabled = true;
            }
            else
            {
                gcbo_searcher.Enabled = false;
            }
        }

        public void ValidateUser()
        {
            if (chk_credentials.Checked && gtxt_user.Text.Trim() != "")
            {

                if (gtxt_pass.Text.Trim() != "")
                {
                    lbl_u.Text = gtxt_user.Text.Trim();
                }
                else
                {
                    MessageBox.Show("El campo contraseña no puede estar vacío", "SharkBrowser v.0.0.1");
                }
            }

            if (IsCredentialsChecked())
            {
                chk_credentials.Checked = true;
                gtxt_user.Enabled = true;   
                gtxt_pass.Enabled = true;   
            } 
            else
            {
                chk_credentials.Checked = false;
                gtxt_user.Enabled = false;
                gtxt_pass.Enabled = false;
            }      
        }

        #endregion

        #region subfunctions

        public bool IsSecurityNormal()
        {
            return rbtn_normal.Checked == true;
        }
        public bool IsSecurityStrict()
        {
            return rbtn_strict.Checked == true;
        }
        public bool IsSecurityLow()
        {
            return rbtn_low.Checked == true;
        }
        public bool IsSecurityNone()
        {
            return rbtn_none.Checked == true;
        }

        public bool IsStartCheckBoxChecked()
        {
            return chk_startpage.Checked;
        }

        public bool IsCredentialsChecked()
        {
            return chk_credentials.Checked;
        }

        #endregion
        public frmSettings()
        {
            InitializeComponent();
        }

        private void gbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbtn_apply_Click(object sender, EventArgs e)
        {
            SecurityOption();
            MainStartPage();
            ValidateUser();
        }

        private void gbtn_accept_Click(object sender, EventArgs e)
        {
            SecurityOption();
            MainStartPage();
            ValidateUser();
            this.Close();
        }

        private void gbtn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aún no disponible, pero el enlace del documento es: https://github.com/On3l7d15h/shark_browser_cs", "SharkBrowser v.0.0.1");
        }
    }
}
