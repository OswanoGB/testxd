using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;
using Parcial02.Context;
using Parcial02.Entities;

namespace Parcial02
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }


        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            //to-do done
            var db = new ClinicucaContext();
            cmbQuestions.DataSource = db.questions.ToList();
            cmbQuestions.DisplayMember = "question";
            cmbQuestions.ValueMember = "id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //to-do done
            this.Hide();
        }


        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            //to-do done
            //to-do done

            bool userValidations =
                txtCard.Text.Length == 8 &&
                txtName.Text.Length > 5 &&
                (txtPassword1.Text == txtPassword2.Text);
            if (userValidations)
            {
                string name = txtName.Text.Trim();
                string idcard = txtCard.Text;
                string pass = txtPassword1.Text;
                string answer = txtQuestion.Text;
                Question qref = (Question) cmbQuestions.SelectedItem;

                var db = new ClinicucaContext();
                Question qbdd = db.Set<Question>()
                    .SingleOrDefault(m => m.id == qref.id);

                Username u = new Username(idcard, name, pass, qbdd, answer);
                db.Add(u);
                db.SaveChanges();
                
                MessageBox.Show("Usuario creado exitosamente!", "ClinicUCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            } 
            else//datos no válidos
                MessageBox.Show("Datos inválidos! Intente de nuevo", "ClinicUCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
    }
