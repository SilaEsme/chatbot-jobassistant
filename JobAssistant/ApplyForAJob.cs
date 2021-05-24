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
    public partial class ApplyForAJob : Form
    {
        public ApplyForAJob()
        {
            InitializeComponent();
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            MenuForm menuform = new MenuForm();
            menuform.Show();
            this.Hide();
        }

        
    }
}
