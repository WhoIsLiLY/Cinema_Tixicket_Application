namespace Celikoor_Tixycket
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelNoTelp = new System.Windows.Forms.Label();
            this.buttonUpdateChanges = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelFotoProfile = new System.Windows.Forms.Panel();
            this.buttonShowPasswork = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelNamaUser = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelBalanceValue = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.pictureBoxFotoPtofil = new System.Windows.Forms.PictureBox();
            this.labelNominalSaldo = new System.Windows.Forms.Label();
            this.customTextBoxNoHp = new Celikoor_Tixycket.CustomTextbox();
            this.customTextBoxEmail = new Celikoor_Tixycket.CustomTextbox();
            this.customTextBoxPassword = new Celikoor_Tixycket.CustomTextbox();
            this.customTextBoxUsername = new Celikoor_Tixycket.CustomTextbox();
            this.customTextBoxNama = new Celikoor_Tixycket.CustomTextbox();
            this.dateTimePickerTglLahir = new System.Windows.Forms.DateTimePicker();
            this.panelFotoProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShowPasswork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPtofil)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProfile
            // 
            this.labelProfile.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.labelProfile.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.Transparent;
            this.labelProfile.Location = new System.Drawing.Point(-416, -7);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(2145, 89);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "EDIT PROFILE";
            this.labelProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProfile.Click += new System.EventHandler(this.labelProfile_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.PeachPuff;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelName.Location = new System.Drawing.Point(295, 315);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 28);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.labelUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsername.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelUsername.Location = new System.Drawing.Point(295, 414);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(141, 28);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNoTelp
            // 
            this.labelNoTelp.AutoSize = true;
            this.labelNoTelp.BackColor = System.Drawing.Color.PeachPuff;
            this.labelNoTelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNoTelp.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoTelp.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelNoTelp.Location = new System.Drawing.Point(723, 414);
            this.labelNoTelp.Name = "labelNoTelp";
            this.labelNoTelp.Size = new System.Drawing.Size(201, 28);
            this.labelNoTelp.TabIndex = 2;
            this.labelNoTelp.Text = "Phone Number";
            // 
            // buttonUpdateChanges
            // 
            this.buttonUpdateChanges.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonUpdateChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateChanges.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateChanges.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateChanges.Location = new System.Drawing.Point(515, 674);
            this.buttonUpdateChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateChanges.Name = "buttonUpdateChanges";
            this.buttonUpdateChanges.Size = new System.Drawing.Size(292, 51);
            this.buttonUpdateChanges.TabIndex = 3;
            this.buttonUpdateChanges.Text = "&SAVE CHANGES";
            this.buttonUpdateChanges.UseVisualStyleBackColor = false;
            this.buttonUpdateChanges.Click += new System.EventHandler(this.buttonUpdateChanges_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.PeachPuff;
            this.labelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelEmail.Location = new System.Drawing.Point(723, 315);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(83, 28);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // panelFotoProfile
            // 
            this.panelFotoProfile.BackColor = System.Drawing.Color.PeachPuff;
            this.panelFotoProfile.Controls.Add(this.dateTimePickerTglLahir);
            this.panelFotoProfile.Controls.Add(this.labelNominalSaldo);
            this.panelFotoProfile.Controls.Add(this.buttonShowPasswork);
            this.panelFotoProfile.Controls.Add(this.labelHello);
            this.panelFotoProfile.Controls.Add(this.labelNamaUser);
            this.panelFotoProfile.Controls.Add(this.customTextBoxNoHp);
            this.panelFotoProfile.Controls.Add(this.customTextBoxEmail);
            this.panelFotoProfile.Controls.Add(this.customTextBoxPassword);
            this.panelFotoProfile.Controls.Add(this.customTextBoxUsername);
            this.panelFotoProfile.Controls.Add(this.customTextBoxNama);
            this.panelFotoProfile.Controls.Add(this.labelBirthDate);
            this.panelFotoProfile.Controls.Add(this.labelPassword);
            this.panelFotoProfile.Controls.Add(this.labelBalanceValue);
            this.panelFotoProfile.Controls.Add(this.labelBalance);
            this.panelFotoProfile.Controls.Add(this.pictureBoxFotoPtofil);
            this.panelFotoProfile.Controls.Add(this.buttonUpdateChanges);
            this.panelFotoProfile.Controls.Add(this.labelName);
            this.panelFotoProfile.Controls.Add(this.labelUsername);
            this.panelFotoProfile.Controls.Add(this.labelEmail);
            this.panelFotoProfile.Controls.Add(this.labelNoTelp);
            this.panelFotoProfile.ForeColor = System.Drawing.Color.Transparent;
            this.panelFotoProfile.Location = new System.Drawing.Point(-1, 72);
            this.panelFotoProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFotoProfile.Name = "panelFotoProfile";
            this.panelFotoProfile.Size = new System.Drawing.Size(1462, 776);
            this.panelFotoProfile.TabIndex = 4;
            this.panelFotoProfile.Click += new System.EventHandler(this.panelFotoProfile_Click);
            this.panelFotoProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFotoProfile_Paint);
            // 
            // buttonShowPasswork
            // 
            this.buttonShowPasswork.BackgroundImage = global::Celikoor_Tixycket.Properties.Resources.eye;
            this.buttonShowPasswork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShowPasswork.Location = new System.Drawing.Point(598, 549);
            this.buttonShowPasswork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowPasswork.Name = "buttonShowPasswork";
            this.buttonShowPasswork.Size = new System.Drawing.Size(40, 40);
            this.buttonShowPasswork.TabIndex = 26;
            this.buttonShowPasswork.TabStop = false;
            this.buttonShowPasswork.Click += new System.EventHandler(this.buttonShowPasswork_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.PeachPuff;
            this.labelHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHello.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelHello.Location = new System.Drawing.Point(616, 118);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(117, 34);
            this.labelHello.TabIndex = 25;
            this.labelHello.Text = "HELLO";
            // 
            // labelNamaUser
            // 
            this.labelNamaUser.AutoSize = true;
            this.labelNamaUser.BackColor = System.Drawing.Color.PeachPuff;
            this.labelNamaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNamaUser.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaUser.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelNamaUser.Location = new System.Drawing.Point(728, 118);
            this.labelNamaUser.Name = "labelNamaUser";
            this.labelNamaUser.Size = new System.Drawing.Size(107, 34);
            this.labelNamaUser.TabIndex = 24;
            this.labelNamaUser.Text = "NAME";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.BackColor = System.Drawing.Color.PeachPuff;
            this.labelBirthDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBirthDate.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelBirthDate.Location = new System.Drawing.Point(723, 512);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(180, 28);
            this.labelBirthDate.TabIndex = 15;
            this.labelBirthDate.Text = "Date Of Birth";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.PeachPuff;
            this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelPassword.Location = new System.Drawing.Point(295, 512);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(138, 28);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // labelBalanceValue
            // 
            this.labelBalanceValue.AutoSize = true;
            this.labelBalanceValue.BackColor = System.Drawing.Color.PeachPuff;
            this.labelBalanceValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBalanceValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceValue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelBalanceValue.Location = new System.Drawing.Point(618, 197);
            this.labelBalanceValue.Name = "labelBalanceValue";
            this.labelBalanceValue.Size = new System.Drawing.Size(49, 25);
            this.labelBalanceValue.TabIndex = 11;
            this.labelBalanceValue.Text = "Rp.";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.BackColor = System.Drawing.Color.PeachPuff;
            this.labelBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBalance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelBalance.Location = new System.Drawing.Point(618, 168);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(197, 25);
            this.labelBalance.TabIndex = 10;
            this.labelBalance.Text = "Account Balance";
            // 
            // pictureBoxFotoPtofil
            // 
            this.pictureBoxFotoPtofil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFotoPtofil.BackgroundImage")));
            this.pictureBoxFotoPtofil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFotoPtofil.Location = new System.Drawing.Point(424, 76);
            this.pictureBoxFotoPtofil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFotoPtofil.Name = "pictureBoxFotoPtofil";
            this.pictureBoxFotoPtofil.Size = new System.Drawing.Size(161, 156);
            this.pictureBoxFotoPtofil.TabIndex = 9;
            this.pictureBoxFotoPtofil.TabStop = false;
            // 
            // labelNominalSaldo
            // 
            this.labelNominalSaldo.AutoSize = true;
            this.labelNominalSaldo.BackColor = System.Drawing.Color.PeachPuff;
            this.labelNominalSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNominalSaldo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNominalSaldo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelNominalSaldo.Location = new System.Drawing.Point(673, 197);
            this.labelNominalSaldo.Name = "labelNominalSaldo";
            this.labelNominalSaldo.Size = new System.Drawing.Size(26, 25);
            this.labelNominalSaldo.TabIndex = 27;
            this.labelNominalSaldo.Text = "0";
            // 
            // customTextBoxNoHp
            // 
            this.customTextBoxNoHp.BackColor = System.Drawing.Color.PeachPuff;
            this.customTextBoxNoHp.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.customTextBoxNoHp.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxNoHp.BorderSize = 2;
            this.customTextBoxNoHp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBoxNoHp.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxNoHp.Location = new System.Drawing.Point(728, 452);
            this.customTextBoxNoHp.Multiline = false;
            this.customTextBoxNoHp.Name = "customTextBoxNoHp";
            this.customTextBoxNoHp.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxNoHp.PasswordChar = false;
            this.customTextBoxNoHp.Size = new System.Drawing.Size(311, 40);
            this.customTextBoxNoHp.TabIndex = 21;
            this.customTextBoxNoHp.Texts = "PHONE NUMBER";
            this.customTextBoxNoHp.UnderlinedStyle = false;
            this.customTextBoxNoHp.Click += new System.EventHandler(this.customTextboxPhoneNumber_Click);
            // 
            // customTextBoxEmail
            // 
            this.customTextBoxEmail.BackColor = System.Drawing.Color.PeachPuff;
            this.customTextBoxEmail.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.customTextBoxEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxEmail.BorderSize = 2;
            this.customTextBoxEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBoxEmail.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxEmail.Location = new System.Drawing.Point(728, 353);
            this.customTextBoxEmail.Multiline = false;
            this.customTextBoxEmail.Name = "customTextBoxEmail";
            this.customTextBoxEmail.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxEmail.PasswordChar = false;
            this.customTextBoxEmail.Size = new System.Drawing.Size(311, 40);
            this.customTextBoxEmail.TabIndex = 20;
            this.customTextBoxEmail.Texts = "EMAIL";
            this.customTextBoxEmail.UnderlinedStyle = false;
            this.customTextBoxEmail.Click += new System.EventHandler(this.customTextboxEmail_Click);
            // 
            // customTextBoxPassword
            // 
            this.customTextBoxPassword.BackColor = System.Drawing.Color.PeachPuff;
            this.customTextBoxPassword.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.customTextBoxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxPassword.BorderSize = 2;
            this.customTextBoxPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxPassword.Location = new System.Drawing.Point(300, 549);
            this.customTextBoxPassword.Multiline = false;
            this.customTextBoxPassword.Name = "customTextBoxPassword";
            this.customTextBoxPassword.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxPassword.PasswordChar = true;
            this.customTextBoxPassword.Size = new System.Drawing.Size(292, 40);
            this.customTextBoxPassword.TabIndex = 19;
            this.customTextBoxPassword.Texts = "PASSWORD";
            this.customTextBoxPassword.UnderlinedStyle = false;
            this.customTextBoxPassword.Click += new System.EventHandler(this.customTextboxPassword_Click);
            // 
            // customTextBoxUsername
            // 
            this.customTextBoxUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.customTextBoxUsername.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.customTextBoxUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxUsername.BorderSize = 2;
            this.customTextBoxUsername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBoxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxUsername.Location = new System.Drawing.Point(300, 452);
            this.customTextBoxUsername.Multiline = false;
            this.customTextBoxUsername.Name = "customTextBoxUsername";
            this.customTextBoxUsername.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxUsername.PasswordChar = false;
            this.customTextBoxUsername.Size = new System.Drawing.Size(292, 40);
            this.customTextBoxUsername.TabIndex = 18;
            this.customTextBoxUsername.Texts = "USERNAME";
            this.customTextBoxUsername.UnderlinedStyle = false;
            this.customTextBoxUsername.Click += new System.EventHandler(this.customTextboxUsername_Click);
            // 
            // customTextBoxNama
            // 
            this.customTextBoxNama.BackColor = System.Drawing.Color.PeachPuff;
            this.customTextBoxNama.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.customTextBoxNama.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBoxNama.BorderSize = 2;
            this.customTextBoxNama.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBoxNama.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxNama.Location = new System.Drawing.Point(300, 353);
            this.customTextBoxNama.Multiline = false;
            this.customTextBoxNama.Name = "customTextBoxNama";
            this.customTextBoxNama.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBoxNama.PasswordChar = false;
            this.customTextBoxNama.Size = new System.Drawing.Size(292, 40);
            this.customTextBoxNama.TabIndex = 17;
            this.customTextBoxNama.Texts = "NAME";
            this.customTextBoxNama.UnderlinedStyle = false;
            this.customTextBoxNama.Click += new System.EventHandler(this.customTextboxName_Click);
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(728, 552);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(311, 34);
            this.dateTimePickerTglLahir.TabIndex = 28;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 844);
            this.Controls.Add(this.panelFotoProfile);
            this.Controls.Add(this.labelProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProfile";
            this.Text = "TIXIE";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.Click += new System.EventHandler(this.FormProfile_Click);
            this.panelFotoProfile.ResumeLayout(false);
            this.panelFotoProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShowPasswork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPtofil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelNoTelp;
        private System.Windows.Forms.Button buttonUpdateChanges;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panelFotoProfile;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.PictureBox pictureBoxFotoPtofil;
        private System.Windows.Forms.Label labelBalanceValue;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelBirthDate;
        private CustomTextbox customTextBoxNoHp;
        private CustomTextbox customTextBoxEmail;
        private CustomTextbox customTextBoxPassword;
        private CustomTextbox customTextBoxUsername;
        private CustomTextbox customTextBoxNama;
        private System.Windows.Forms.Label labelNamaUser;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox buttonShowPasswork;
        private System.Windows.Forms.Label labelNominalSaldo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglLahir;
    }
}