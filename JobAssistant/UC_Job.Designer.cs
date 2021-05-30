
namespace JobAssistant
{
    partial class UC_Job
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Job));
            this.label_sehir = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_sehir
            // 
            this.label_sehir.AutoSize = true;
            this.label_sehir.Location = new System.Drawing.Point(177, 98);
            this.label_sehir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sehir.Name = "label_sehir";
            this.label_sehir.Size = new System.Drawing.Size(28, 13);
            this.label_sehir.TabIndex = 11;
            this.label_sehir.Text = "İzmir";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(177, 66);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(90, 13);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Flytech Vodafone";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(177, 29);
            this.label_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(109, 13);
            this.label_Position.TabIndex = 9;
            this.label_Position.Text = "Computer Networking";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(42, 29);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // UC_Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_sehir);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.pictureBox3);
            this.Name = "UC_Job";
            this.Size = new System.Drawing.Size(360, 140);
            this.Load += new System.EventHandler(this.UC_Job_Load);
            this.Click += new System.EventHandler(this.UC_Job_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sehir;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
