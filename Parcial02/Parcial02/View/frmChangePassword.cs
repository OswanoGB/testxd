using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Parcial02.Context;
using Parcial02.Entities;

namespace Parcial02
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
    
        }
        
        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            //to-do done
            //to-do done
            var db = new ClinicucaContext();
            
            List<Username> users = db.usernames
                .Include(username => username.question)
                .ToList();

            string idCard = txtCarnet.Text;

            List<Username> result = users
                .Where(u => u.idCard == idCard)
                .ToList();
                
            if (result.Count() > 0)
            {
                label4.Text = result[0].question.question;
            }

        }   
        

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            //to-do done
            //to-do done
            //to-do done
            
            var db = new ClinicucaContext();
            
            List<Username> users = db.usernames
                .Include(username => username.question)
                .ToList();

            string userAnswer = txtAnswer.Text;

            List<Username> result = users
                .Where(u => u.answer == userAnswer)
                .ToList();
                
            if (result.Count() > 0)
            {
                ptbPadLock.Visible = false;
                picPadLock2.Visible = true;
                txtPassword.Visible = true;
                btnChangePassword.Visible = true;
                label3.Visible = true;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //vas a ir a modificar la contra del usuario a la base de datos
            //cuando se haga manda un messageBox diciendo que se hizo
            //luego cerra la venta y regresa a la ventana original
        }
    }
}