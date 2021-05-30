using System;
using System.Linq;
using System.Windows.Forms;

namespace JobAssistant
{
    public partial class ApplyForAJob : Form
    {
        private static ApplyForAJob _obj;

        public ApplyForAJob()
        {
            InitializeComponent();
        }

        public static ApplyForAJob Instance()
        {
            if (_obj == null)
            {
                _obj = new ApplyForAJob();
            }
            return _obj;
        }

        private void ApplyForAJob_Load(object sender, EventArgs e)
        {
            // Add Recommended Jobs
            foreach (var item in LoginedUser.Instance().ProperJobs)
            {
                UC_Job job = new UC_Job(item);
                flowPanel_DisplayJobs.Controls.Add(job);
            }
            // Add All Jobs
            foreach (var item in JobList.CreateSingle().GetList())
            {
                UC_Job job = new UC_Job(item);
                job.Visible = false;

                flowPanel_DisplayJobs.Controls.Add(job);
            }
        }

        private void RecommendMode()
        {
            bool flag = false;
            foreach (var item in flowPanel_DisplayJobs.Controls.OfType<UC_Job>())
            {
                item.Visible = false;
                if (LoginedUser.Instance().IsContains(item.Job) && !flag)
                {
                    item.Visible = true;
                    flag = true;
                }
            }
        }

        private void AllMode()
        {
            foreach (var item in flowPanel_DisplayJobs.Controls.OfType<UC_Job>())
            {
                item.Visible = true;
                if (LoginedUser.Instance().IsContains(item.Job))
                {
                    item.Visible = false;
                }
            }
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

        private void btn_recommend_Click(object sender, EventArgs e)
        {
            RecommendMode();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            AllMode();
        }
    }
}