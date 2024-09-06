using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.linkLabelCreateAnAccount = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.timerImageMoving = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pageIndicator4 = new System.Windows.Forms.Button();
            this.pageIndicator3 = new System.Windows.Forms.Button();
            this.pageIndicator2 = new System.Windows.Forms.Button();
            this.pageIndicator1 = new System.Windows.Forms.Button();
            this.pictureBoxImages = new System.Windows.Forms.PictureBox();
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.radioButtonKonsumen = new System.Windows.Forms.RadioButton();
            this.labelLoginAs = new System.Windows.Forms.Label();
            this.radioButtonPegawai = new System.Windows.Forms.RadioButton();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.ForgotPassword = new System.Windows.Forms.Label();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelCreateAnAccount
            // 
            this.linkLabelCreateAnAccount.AutoSize = true;
            this.linkLabelCreateAnAccount.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateAnAccount.LinkColor = System.Drawing.Color.Peru;
            this.linkLabelCreateAnAccount.Location = new System.Drawing.Point(1116, 880);
            this.linkLabelCreateAnAccount.Name = "linkLabelCreateAnAccount";
            this.linkLabelCreateAnAccount.Size = new System.Drawing.Size(128, 33);
            this.linkLabelCreateAnAccount.TabIndex = 21;
            this.linkLabelCreateAnAccount.TabStop = true;
            this.linkLabelCreateAnAccount.Text = "Click Here";
            this.linkLabelCreateAnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateAnAccount_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Tan;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Azure;
            this.buttonLogin.Location = new System.Drawing.Point(828, 775);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(454, 54);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(829, 545);
            this.textBoxPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(444, 39);
            this.textBoxPasswordLogin.TabIndex = 12;
            this.textBoxPasswordLogin.Text = "Enter your password";
            this.textBoxPasswordLogin.WordWrap = false;
            this.textBoxPasswordLogin.Click += new System.EventHandler(this.textBoxPasswordLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(853, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 54);
            this.label1.TabIndex = 22;
            this.label1.Text = "WELCOME BACK";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Enabled = false;
            this.labelTo.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.Tan;
            this.labelTo.Location = new System.Drawing.Point(983, 181);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(55, 40);
            this.labelTo.TabIndex = 23;
            this.labelTo.Text = "to";
            // 
            // timerImageMoving
            // 
            this.timerImageMoving.Enabled = true;
            this.timerImageMoving.Interval = 6000;
            this.timerImageMoving.Tick += new System.EventHandler(this.timerImageMoving_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(857, 884);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Don\'t have an account?";
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Controls.Add(this.pageIndicator4);
            this.panelImage.Controls.Add(this.pageIndicator3);
            this.panelImage.Controls.Add(this.pageIndicator2);
            this.panelImage.Controls.Add(this.pageIndicator1);
            this.panelImage.Controls.Add(this.pictureBoxImages);
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(657, 1059);
            this.panelImage.TabIndex = 25;
            this.panelImage.Click += new System.EventHandler(this.panelImage_Click);
            // 
            // pageIndicator4
            // 
            this.pageIndicator4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator4.Enabled = false;
            this.pageIndicator4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageIndicator4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageIndicator4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator4.Location = new System.Drawing.Point(357, 1014);
            this.pageIndicator4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageIndicator4.Name = "pageIndicator4";
            this.pageIndicator4.Size = new System.Drawing.Size(26, 12);
            this.pageIndicator4.TabIndex = 32;
            this.pageIndicator4.UseVisualStyleBackColor = false;
            // 
            // pageIndicator3
            // 
            this.pageIndicator3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator3.Enabled = false;
            this.pageIndicator3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageIndicator3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageIndicator3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator3.Location = new System.Drawing.Point(324, 1014);
            this.pageIndicator3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageIndicator3.Name = "pageIndicator3";
            this.pageIndicator3.Size = new System.Drawing.Size(26, 12);
            this.pageIndicator3.TabIndex = 31;
            this.pageIndicator3.UseVisualStyleBackColor = false;
            // 
            // pageIndicator2
            // 
            this.pageIndicator2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator2.Enabled = false;
            this.pageIndicator2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageIndicator2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageIndicator2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.pageIndicator2.Location = new System.Drawing.Point(291, 1014);
            this.pageIndicator2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageIndicator2.Name = "pageIndicator2";
            this.pageIndicator2.Size = new System.Drawing.Size(26, 12);
            this.pageIndicator2.TabIndex = 30;
            this.pageIndicator2.UseVisualStyleBackColor = false;
            // 
            // pageIndicator1
            // 
            this.pageIndicator1.BackColor = System.Drawing.Color.DarkOrange;
            this.pageIndicator1.Enabled = false;
            this.pageIndicator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageIndicator1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageIndicator1.ForeColor = System.Drawing.Color.DarkOrange;
            this.pageIndicator1.Location = new System.Drawing.Point(259, 1014);
            this.pageIndicator1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pageIndicator1.Name = "pageIndicator1";
            this.pageIndicator1.Size = new System.Drawing.Size(26, 12);
            this.pageIndicator1.TabIndex = 29;
            this.pageIndicator1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxImages
            // 
            this.pictureBoxImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImages.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImages.Image")));
            this.pictureBoxImages.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxImages.Name = "pictureBoxImages";
            this.pictureBoxImages.Size = new System.Drawing.Size(657, 1059);
            this.pictureBoxImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImages.TabIndex = 33;
            this.pictureBoxImages.TabStop = false;
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.AccessibleDescription = "";
            this.textBoxUsernameLogin.AccessibleName = "";
            this.textBoxUsernameLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameLogin.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(829, 446);
            this.textBoxUsernameLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(444, 39);
            this.textBoxUsernameLogin.TabIndex = 1;
            this.textBoxUsernameLogin.Text = "Enter your username";
            this.textBoxUsernameLogin.Click += new System.EventHandler(this.textBoxUsernameLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelPassword.Location = new System.Drawing.Point(824, 505);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(169, 34);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelUsername.Location = new System.Drawing.Point(824, 406);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(176, 34);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::Celikoor_Tixycket.Properties.Resources.title;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Enabled = false;
            this.pictureBoxLogo.Location = new System.Drawing.Point(842, 181);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(417, 149);
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            // 
            // radioButtonKonsumen
            // 
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.BackColor = System.Drawing.Color.FloralWhite;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.ForeColor = System.Drawing.Color.LightSlateGray;
            this.radioButtonKonsumen.Location = new System.Drawing.Point(990, 628);
            this.radioButtonKonsumen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(149, 33);
            this.radioButtonKonsumen.TabIndex = 49;
            this.radioButtonKonsumen.TabStop = true;
            this.radioButtonKonsumen.Text = "Customer";
            this.radioButtonKonsumen.UseVisualStyleBackColor = false;
            this.radioButtonKonsumen.CheckedChanged += new System.EventHandler(this.radioButtonKonsumen_CheckedChanged);
            // 
            // labelLoginAs
            // 
            this.labelLoginAs.AutoSize = true;
            this.labelLoginAs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginAs.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelLoginAs.Location = new System.Drawing.Point(822, 628);
            this.labelLoginAs.Name = "labelLoginAs";
            this.labelLoginAs.Size = new System.Drawing.Size(142, 29);
            this.labelLoginAs.TabIndex = 50;
            this.labelLoginAs.Text = "Login as :";
            // 
            // radioButtonPegawai
            // 
            this.radioButtonPegawai.AutoSize = true;
            this.radioButtonPegawai.BackColor = System.Drawing.Color.FloralWhite;
            this.radioButtonPegawai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPegawai.ForeColor = System.Drawing.Color.LightSlateGray;
            this.radioButtonPegawai.Location = new System.Drawing.Point(1144, 628);
            this.radioButtonPegawai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPegawai.Name = "radioButtonPegawai";
            this.radioButtonPegawai.Size = new System.Drawing.Size(151, 33);
            this.radioButtonPegawai.TabIndex = 51;
            this.radioButtonPegawai.TabStop = true;
            this.radioButtonPegawai.Text = "Employee";
            this.radioButtonPegawai.UseVisualStyleBackColor = false;
            this.radioButtonPegawai.CheckedChanged += new System.EventHandler(this.radioButtonPegawai_CheckedChanged);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.ForeColor = System.Drawing.Color.LightSlateGray;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(828, 716);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(217, 33);
            this.checkBoxRememberMe.TabIndex = 26;
            this.checkBoxRememberMe.Text = "Remember me?";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.Click += new System.EventHandler(this.checkBoxRememberMe_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword.ForeColor = System.Drawing.Color.LightSlateGray;
            this.ForgotPassword.Location = new System.Drawing.Point(1076, 718);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(225, 29);
            this.ForgotPassword.TabIndex = 27;
            this.ForgotPassword.Text = "Forgot Password?";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1418, 1055);
            this.Controls.Add(this.radioButtonPegawai);
            this.Controls.Add(this.labelLoginAs);
            this.Controls.Add(this.radioButtonKonsumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelCreateAnAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxUsernameLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "TIXIE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Click += new System.EventHandler(this.FormLogin_Click);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelCreateAnAccount;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUsernameLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Timer timerImageMoving;
        private System.Windows.Forms.Label label2;
        private Button pageIndicator4;
        private Button pageIndicator3;
        private Button pageIndicator2;
        private Button pageIndicator1;
        private Label labelPassword;
        private Label labelUsername;
        private RadioButton radioButtonKonsumen;
        private Label labelLoginAs;
        private RadioButton radioButtonPegawai;
        private PictureBox pictureBoxImages;
        private CheckBox checkBoxRememberMe;
        private Label ForgotPassword;
    }
}