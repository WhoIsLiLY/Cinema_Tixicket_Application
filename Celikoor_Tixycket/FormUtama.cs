using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Tixycket
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;
        public FormRegisterKonsumen formRegisterKonsumen;
        public FormLogin formLogin;
        public Film film; // untuk transaksi
        public FormPemesananTiket formPemesananTiket;
        public bool loginStatus = false;

        bool sidebarExpand = true;
        bool masterSection = false;
        bool systemSection = false;

        #region menu master
        private void buttonMaster_Click(object sender, EventArgs e)
        {
            timerMasterExpand.Start();
        }

        private void buttonCinema_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterCinema());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonCinema);
        }

        private void buttonStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterStudio());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonStudio);
        }

        private void buttonJenisStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterJenisStudio());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonJenisStudio);
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterGenre());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonGenre);
        }

        private void buttonAktors_Click(object sender, EventArgs e)
        {
            OpenForm (new FormMasterAktor());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonAktors);
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterPegawai());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonPegawai);
        }

        private void buttonKelompok_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterKelompok());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonKelompok);
        }
        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterKonsumen());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonCustomer);
        }
        private void buttonProfile_Click(object sender, EventArgs e)
        {
            if(loginStatus == true)
            {
                OpenForm(new FormProfile());
            }
            else
            {
                MessageBox.Show("Please log in first!");
            }
        }
        public void buttonTransaction_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPemesananTiket());
        }
        #endregion

        #region menu system
        private void buttonSystem_Click(object sender, EventArgs e)
        {
            timerSystemExpand.Start();
        }

        private void buttonPenjadwalanFilm_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPenjadwalanFilm());
        }

        private void buttonPencatatanKedatangan_Click(object sender, EventArgs e)
        {
            OpenForm(new FormOperator());
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            OpenForm(new FormPrint());
        }
        #endregion

        #region methods
        private Form formActive = null;
        private void DefaultTextBoxForeColor(Panel panelControl)
        {
            foreach(Button button in panelMaster.Controls.OfType<Button>())
            {
                button.ForeColor = Color.White;
            }
        }
        private void ChangeForeColor(Button buttonControl)
        {
            buttonControl.ForeColor = Color.DarkSlateGray;
        }
        public void OpenForm(Form form)
        {
            form.Owner = this;
            if (formActive != null)
            {
                formActive.Close();
            }
            formActive = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        public void LoginConstraint(bool status, string text)
        {
            buttonLogInOut.Enabled = status;
            buttonLogInOut.Text = text;
            panelButtonMaster.Enabled = status;
            panelButtonSystem.Enabled = status;
        }

        private void AturMenu()
        {
            if (pegawaiLogin != null)
            {
                if (pegawaiLogin.Role == "ADMIN")
                {
                    panelButtonMaster.Visible = true;
                    panelButtonSystem.Visible = true;
                    panelButtonTransaction.Visible = false; // +-+
                    panelButtonTransaction.Enabled = false;
                    buttonPencatatanKedatangan.Enabled = false;
                    buttonMenu.Enabled = false;
                }
                else if (pegawaiLogin.Role == "OPERATOR")
                {
                    panelButtonMaster.Visible = false;
                    panelButtonSystem.Visible = true;
                    buttonKasir.Enabled = false;
                    buttonPenjadwalanFilm.Enabled = false;
                    buttonLaporan.Enabled = false;
                    panelButtonTransaction.Visible = false; // +-+
                    buttonMenu.Enabled = false;
                }
                else if (pegawaiLogin.Role == "KASIR")
                {
                    panelButtonMaster.Visible = false;
                    panelButtonSystem.Visible = true;
                    buttonPencatatanKedatangan.Enabled = false;
                    buttonPenjadwalanFilm.Enabled = false;
                    buttonLaporan.Enabled = false;
                    panelButtonTransaction.Visible = false; // +-+
                    buttonMenu.Enabled = false;
                }
                else
                {
                    panelButtonMaster.Visible = false;
                    panelButtonSystem.Visible = true;
                    buttonKasir.Enabled = false;
                    buttonPenjadwalanFilm.Enabled = false;
                    buttonPencatatanKedatangan.Enabled = false;
                    buttonLaporan.Enabled = false;
                    panelButtonTransaction.Visible = false; // +-+
                }
            }
            else if (konsumenLogin != null)
            {
                panelButtonTransaction.Enabled = true;
                panelButtonTransaction.Visible = true;
            }
            else
            {
                panelButtonMaster.Enabled = true;
                panelSystem.Enabled = true;
                panelButtonTransaction.Enabled = true;
                buttonPencatatanKedatangan.Enabled = true;
                buttonPenjadwalanFilm.Enabled = true;
                buttonLaporan.Enabled = true;
                buttonKasir.Enabled = true;
                buttonMenu.Enabled = true;
            }
        }
        #endregion

        private void FormUtama1_Load(object sender, EventArgs e)
        {
            panelButtonMaster.Visible = false;
            panelMaster.Height = 0;
            panelButtonSystem.Visible = false;
            panelSystem.Height = 0;
            panelButtonTransaction.Visible = false;
            OpenForm(new FormMain());
        }

        public void LoginSetUp(object sender, EventArgs e)
        {
            if (loginStatus == false)
            {
                Form form = Application.OpenForms["FormLogin"];
                LoginConstraint(false, "In Progress");

                if (form == null)
                {
                    formLogin= new FormLogin();
                    formLogin.Owner = this;

                    OpenForm(formLogin);
                }

                else
                {
                    form.Show();
                    form.BringToFront();
                }
            }

            else
            {
                loginStatus = false;
                buttonLogInOut.Text = "Log in";
                konsumenLogin = null;
                pegawaiLogin = null;
                panelLogoApp.Visible = true;
                panelForm.Controls.Clear();
                FormUtama1_Load(sender, e);
                buttonProfile.Text = "                 Not logged in";
                MessageBox.Show("Anda Berhasil Log Out!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AturMenu();
            }
        }

        public void SetUIAfterLogin()
        {
            if (konsumenLogin != null)
            {
                buttonProfile.Text = "                 " + konsumenLogin.Nama;
            }

            else if (pegawaiLogin != null)
            {
                buttonProfile.Text = "                 " + pegawaiLogin.Nama;
                panelLogoApp.Visible = false;
            }

            AturMenu();
        }


        private void panelSystem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerSideMenuExpand_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelMenu.Width -= 8;
                if(panelMenu.Width <= 81)
                {
                    timerSideMenuExpand.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                panelMenu.Width += 8;
                if (panelMenu.Width >= panelMenu.MaximumSize.Width)
                {
                    timerSideMenuExpand.Stop();
                    sidebarExpand = true;
                }
            }
        }

        private void timerMasterExpand_Tick(object sender, EventArgs e)
        {
            if (masterSection)
            {
                panelMaster.Height -= 15;
                if (panelMaster.Height<= 0)
                {
                    timerMasterExpand.Stop();
                    masterSection = false;
                }
            }
            else
            {
                panelMaster.Height += 15;
                if (panelMaster.Height >= panelMaster.MaximumSize.Height)
                {
                    timerMasterExpand.Stop();
                    masterSection = true;
                }
            }
        }
        private void timerSystemExpand_Tick(object sender, EventArgs e)
        {
            if (systemSection)
            {
                panelSystem.Height -= 15;
                if (panelSystem.Height <= 0)
                {
                    timerSystemExpand.Stop();
                    systemSection = false;
                }
            }
            else
            {
                panelSystem.Height += 15;
                if (panelSystem.Height >= panelSystem.MaximumSize.Height)
                {
                    timerSystemExpand.Stop();
                    systemSection = true;
                }
            }
        }
        private void buttonSideMenu_Click(object sender, EventArgs e)
        {
            timerSideMenuExpand.Start();
        }

        private void pictureBoxMaster_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxStudio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGenre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxActors_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxEmployee_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMain());
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonFilm_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterFilm());
        }

        private void buttonKasir_Click(object sender, EventArgs e)
        {
            OpenForm(new FormKasir());
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FormMasterMenu());
        }
    }
}
