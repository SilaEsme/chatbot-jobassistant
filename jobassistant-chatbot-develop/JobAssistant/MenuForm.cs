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
    public partial class MenuForm : Form
    {
        AssistantBotForm jobform = new AssistantBotForm();
        SignUpForm signform = new SignUpForm();
        LogInForm loginform = new LogInForm();
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bot_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_bot_information_Click(object sender, EventArgs e)
        {
           
        }
        private void pictureBox_bot_Click(object sender, EventArgs e)
        {
            jobform.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            signform.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginform.Show();
            this.Hide();
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_job_Click(object sender, EventArgs e)
        {
            ApplyForAJob applyForAJob = new ApplyForAJob();
            applyForAJob.Show();
            this.Hide();
        }
    }
}
