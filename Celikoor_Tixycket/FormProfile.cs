using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }
        FormUtama formUtama;

        private void FormProfile_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
            if (formUtama.konsumenLogin is Konsumen)
            {
                List<Konsumen> listDataKonsumen = Konsumen.BacaData("id", formUtama.konsumenLogin.Id.ToString());
                labelNamaUser.Text = listDataKonsumen[0].Username;
                labelNominalSaldo.Text = listDataKonsumen[0].Saldo.ToString();
                customTextBoxNama.Texts = listDataKonsumen[0].Nama;
                customTextBoxUsername.Texts = listDataKonsumen[0].Username;
                customTextBoxPassword.Texts = listDataKonsumen[0].Password;
                customTextBoxEmail.Texts = listDataKonsumen[0].Email;
                customTextBoxNoHp.Texts = listDataKonsumen[0].NoHp;
                dateTimePickerTglLahir.Value = DateTime.Parse(listDataKonsumen[0].TglLahir);
            }
        }

        private void customTextboxName_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxNama.UnderlinedStyle = true;
        }

        private void customTextboxEmail_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxEmail.UnderlinedStyle = true;
        }

        private void customTextboxUsername_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxUsername.UnderlinedStyle = true;
        }

        private void customTextboxPhoneNumber_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxNoHp.UnderlinedStyle = true;
        }

        private void customTextboxPassword_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxPassword.UnderlinedStyle = true;
        }

        private void customTextboxBirthDate_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }
        private void DisableUnderlineStyle()
        {
            foreach (CustomTextbox customTextbox in panelFotoProfile.Controls.OfType<CustomTextbox>())
            {
                customTextbox.UnderlinedStyle = false;
            }
        }

        private void FormProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void panelFotoProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void buttonEditProfilePicture_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdateChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Konsumen konsumen = new Konsumen();
                konsumen.Id = formUtama.konsumenLogin.Id;
                konsumen.Nama = customTextBoxNama.Texts;
                konsumen.Username = customTextBoxUsername.Texts;
                konsumen.Password = customTextBoxPassword.Texts;
                konsumen.Email = customTextBoxEmail.Texts;
                konsumen.NoHp = customTextBoxNoHp.Texts;
                konsumen.TglLahir = dateTimePickerTglLahir.Value.ToString("yyyy-MM-dd");

                Konsumen.UbahData(konsumen);

                MessageBox.Show("Success to update your profile changes!");
                FormProfile_Load(this, e);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to update your profile changes! Error: " + ex.Message);
            }
        }

        private void buttonShowPasswork_Click(object sender, EventArgs e)
        {
            if (customTextBoxPassword.PasswordChar)
            {
                customTextBoxPassword.PasswordChar = false;
            }
            else
            {
                customTextBoxPassword.PasswordChar = true;
            }
        }

        private void panelFotoProfile_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
