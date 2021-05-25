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
    public partial class UC_JobItem : UserControl
    {
        Job job;
        string desc;

        public UC_JobItem(Job job, string desc)
        {
            InitializeComponent();
            this.job = job;
            this.desc = desc;
        }
     
        private void UC_JobItem_Load(object sender, EventArgs e)
        {
            label_pozisyon.Text = job.Pozisyon;
            label_okul.Text = job.Okul;
            label_ingilizce.Text = job.Ingilizce;
            label_yer.Text = job.Yer;
            label_marka.Text = job.Marka;
            labeldesc.Text = desc;
            labelheader.Text = "Computer " + job.Pozisyon;
        }
    }
}
