
namespace JobAssistant
{
    partial class SignUpForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.txtePosta = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbl_signupheader = new System.Windows.Forms.Label();
            this.dateTimePicker_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobAssistant.Properties.Resources.teamwork_illustration_2_1024x768;
            this.pictureBox1.Location = new System.Drawing.Point(402, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogumYeri.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDogumYeri.Location = new System.Drawing.Point(34, 154);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(240, 35);
            this.txtDogumYeri.TabIndex = 4;
            this.txtDogumYeri.Text = "doğum yeri";
            this.txtDogumYeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAdSoyad.Location = new System.Drawing.Point(34, 97);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(350, 35);
            this.txtAdSoyad.TabIndex = 3;
            this.txtAdSoyad.Text = "ad syoad";
            this.txtAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAdres.Location = new System.Drawing.Point(34, 211);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(350, 35);
            this.txtAdres.TabIndex = 6;
            this.txtAdres.Text = "adres";
            this.txtAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefon.Location = new System.Drawing.Point(34, 268);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(350, 35);
            this.txtTelefon.TabIndex = 7;
            this.txtTelefon.Text = "telefon";
            this.txtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefon.Enter += new System.EventHandler(this.txtTelefon_Enter);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_signup.Location = new System.Drawing.Point(130, 555);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(154, 35);
            this.btn_signup.TabIndex = 9;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_exit.Image = global::JobAssistant.Properties.Resources.icons8_close_window_64;
            this.pictureBox_exit.Location = new System.Drawing.Point(1113, 12);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(53, 54);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 10;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // txtePosta
            // 
            this.txtePosta.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtePosta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtePosta.Location = new System.Drawing.Point(34, 325);
            this.txtePosta.Name = "txtePosta";
            this.txtePosta.Size = new System.Drawing.Size(350, 35);
            this.txtePosta.TabIndex = 11;
            this.txtePosta.Text = "e posta";
            this.txtePosta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtConfirmPassword.Location = new System.Drawing.Point(34, 496);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(350, 35);
            this.txtConfirmPassword.TabIndex = 14;
            this.txtConfirmPassword.Text = "confirm";
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(34, 439);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 35);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.Location = new System.Drawing.Point(34, 382);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 35);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Text = "username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_signupheader
            // 
            this.lbl_signupheader.AutoSize = true;
            this.lbl_signupheader.BackColor = System.Drawing.Color.White;
            this.lbl_signupheader.Font = new System.Drawing.Font("Malgun Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signupheader.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_signupheader.Location = new System.Drawing.Point(25, 12);
            this.lbl_signupheader.Name = "lbl_signupheader";
            this.lbl_signupheader.Size = new System.Drawing.Size(193, 59);
            this.lbl_signupheader.TabIndex = 15;
            this.lbl_signupheader.Text = "SIGN UP";
            this.lbl_signupheader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker_dogumtarihi
            // 
            this.dateTimePicker_dogumtarihi.CalendarFont = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_dogumtarihi.CalendarForeColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker_dogumtarihi.CalendarTitleForeColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker_dogumtarihi.CustomFormat = "yyyy";
            this.dateTimePicker_dogumtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_dogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dogumtarihi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_dogumtarihi.Location = new System.Drawing.Point(280, 155);
            this.dateTimePicker_dogumtarihi.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_dogumtarihi.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_dogumtarihi.Name = "dateTimePicker_dogumtarihi";
            this.dateTimePicker_dogumtarihi.Size = new System.Drawing.Size(104, 34);
            this.dateTimePicker_dogumtarihi.TabIndex = 16;
            this.dateTimePicker_dogumtarihi.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 658);
            this.Controls.Add(this.dateTimePicker_dogumtarihi);
            this.Controls.Add(this.lbl_signupheader);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtePosta);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.TextBox txtePosta;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbl_signupheader;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dogumtarihi;
    }
}