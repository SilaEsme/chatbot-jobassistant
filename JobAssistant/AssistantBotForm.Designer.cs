
namespace JobAssistant
{
    partial class AssistantBotForm
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.panelDown = new System.Windows.Forms.Panel();
            this.pictureBoxSent = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.panelDialog = new System.Windows.Forms.Panel();
            this.userControlBubble1 = new JobAssistant.UserControlBubble();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            this.panelDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxText.Location = new System.Drawing.Point(12, 7);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(399, 31);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxText_KeyDown);
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.CadetBlue;
            this.panelDown.Controls.Add(this.pictureBoxSent);
            this.panelDown.Controls.Add(this.textBoxText);
            this.panelDown.Location = new System.Drawing.Point(520, 564);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(481, 44);
            this.panelDown.TabIndex = 2;
            // 
            // pictureBoxSent
            // 
            this.pictureBoxSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxSent.Image = global::JobAssistant.Properties.Resources.icons8_sent_64;
            this.pictureBoxSent.Location = new System.Drawing.Point(416, 7);
            this.pictureBoxSent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSent.Name = "pictureBoxSent";
            this.pictureBoxSent.Size = new System.Drawing.Size(53, 31);
            this.pictureBoxSent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSent.TabIndex = 1;
            this.pictureBoxSent.TabStop = false;
            this.pictureBoxSent.Click += new System.EventHandler(this.pictureBoxSent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.panelDialog);
            this.panel1.Location = new System.Drawing.Point(520, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 475);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(517, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Assistant Bot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::JobAssistant.Properties.Resources.image_processing20191115_17035_1dck5td;
            this.pictureBox1.Location = new System.Drawing.Point(9, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_exit.Image = global::JobAssistant.Properties.Resources.icons8_close_window_64;
            this.pictureBox_exit.Location = new System.Drawing.Point(991, 11);
            this.pictureBox_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(40, 44);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 13;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // panelDialog
            // 
            this.panelDialog.AutoScroll = true;
            this.panelDialog.BackColor = System.Drawing.SystemColors.Control;
            this.panelDialog.Controls.Add(this.userControlBubble1);
            this.panelDialog.Location = new System.Drawing.Point(12, 12);
            this.panelDialog.Name = "panelDialog";
            this.panelDialog.Size = new System.Drawing.Size(457, 450);
            this.panelDialog.TabIndex = 0;
            // 
            // userControlBubble1
            // 
            this.userControlBubble1.AutoSize = true;
            this.userControlBubble1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlBubble1.BackColor = System.Drawing.Color.LightBlue;
            this.userControlBubble1.Location = new System.Drawing.Point(10, 10);
            this.userControlBubble1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlBubble1.MaximumSize = new System.Drawing.Size(190, 1500);
            this.userControlBubble1.Name = "userControlBubble1";
            this.userControlBubble1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.userControlBubble1.Size = new System.Drawing.Size(0, 5);
            this.userControlBubble1.TabIndex = 16;
            // 
            // AssistantBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1042, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.panelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssistantBotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Assistant";
            this.Load += new System.EventHandler(this.AssistantBotForm_Load);
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSent)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            this.panelDialog.ResumeLayout(false);
            this.panelDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSent;
        private System.Windows.Forms.Panel panelDialog;
        private UserControlBubble userControlBubble1;
    }
}