using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20181224_OOP_OtoPark
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        int denemeSayisi = 0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtKullaniciAdi.Text.ToLower().Trim() == "admin" &&
                txtParola.Text.Trim() == "1234")
            {
                AnaForm anaForm = new AnaForm();
                txtKullaniciAdi.Text = txtParola.Text = "";
                denemeSayisi = 0;
                anaForm.Show();
                this.Hide();
            }
            else
            {
                denemeSayisi++;
                if (denemeSayisi == 3)
                {
                    MessageBox.Show("3. denemeniz de hatalı. Uygulama kapanıyor.");
                    Application.Exit();
                }

                if (txtKullaniciAdi.Text.ToLower().Trim() != "admin")
                    errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı Adı Hatalı.");
                if (txtParola.Text.Trim() != "1234")
                    errorProvider1.SetError(txtParola, "Parola Hatalı");

            }
        }
    }
}
