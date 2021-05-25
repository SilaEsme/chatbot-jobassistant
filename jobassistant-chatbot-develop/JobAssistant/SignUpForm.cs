using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JobAssistant
{
    public partial class SignUpForm : Form
    {
        EmployeeList employeeList = EmployeeList.CreateSingle();
        Employee employee = new Employee();
       
        public SignUpForm()
        {
            InitializeComponent();
            txtUsername.ForeColor = SystemColors.GrayText;
            txtPassword.ForeColor = SystemColors.GrayText;
            txtConfirmPassword.ForeColor = SystemColors.GrayText;
            txtAdSoyad.ForeColor = SystemColors.GrayText;
            txtAdres.ForeColor = SystemColors.GrayText;
            txtDogumYeri.ForeColor = SystemColors.GrayText;
            txtTelefon.ForeColor = SystemColors.GrayText;
            txtePosta.ForeColor = SystemColors.GrayText;
            dateTimePicker_dogumtarihi.CalendarTitleForeColor = SystemColors.GrayText;

            txtUsername.Text = "Enter Your Username";
            txtPassword.Text = "Enter Your Password";
            txtConfirmPassword.Text = "Confirm Your Password";
            txtAdSoyad.Text = "Enter Your Name and Surname";
            txtAdres.Text = "Enter Your Address";
            txtDogumYeri.Text = "Where do you live?";
            txtTelefon.Text = "Enter Your Phone Number";
            txtePosta.Text = "Enter Your Mail Address";

            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);

            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);

            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);

            this.txtAdSoyad.Leave += new System.EventHandler(this.txtAdSoyad_Leave);
            this.txtAdSoyad.Enter += new System.EventHandler(this.txtAdSoyad_Enter);

            this.txtDogumYeri.Leave += new System.EventHandler(this.txtDogumYeri_Leave);
            this.txtDogumYeri.Enter += new System.EventHandler(this.txtDogumYeri_Enter);

            this.txtAdres.Leave += new System.EventHandler(this.txtAdres_Leave);
            this.txtAdres.Enter += new System.EventHandler(this.txtAdres_Enter);

            this.txtTelefon.Enter += new System.EventHandler(this.txtTelefon_Enter);
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);

            this.txtePosta.Enter += new System.EventHandler(this.txtePosta_Enter);
            this.txtePosta.Leave += new System.EventHandler(this.txtePosta_Leave);

        }
       
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Your Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                txtUsername.Text = "Enter Your Username";
                txtUsername.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Your Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = SystemColors.WindowText;
                txtPassword.PasswordChar = '*';
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.Text = "Enter Your Password";
                txtPassword.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Your Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = SystemColors.WindowText;
                txtConfirmPassword.PasswordChar = '*';
            }
        }
        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text.Length == 0)
            {
                txtConfirmPassword.Text = "Confirm Your Password";
                txtConfirmPassword.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtAdSoyad_Enter(object sender, EventArgs e)
        {

            if (txtAdSoyad.Text == "Enter Your Name and Surname")
            {
                txtAdSoyad.Text = "";
                txtAdSoyad.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtAdSoyad_Leave(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text.Length == 0)
            {
                txtAdSoyad.Text = "Enter Your Name and Surname";
                txtAdSoyad.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtDogumYeri_Enter(object sender, EventArgs e)
        {

            if (txtDogumYeri.Text == "Where do you live?")
            {
                txtDogumYeri.Text = "";
                txtDogumYeri.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtDogumYeri_Leave(object sender, EventArgs e)
        {
            if (txtDogumYeri.Text.Length == 0)
            {
                txtDogumYeri.Text = "Where do you live?";
                txtDogumYeri.ForeColor = SystemColors.GrayText;
            }
        }     
        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtTelefon_Enter(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "Enter Your Phone Number")
            {
                txtTelefon.Text = "";
                txtTelefon.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Length == 0)
            {
                txtTelefon.Text = "Enter Your Phone Number";
                txtTelefon.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtAdres_Enter(object sender, EventArgs e)
        {

            if (txtAdres.Text == "Enter Your Address")
            {
                txtAdres.Text = "";
                txtAdres.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtAdres_Leave(object sender, EventArgs e)
        {
            if (txtAdres.Text.Length == 0)
            {
                txtAdres.Text = "Enter Your Address";
                txtAdres.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtePosta_Enter(object sender, EventArgs e)
        {
            if (txtePosta.Text == "Enter Your Mail Address")
            {
                txtePosta.Text = "";
                txtePosta.ForeColor = SystemColors.WindowText;
            }

        }
        private void txtePosta_Leave(object sender, EventArgs e)
        {
            if (txtePosta.Text.Length == 0)
            {
                txtePosta.Text = "Enter Your Mail Address";
                txtePosta.ForeColor = SystemColors.GrayText;
            }
        }



        private void btn_signup_Click(object sender, EventArgs e)
        {
            HashCriptology hashCriptology = new HashCriptology();
            string sifre = txtPassword.Text;
            hashCriptology.MD5Sifrele(ref sifre);
            string confirm = txtConfirmPassword.Text;
            hashCriptology.MD5Sifrele(ref confirm);

      

            if(txtPassword.Text == "Enter Your Password" || txtUsername.Text == "Enter Your Username"
             || txtePosta.Text == "Enter Your Mail Address" || txtDogumYeri.Text == "Where do you live?"
             ||txtTelefon.Text == "Enter Your Phone Number" || txtAdSoyad.Text == "Enter Your Name and Surname"
             || txtConfirmPassword.Text == "Confirm Your Password" || txtAdres.Text == "Enter Your Address") 
            {
                MessageBox.Show("Please fill all the informations", "Invalid", MessageBoxButtons.OK);
 
            }
            else
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Your Password and Confirm Password does not match! Try Again!", "Wrong Password", buttons);
                    if (result == DialogResult.Yes)
                    {
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                    }
                }

                else
                {
                    employee.nameSurname = this.txtAdSoyad.Text;
                    employee.password = sifre;
                    employee.telefon = this.txtTelefon.Text;
                    employee.username = this.txtUsername.Text;
                    employee.adres = this.txtAdres.Text;
                    employee.dogumTarihi = dateTimePicker_dogumtarihi.Text;
                    employee.dogumYeri = this.txtDogumYeri.Text;
                    employee.eposta = this.txtePosta.Text;

                    employeeList.AddToEmployeeList(employee);


                    LogInForm logInForm = new LogInForm();
                    logInForm.Show();
                    this.Hide();
                }
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Application.Exit();
        }

    }
}
