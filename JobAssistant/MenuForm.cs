using System;
using System.Windows.Forms;

namespace JobAssistant
{
    public partial class MenuForm : Form
    {
        private AssistantBotForm jobform = new AssistantBotForm();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void SetJobs()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Job job3 = new Job();
            Job job4 = new Job();
            Job job5 = new Job();
            /*
             *  UC_jobitem.Set(job1);
                JobList.CreateSingle().AddToJobList(job1);
                UC_jobitem.Visible = true;
             */

            /*********************** JOB 1 ***********************/
            job1.JobID = 1;
            job1.Pozisyon = "Networking";
            job1.Okul = "BOUN";
            job1.Ingilizce = "C1";
            job1.Yer = "İzmir";
            job1.Marka = "Flytech Vodafone";
            job1.Aciklama = "We are looking for someone who is used to teamwork. " +
                          "You should speak level of C1 English and reside in İzmir.";
            JobList.CreateSingle().AddToJobList(job1);
            /*UC_jobitem.Visible = false;
            panel_Display_Info.Controls.Add(UC_jobitem);/*

            /*********************** JOB 2 ***********************/
            job2.JobID = 2;
            job2.Pozisyon = "Software";
            job2.Okul = "ODTU";
            job2.Ingilizce = "B1";
            job2.Yer = "İstanbul";
            job2.Marka = "Eopy Automation, Design and Software";
            job2.Aciklama = "We are looking for someone who is used to teamwork. " +
                             "You should speak level of B1 English and reside in İstanbul.";
            JobList.CreateSingle().AddToJobList(job2);

            /*********************** JOB 3 ***********************/
            job3.JobID = 3;
            job3.Pozisyon = "Hardware";
            job3.Okul = "ESOGU";
            job3.Ingilizce = "B2";
            job3.Yer = "Antalya";
            job3.Marka = "NT Games";
            job3.Aciklama = "We are looking for someone who is used to teamwork. " +
                             "You should speak level of B2 English and reside in Antalya.";
            JobList.CreateSingle().AddToJobList(job3);

            /*********************** JOB 4 ***********************/
            job4.JobID = 4;
            job4.Pozisyon = "Software";
            job4.Okul = "ODTU";
            job4.Ingilizce = "C2";
            job4.Yer = "Ankara";
            job4.Marka = "DataTeam";
            job4.Aciklama = "We are looking for someone who is used to teamwork. " +
                            "You should speak level of C2 English and reside in Ankara.";
            JobList.CreateSingle().AddToJobList(job4);

            /*********************** JOB 5 ***********************/
            job5.JobID = 5;
            job5.Pozisyon = "Security";
            job5.Okul = "ESOGU";
            job5.Ingilizce = "B1";
            job5.Yer = "İstanbul";
            job5.Marka = "Argets Built Automation Software";
            job5.Aciklama = "We are looking for someone who is used to teamwork. " +
                         "You should speak level of B1 English and reside in İstanbul.";
            JobList.CreateSingle().AddToJobList(job5);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            SetJobs();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void lbl_bot_Click(object sender, EventArgs e)
        {
            jobform.Show();
            this.Hide();
        }

        private void pictureBox_bot_Click(object sender, EventArgs e)
        {
            jobform.Show();
            this.Hide();
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_job_Click(object sender, EventArgs e)
        {
            ApplyForAJob applyForAJob = ApplyForAJob.Instance();
            applyForAJob.Show();
            this.Hide();
        }
    }
}