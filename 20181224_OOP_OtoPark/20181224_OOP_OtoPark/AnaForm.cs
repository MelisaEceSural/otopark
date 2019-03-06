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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCombos();
            grpAracInfo.Visible = false;
        }

        void fillCombos()
        {
            cmbmarka.DataSource = Enum.GetValues(typeof(AracMarka));
            cmbSinif.DataSource = Enum.GetValues(typeof(AracSinifi));
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!txtPlaka.MaskFull)
            {
                MessageBox.Show("Lütfen doğru formatta plaka girin.");
                return;
            }

            string sehirKodu = txtPlaka.Text.Substring(0, 2);

            if (Convert.ToByte(sehirKodu) > 81 || Convert.ToByte(sehirKodu) < 1)
            {
                MessageBox.Show("Şehir plaka kodu 1-81 arasında olmalıdır.");
                return;
            }

            Arac girisYapan = new Arac();
            girisYapan.Plaka = txtPlaka.Text;
            girisYapan.Marka = (AracMarka)cmbmarka.SelectedItem;
            girisYapan.Tipi = AracTip.TipAl((AracSinifi)cmbSinif.SelectedItem);
            girisYapan.Abone = chkAbone.Checked;

            lstAraclar.Items.Add(girisYapan);

            txtPlaka.Text = "";
            cmbmarka.SelectedIndex = cmbSinif.SelectedIndex = 0;
            chkAbone.Checked = false;
            txtPlaka.Focus();
        }


        private void txtPlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedIndex == -1)
            {
                grpAracInfo.Visible = false;
                return;
            }
            grpAracInfo.Visible = true;
            Arac secilen = (Arac)lstAraclar.SelectedItem;
            secilen.Cikis = DateTime.Now;//Ücret hesaplanması için çıkış saati veriyorum, fakat araç çıkmış olmuyor.
            lblPlaka.Text = secilen.Plaka;
            lblMarka.Text = secilen.Marka.ToString();
            lblAbone.Text = secilen.Abone ? "Abone" : "Abone Değil";
            lblSure.Text = secilen.Sure.ToString() + " Saat";
            lblUcret.Text = secilen.Ucret.ToString("C2");
        }
        List<Arac> cikanAraclarListesi = new List<Arac>();
        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporForm rf = new RaporForm(cikanAraclarListesi);
            rf.ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null) return;

            Arac cikanArac = (Arac)lstAraclar.SelectedItem;

            DialogResult sonuc = MessageBox.Show(cikanArac.Plaka + " plakalı aracın çıkışını onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                cikanArac.Cikis = DateTime.Now;
                cikanAraclarListesi.Add(cikanArac);
                lstAraclar.Items.Remove(cikanArac);
            }
            else
                MessageBox.Show("İşlem iptal edildi.", "İPTAL", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cikis == DialogResult.No)
                e.Cancel = true;
            else
                Application.OpenForms["GirisForm"].Show();

        }
    }
}
