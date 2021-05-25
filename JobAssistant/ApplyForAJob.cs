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
        UC_JobItem UC_jobitem = new UC_JobItem();
        Job job = new Job();
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new Job();
        Job job4 = new Job();
        Job job5 = new Job();

        public ApplyForAJob()
        {
            InitializeComponent();
        }
        private void SetJobs()
        {
            /*********************** JOB 1 ***********************/
            job1.JobID = 1;
            job1.Pozisyon = "Networking";
            job1.Okul = "BOUN";
            job1.Ingilizce = "C1";
            job1.Yer = "İzmir";
            job1.Marka = "Flytech Vodafone";
            UC_jobitem.Visible = false;
            panel_Display_Info.Controls.Add(UC_jobitem);

            /*********************** JOB 2 ***********************/
            job2.JobID = 2;
            job2.Pozisyon = "Software";
            job2.Okul = "ODTU";
            job2.Ingilizce = "B1";
            job2.Yer = "İstanbul";
            job2.Marka = "Eopy Automation, Design and Software";

            /*********************** JOB 3 ***********************/
            job3.JobID = 3;
            job3.Pozisyon = "Hardware";
            job3.Okul = "ESOGU";
            job3.Ingilizce = "B2";
            job3.Yer = "Antalya";
            job3.Marka = "NT Games";

            /*********************** JOB 4 ***********************/
            job4.JobID = 4;
            job4.Pozisyon = "Software";
            job4.Okul = "ODTU";
            job4.Ingilizce = "C2";
            job4.Yer = "Ankara";
            job4.Marka = "DataTeam";

            /*********************** JOB 5 ***********************/
            job5.JobID = 5;
            job5.Pozisyon = "Security";
            job5.Okul = "ESOGU";
            job5.Ingilizce = "B1";
            job5.Yer = "İstanbul";
            job5.Marka = "Argets Built Automation Software";
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

        private void panel_AD_1_MouseClick(object sender, MouseEventArgs e)
        {
            string desc = "We are looking for someone who is used to teamwork. " +
                           "You should speak level of C1 English and reside in İzmir.";

            UC_jobitem.Set(job1, desc);
            JobList.CreateSingle().AddToJobList(job1);
            UC_jobitem.Visible = true;
        }

        private void ApplyForAJob_Load(object sender, EventArgs e)
        { 
           
        }

        private void panel_AD_2_MouseClick(object sender, MouseEventArgs e)
        {
            string desc = "We are looking for someone who is used to teamwork. " +
                                                         "You should speak level of B1 English and reside in İstanbul.";
            UC_jobitem.Set(job2, desc);
            JobList.CreateSingle().AddToJobList(job2);
            UC_jobitem.Visible = true;
        }

        private void panel_AD_3_MouseClick(object sender, MouseEventArgs e)
        {
            string desc =  "We are looking for someone who is used to teamwork. " +
                                                         "You should speak level of B2 English and reside in Antalya.";
            UC_jobitem.Set(job3, desc);
            JobList.CreateSingle().AddToJobList(job3);
            UC_jobitem.Visible = true;
        }

        private void panel_AD_4_MouseClick(object sender, MouseEventArgs e)
        {
            string desc = "We are looking for someone who is used to teamwork. " +
                                                        "You should speak level of C2 English and reside in Ankara.";
            UC_jobitem.Set(job4, desc);
            JobList.CreateSingle().AddToJobList(job4);
            UC_jobitem.Visible = true;
        }

        private void panel_AD_5_MouseClick(object sender, MouseEventArgs e)
        {
            string desc = "We are looking for someone who is used to teamwork. " +
                                                         "You should speak level of B1 English and reside in İstanbul.";
            UC_jobitem.Set(job5, desc);
            JobList.CreateSingle().AddToJobList(job5);
            UC_jobitem.Visible = true;

        }
    }
}
