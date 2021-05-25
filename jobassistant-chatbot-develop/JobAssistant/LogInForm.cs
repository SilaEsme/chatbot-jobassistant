using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobAssistant
{
    public partial class LogInForm : Form
    {
        Employee employee = new Employee();
        EmployeeList employeeList = EmployeeList.CreateSingle();
        public LogInForm()
        {
            InitializeComponent();

            txtUsername.ForeColor = SystemColors.GrayText;
            txtPassword.ForeColor = SystemColors.GrayText;
            txtUsername.Text = "Please Enter Your Username";
            txtPassword.Text = "Please Enter Your Password";
          
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);


        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {

            if (txtUsername.Text == "Please Enter Your Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                txtUsername.Text = "Please Enter Your Username";
                txtUsername.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Please Enter Your Password")
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
                txtPassword.Text = "Please Enter Your Password";
                txtPassword.ForeColor = SystemColors.GrayText;

            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void label_signup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Your Password" || txtUsername.Text == "Enter Your Username") 
            {
                MessageBox.Show("Please fill all the blanks", "Invalid", MessageBoxButtons.OK);
            }
            else
            {
                HashCriptology hashCriptology = new HashCriptology();
                string sifre = txtPassword.Text;
                hashCriptology.MD5Sifrele(ref sifre);
                employee.password = sifre;
                employee.username = txtUsername.Text;
                if (employeeList.isValid(employee) == true)
                {
                    employee = employeeList.GetEmployee(employee.username);
                    LoginedUser loginedUser = LoginedUser.Instance();
                    loginedUser.Employee = employee;

                    MenuForm menuform = new MenuForm();
                    menuform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid password or username", "Invalid", MessageBoxButtons.OK);
                }
            }
           
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
