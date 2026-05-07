using CRUDSystem.Scripts;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUDSystem
{
    public partial class RegisterForm : Form
    {
        public User NewUser { get; set; }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string email = txtBoxEmail.Text;
            string telephone = mskTxtBoxTelephone.Text;

            string cpf = Regex.Replace(mskTxtBoxCPF.Text, @"\D", "");
                
            NewUser = new User(name, email, telephone, cpf);

            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            if (NewUser != null)
            {
                txtBoxName.Text = NewUser.Name;
                txtBoxEmail.Text = NewUser.Email;
                mskTxtBoxTelephone.Text = NewUser.Telephone;
                mskTxtBoxCPF.Text = NewUser.CPF;

                btnRegister.Text = "Atualizar";
            }
        }
    }
}
