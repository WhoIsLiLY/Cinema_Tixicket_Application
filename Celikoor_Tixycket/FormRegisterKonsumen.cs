using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormRegisterKonsumen : Form
    {
        public FormRegisterKonsumen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        #region Global Variable
        FormUtama formUtama;
        #endregion
        #region Events
        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
        }

        private void linkLabelAlreadyHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(formUtama.loginStatus != true)
            {
                formUtama.OpenForm(new FormLogin());
            }
            else
            {
                MessageBox.Show("Please logout first!");
            }
        }

        public void FormRegisterKonsumen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Konsumen konsumen = new Konsumen();
                konsumen.Nama = textBoxNameRegistration.Text;
                konsumen.Email = textBoxEmailAddressRegistration.Text;
                konsumen.NoHp = textBoxPhoneNumberRegistration.Text;
                konsumen.Saldo = (double)numericUpDownBalance.Value;
                
                if (radioButtonMale.Checked)
                {
                    konsumen.Gender = "L";
                }

                else
                {
                    konsumen.Gender = "P";
                }

                konsumen.TglLahir = dateTimePickerBirthDate.Value.ToString("yyyy-MM-dd");
                konsumen.Username = textBoxUsernameRegistration.Text;
                konsumen.Password = textBoxPasswordRegistration.Text;
                
                if (textBoxPasswordRegistrationConfirmation.Text != textBoxPasswordRegistration.Text)
                {
                    MessageBox.Show("Make sure to confirm the right password!");
                }

                else
                {
                    Konsumen.TambahData(konsumen);
                    MessageBox.Show("Registration success, you may proceed!");
                    formUtama.OpenForm(new FormMain());
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to Register! Error: " + ex.Message); 
            }
        }

        private void labelPINPassword_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
