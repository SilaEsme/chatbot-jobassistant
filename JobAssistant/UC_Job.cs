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
    public partial class UC_Job : UserControl
    {
        Job job;
        UC_JobInformation information;
        public Job Job
        {
            get => job;
        }
        public UC_Job()
        {
            InitializeComponent();
        }
        public UC_Job(Job _job)
        {
            InitializeComponent();
            job = _job;
            SetInformations();
        }
        public void SetInformations()
        {
            label_Position.Text = job.Pozisyon;
            label_sehir.Text = job.Yer;
            label_name.Text = job.Marka; 
        }

        private void UC_Job_Load(object sender, EventArgs e)
        {
            information = new UC_JobInformation();
            information.Visible = false;
            information.Set(job);
            ApplyForAJob.Instance().panel_Display_Info.Controls.Add(information);
        }

        private void UC_Job_Click(object sender, EventArgs e)
        {
            foreach (var item in ApplyForAJob.Instance().panel_Display_Info.Controls.OfType<UC_JobInformation>())
            {
                item.Visible = false;
            }
            information.Visible = true;
        }
    }
}
