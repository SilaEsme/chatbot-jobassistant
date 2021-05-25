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

        private void panel_AD_1_MouseClick(object sender, MouseEventArgs e)
        {
            Job job1 = new Job();
            
            /*********************** JOB 1 ***********************/
            job1.JobID = 1;
            job1.Pozisyon = "Networking";  
            job1.Okul = "BOUN";
            job1.Ingilizce = "C1";
            job1.Yer = "İzmir";
            job1.Marka = "Flytech Vodafone";

            UC_JobItem UC_jobitem = new UC_JobItem(job1, "We are looking for someone who is used to teamwork. " +
                                                         "You should speak level of C1 English and reside in İzmir.");
            panel_Display_Info.Controls.Add(UC_jobitem);
            JobList.CreateSingle().AddToJobList(job1);
        }

        private void ApplyForAJob_Load(object sender, EventArgs e)
        {
        }

        private void panel_AD_2_MouseClick(object sender, MouseEventArgs e)
        {
            Job job2 = new Job();
            /*********************** JOB 2 ***********************/
            job2.JobID = 2;
            job2.Pozisyon = "Software";
            job2.Okul = "ODTU";
            job2.Ingilizce = "B1";
            job2.Yer = "İstanbul";
            job2.Marka = "Eopy Automation, Design and Software";
            
            UC_JobItem UC_jobitem = new UC_JobItem(job2, "We are looking for someone who is used to teamwork. " +
                                                         "You should speak level of B1 English and reside in İstanbul.");
            JobList.CreateSingle().AddToJobList(job2);
            panel_Display_Info.Controls.Add(UC_jobitem);
        }

        private void panel_AD_3_MouseClick(object sender, MouseEventArgs e)
        {
            Job job3 = new Job();
            /*********************** JOB 3 ***********************/
            job3.JobID = 3;
            job3.Pozisyon = "Hardware";
            job3.Okul = "ESOGU";
            job3.Ingilizce = "B2";
            job3.Yer = "Antalya";
            job3.Marka = "NT Games";
           
            UC_JobItem UC_jobitem = new UC_JobItem(job3, "We are looking for someone who is used to teamwork. " +
                                                         "You should speak level of B2 English and reside in Antalya.");
            JobList.CreateSingle().AddToJobList(job3);
            panel_Display_Info.Controls.Add(UC_jobitem);
        }

        private void panel_AD_4_MouseClick(object sender, MouseEventArgs e)
        {
            Job job4 = new Job();
            /*********************** JOB 4 ***********************/
            job4.JobID = 4;
            job4.Pozisyon = "Software";
            job4.Okul = "ODTU";
            job4.Ingilizce = "C2";
            job4.Yer = "Ankara";
            job4.Marka = "DataTeam";
           
            UC_JobItem UC_jobitem = new UC_JobItem(job4, "We are looking for someone who is used to teamwork. " +
                                                        "You should speak level of C2 English and reside in Ankara.");
            JobList.CreateSingle().AddToJobList(job4);
            panel_Display_Info.Controls.Add(UC_jobitem);
        }

        private void panel_AD_5_MouseClick(object sender, MouseEventArgs e)
        {
            Job job5 = new Job();
            /*********************** JOB 5 ***********************/
            job5.JobID = 5;
            job5.Pozisyon = "Security";
            job5.Okul = "ESOGU";
            job5.Ingilizce = "B1";
            job5.Yer = "İstanbul";
            job5.Marka = "Argets Built Automation Software";

            UC_JobItem UC_jobitem = new UC_JobItem(job5, "We are looking for someone who is used to teamwork. " +
                                                         "You should speak level of B1 English and reside in İstanbul.");
            JobList.CreateSingle().AddToJobList(job5);
            panel_Display_Info.Controls.Add(UC_jobitem);
        }


    }
}
