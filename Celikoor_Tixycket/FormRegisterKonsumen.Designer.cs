namespace Celikoor_Tixycket
{
    partial class FormRegisterKonsumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterKonsumen));
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTglLahir = new System.Windows.Forms.Label();
            this.linkLabelAlreadyHaveAnAccount = new System.Windows.Forms.LinkLabel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Button();
            this.labelNoHp = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxNameRegistration = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddressRegistration = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRegistrationConfirmation = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRegistration = new System.Windows.Forms.TextBox();
            this.textBoxUsernameRegistration = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumberRegistration = new System.Windows.Forms.TextBox();
            this.labelAlreadyHaveAccount = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.numericUpDownBalance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.White;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelPassword.Location = new System.Drawing.Point(986, 522);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(125, 25);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPINPassword_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.White;
            this.labelUsername.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelUsername.Location = new System.Drawing.Point(986, 430);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(130, 25);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // labelTglLahir
            // 
            this.labelTglLahir.AutoSize = true;
            this.labelTglLahir.BackColor = System.Drawing.Color.White;
            this.labelTglLahir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglLahir.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelTglLahir.Location = new System.Drawing.Point(986, 341);
            this.labelTglLahir.Name = "labelTglLahir";
            this.labelTglLahir.Size = new System.Drawing.Size(166, 25);
            this.labelTglLahir.TabIndex = 12;
            this.labelTglLahir.Text = "Date Of Birth";
            // 
            // linkLabelAlreadyHaveAnAccount
            // 
            this.linkLabelAlreadyHaveAnAccount.AutoSize = true;
            this.linkLabelAlreadyHaveAnAccount.BackColor = System.Drawing.Color.White;
            this.linkLabelAlreadyHaveAnAccount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAlreadyHaveAnAccount.LinkColor = System.Drawing.Color.Peru;
            this.linkLabelAlreadyHaveAnAccount.Location = new System.Drawing.Point(1069, 864);
            this.linkLabelAlreadyHaveAnAccount.Name = "linkLabelAlreadyHaveAnAccount";
            this.linkLabelAlreadyHaveAnAccount.Size = new System.Drawing.Size(111, 24);
            this.linkLabelAlreadyHaveAnAccount.TabIndex = 15;
            this.linkLabelAlreadyHaveAnAccount.TabStop = true;
            this.linkLabelAlreadyHaveAnAccount.Text = "Click Here";
            this.linkLabelAlreadyHaveAnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAlreadyHaveAnAccount_LinkClicked);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.White;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelEmail.Location = new System.Drawing.Point(544, 430);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(177, 25);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email Address";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerBirthDate.CalendarTitleBackColor = System.Drawing.Color.SeaShell;
            this.dateTimePickerBirthDate.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(990, 376);
            this.dateTimePickerBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(379, 26);
            this.dateTimePickerBirthDate.TabIndex = 18;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.White;
            this.labelNama.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelNama.Location = new System.Drawing.Point(544, 346);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(80, 25);
            this.labelNama.TabIndex = 19;
            this.labelNama.Text = "Name";
            // 
            // labelSignUp
            // 
            this.labelSignUp.BackColor = System.Drawing.Color.Tan;
            this.labelSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSignUp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.Azure;
            this.labelSignUp.Location = new System.Drawing.Point(772, 780);
            this.labelSignUp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(434, 58);
            this.labelSignUp.TabIndex = 33;
            this.labelSignUp.Text = "&SIGN UP";
            this.labelSignUp.UseVisualStyleBackColor = false;
            this.labelSignUp.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelNoHp
            // 
            this.labelNoHp.AutoSize = true;
            this.labelNoHp.BackColor = System.Drawing.Color.White;
            this.labelNoHp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoHp.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelNoHp.Location = new System.Drawing.Point(544, 522);
            this.labelNoHp.Name = "labelNoHp";
            this.labelNoHp.Size = new System.Drawing.Size(186, 25);
            this.labelNoHp.TabIndex = 34;
            this.labelNoHp.Text = "Phone Number";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.BackColor = System.Drawing.Color.White;
            this.labelGenre.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelGenre.Location = new System.Drawing.Point(544, 705);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(102, 26);
            this.labelGenre.TabIndex = 35;
            this.labelGenre.Text = "Gender";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelConfirmPassword.Location = new System.Drawing.Point(986, 606);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(224, 25);
            this.labelConfirmPassword.TabIndex = 36;
            this.labelConfirmPassword.Text = "Confirm Password";
            this.labelConfirmPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNameRegistration
            // 
            this.textBoxNameRegistration.BackColor = System.Drawing.Color.White;
            this.textBoxNameRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameRegistration.ForeColor = System.Drawing.Color.Black;
            this.textBoxNameRegistration.Location = new System.Drawing.Point(549, 376);
            this.textBoxNameRegistration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxNameRegistration.Name = "textBoxNameRegistration";
            this.textBoxNameRegistration.Size = new System.Drawing.Size(379, 35);
            this.textBoxNameRegistration.TabIndex = 37;
            // 
            // textBoxEmailAddressRegistration
            // 
            this.textBoxEmailAddressRegistration.BackColor = System.Drawing.Color.White;
            this.textBoxEmailAddressRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailAddressRegistration.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmailAddressRegistration.Location = new System.Drawing.Point(549, 460);
            this.textBoxEmailAddressRegistration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxEmailAddressRegistration.Name = "textBoxEmailAddressRegistration";
            this.textBoxEmailAddressRegistration.Size = new System.Drawing.Size(379, 35);
            this.textBoxEmailAddressRegistration.TabIndex = 38;
            // 
            // textBoxPasswordRegistrationConfirmation
            // 
            this.textBoxPasswordRegistrationConfirmation.BackColor = System.Drawing.Color.White;
            this.textBoxPasswordRegistrationConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordRegistrationConfirmation.ForeColor = System.Drawing.Color.Black;
            this.textBoxPasswordRegistrationConfirmation.Location = new System.Drawing.Point(990, 636);
            this.textBoxPasswordRegistrationConfirmation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxPasswordRegistrationConfirmation.Name = "textBoxPasswordRegistrationConfirmation";
            this.textBoxPasswordRegistrationConfirmation.Size = new System.Drawing.Size(379, 35);
            this.textBoxPasswordRegistrationConfirmation.TabIndex = 43;
            this.textBoxPasswordRegistrationConfirmation.UseSystemPasswordChar = true;
            // 
            // textBoxPasswordRegistration
            // 
            this.textBoxPasswordRegistration.BackColor = System.Drawing.Color.White;
            this.textBoxPasswordRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordRegistration.ForeColor = System.Drawing.Color.Black;
            this.textBoxPasswordRegistration.Location = new System.Drawing.Point(990, 552);
            this.textBoxPasswordRegistration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxPasswordRegistration.Name = "textBoxPasswordRegistration";
            this.textBoxPasswordRegistration.Size = new System.Drawing.Size(379, 35);
            this.textBoxPasswordRegistration.TabIndex = 44;
            this.textBoxPasswordRegistration.UseSystemPasswordChar = true;
            // 
            // textBoxUsernameRegistration
            // 
            this.textBoxUsernameRegistration.BackColor = System.Drawing.Color.White;
            this.textBoxUsernameRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameRegistration.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsernameRegistration.Location = new System.Drawing.Point(990, 460);
            this.textBoxUsernameRegistration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxUsernameRegistration.Name = "textBoxUsernameRegistration";
            this.textBoxUsernameRegistration.Size = new System.Drawing.Size(379, 35);
            this.textBoxUsernameRegistration.TabIndex = 45;
            // 
            // textBoxPhoneNumberRegistration
            // 
            this.textBoxPhoneNumberRegistration.BackColor = System.Drawing.Color.White;
            this.textBoxPhoneNumberRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumberRegistration.ForeColor = System.Drawing.Color.Black;
            this.textBoxPhoneNumberRegistration.Location = new System.Drawing.Point(549, 552);
            this.textBoxPhoneNumberRegistration.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxPhoneNumberRegistration.Name = "textBoxPhoneNumberRegistration";
            this.textBoxPhoneNumberRegistration.Size = new System.Drawing.Size(379, 35);
            this.textBoxPhoneNumberRegistration.TabIndex = 46;
            // 
            // labelAlreadyHaveAccount
            // 
            this.labelAlreadyHaveAccount.AutoSize = true;
            this.labelAlreadyHaveAccount.BackColor = System.Drawing.Color.White;
            this.labelAlreadyHaveAccount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlreadyHaveAccount.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelAlreadyHaveAccount.Location = new System.Drawing.Point(786, 864);
            this.labelAlreadyHaveAccount.Name = "labelAlreadyHaveAccount";
            this.labelAlreadyHaveAccount.Size = new System.Drawing.Size(277, 24);
            this.labelAlreadyHaveAccount.TabIndex = 47;
            this.labelAlreadyHaveAccount.Text = "Already Have an Account?";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.Color.White;
            this.radioButtonMale.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.ForeColor = System.Drawing.Color.LightSlateGray;
            this.radioButtonMale.Location = new System.Drawing.Point(677, 704);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(83, 30);
            this.radioButtonMale.TabIndex = 48;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.Color.White;
            this.radioButtonFemale.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.ForeColor = System.Drawing.Color.LightSlateGray;
            this.radioButtonFemale.Location = new System.Drawing.Point(806, 704);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(110, 30);
            this.radioButtonFemale.TabIndex = 49;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Celikoor_Tixycket.Properties.Resources.title_verti;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(124, 65);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 654);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Celikoor_Tixycket.Properties.Resources.templateRegistration;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(262, -184);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1488, 1312);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(668, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(666, 59);
            this.label5.TabIndex = 53;
            this.label5.Text = "Welcome to Celikoor21!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(633, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(749, 59);
            this.label6.TabIndex = 54;
            this.label6.Text = "Let\'s begin your adventure";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.BackColor = System.Drawing.Color.White;
            this.labelSaldo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelSaldo.Location = new System.Drawing.Point(544, 606);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(104, 25);
            this.labelSaldo.TabIndex = 55;
            this.labelSaldo.Text = "Balance";
            // 
            // numericUpDownBalance
            // 
            this.numericUpDownBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBalance.Location = new System.Drawing.Point(549, 638);
            this.numericUpDownBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownBalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownBalance.Name = "numericUpDownBalance";
            this.numericUpDownBalance.Size = new System.Drawing.Size(379, 35);
            this.numericUpDownBalance.TabIndex = 56;
            // 
            // FormRegisterKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1642, 1055);
            this.Controls.Add(this.numericUpDownBalance);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.labelAlreadyHaveAccount);
            this.Controls.Add(this.textBoxPhoneNumberRegistration);
            this.Controls.Add(this.textBoxUsernameRegistration);
            this.Controls.Add(this.textBoxPasswordRegistration);
            this.Controls.Add(this.textBoxPasswordRegistrationConfirmation);
            this.Controls.Add(this.textBoxEmailAddressRegistration);
            this.Controls.Add(this.textBoxNameRegistration);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelNoHp);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.linkLabelAlreadyHaveAnAccount);
            this.Controls.Add(this.labelTglLahir);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegisterKonsumen";
            this.Text = "TIXIE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegisterKonsumen_FormClosing);
            this.Load += new System.EventHandler(this.FormRegisterKonsumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTglLahir;
        private System.Windows.Forms.LinkLabel linkLabelAlreadyHaveAnAccount;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button labelSignUp;
        private System.Windows.Forms.Label labelNoHp;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxNameRegistration;
        private System.Windows.Forms.TextBox textBoxEmailAddressRegistration;
        private System.Windows.Forms.TextBox textBoxPasswordRegistrationConfirmation;
        private System.Windows.Forms.TextBox textBoxPasswordRegistration;
        private System.Windows.Forms.TextBox textBoxUsernameRegistration;
        private System.Windows.Forms.TextBox textBoxPhoneNumberRegistration;
        private System.Windows.Forms.Label labelAlreadyHaveAccount;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.NumericUpDown numericUpDownBalance;
    }
}