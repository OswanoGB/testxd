using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }


        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword newPassword = new frmChangePassword();
            newPassword.ShowDialog();
        }

        private void btncreateuser_Click(object sender, EventArgs e)
        {
            frmCreateUser newUser = new frmCreateUser();
            newUser.ShowDialog();
            
        }

        private void btnInitSesion_Click(object sender, EventArgs e)
        {
            // cuando tenga la ventana principal lo configuro
            
        }
    }
}