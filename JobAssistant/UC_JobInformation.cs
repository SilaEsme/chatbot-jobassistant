using System;
using System.Windows.Forms;

namespace JobAssistant
{
    public partial class UC_JobInformation : UserControl
    {
        public UC_JobInformation()
        {
            InitializeComponent();
        }

        public void Set(Job job)
        {
            label_pozisyon.Text = job.Pozisyon;
            label_okul.Text = job.Okul;
            label_ingilizce.Text = job.Ingilizce;
            label_yer.Text = job.Yer;
            label_marka.Text = job.Marka;
            labeldesc.Text = job.Aciklama;
            labelheader.Text = "Computer " + job.Pozisyon;
        }

        private void UC_JobItem_Load(object sender, EventArgs e)
        {
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your application is sent to the company. We are going to notify you when feedback is available.", "Notification", MessageBoxButtons.OK);
        }
    }
}