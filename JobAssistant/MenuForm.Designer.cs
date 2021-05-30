
namespace JobAssistant
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_bot = new System.Windows.Forms.Label();
            this.lbl_findjob = new System.Windows.Forms.Label();
            this.lbl_hireEmployee = new System.Windows.Forms.Label();
            this.pictureBox_advertise = new System.Windows.Forms.PictureBox();
            this.pictureBox_job = new System.Windows.Forms.PictureBox();
            this.pictureBox_bot = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_advertise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_job)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Malgun Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_title.Location = new System.Drawing.Point(37, 34);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(226, 47);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Job Assistant";
            // 
            // lbl_bot
            // 
            this.lbl_bot.AutoSize = true;
            this.lbl_bot.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bot.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_bot.Location = new System.Drawing.Point(69, 410);
            this.lbl_bot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bot.Name = "lbl_bot";
            this.lbl_bot.Size = new System.Drawing.Size(213, 18);
            this.lbl_bot.TabIndex = 7;
            this.lbl_bot.Text = "Connect to Job Assistant";
            this.lbl_bot.Click += new System.EventHandler(this.lbl_bot_Click);
            // 
            // lbl_findjob
            // 
            this.lbl_findjob.AutoSize = true;
            this.lbl_findjob.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_findjob.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_findjob.Location = new System.Drawing.Point(383, 410);
            this.lbl_findjob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_findjob.Name = "lbl_findjob";
            this.lbl_findjob.Size = new System.Drawing.Size(130, 18);
            this.lbl_findjob.TabIndex = 9;
            this.lbl_findjob.Text = "Apply for a Job";
            // 
            // lbl_hireEmployee
            // 
            this.lbl_hireEmployee.AutoSize = true;
            this.lbl_hireEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hireEmployee.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_hireEmployee.Location = new System.Drawing.Point(651, 410);
            this.lbl_hireEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hireEmployee.Name = "lbl_hireEmployee";
            this.lbl_hireEmployee.Size = new System.Drawing.Size(152, 18);
            this.lbl_hireEmployee.TabIndex = 11;
            this.lbl_hireEmployee.Text = "Hire an Employee";
            // 
            // pictureBox_advertise
            // 
            this.pictureBox_advertise.Image = global::JobAssistant.Properties.Resources._03;
            this.pictureBox_advertise.Location = new System.Drawing.Point(600, 124);
            this.pictureBox_advertise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_advertise.Name = "pictureBox_advertise";
            this.pictureBox_advertise.Size = new System.Drawing.Size(244, 256);
            this.pictureBox_advertise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_advertise.TabIndex = 6;
            this.pictureBox_advertise.TabStop = false;
            // 
            // pictureBox_job
            // 
            this.pictureBox_job.Image = global::JobAssistant.Properties.Resources.apple_device;
            this.pictureBox_job.Location = new System.Drawing.Point(322, 124);
            this.pictureBox_job.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_job.Name = "pictureBox_job";
            this.pictureBox_job.Size = new System.Drawing.Size(244, 256);
            this.pictureBox_job.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_job.TabIndex = 5;
            this.pictureBox_job.TabStop = false;
            this.pictureBox_job.Click += new System.EventHandler(this.pictureBox_job_Click);
            // 
            // pictureBox_bot
            // 
            this.pictureBox_bot.Image = global::JobAssistant.Properties.Resources.bot;
            this.pictureBox_bot.Location = new System.Drawing.Point(44, 124);
            this.pictureBox_bot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_bot.Name = "pictureBox_bot";
            this.pictureBox_bot.Size = new System.Drawing.Size(244, 256);
            this.pictureBox_bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_bot.TabIndex = 4;
            this.pictureBox_bot.TabStop = false;
            this.pictureBox_bot.Click += new System.EventHandler(this.pictureBox_bot_Click);
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_exit.Image = global::JobAssistant.Properties.Resources.icons8_close_window_64;
            this.pictureBox_exit.Location = new System.Drawing.Point(838, 10);
            this.pictureBox_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 12;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 535);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.lbl_hireEmployee);
            this.Controls.Add(this.lbl_findjob);
            this.Controls.Add(this.lbl_bot);
            this.Controls.Add(this.pictureBox_advertise);
            this.Controls.Add(this.pictureBox_job);
            this.Controls.Add(this.pictureBox_bot);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Assistant";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_advertise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_job)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox_bot;
        private System.Windows.Forms.PictureBox pictureBox_job;
        private System.Windows.Forms.PictureBox pictureBox_advertise;
        private System.Windows.Forms.Label lbl_bot;
        private System.Windows.Forms.Label lbl_findjob;
        private System.Windows.Forms.Label lbl_hireEmployee;
        private System.Windows.Forms.PictureBox pictureBox_exit;
    }
}

