using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Televizioni
{
    public partial class frmRegjistroAbonimin : Form
    {
        public frmRegjistroAbonimin()
        {
            InitializeComponent();
        }

        private void cboLlojiProgramit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDataFillimit_Click(object sender, EventArgs e)
        {

        }

        private void frmRegjistroAbonimin_Load(object sender, EventArgs e)
        {

        }

        private void txtEmriProgramit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKthehu_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            RegjistroAbonimin a = new RegjistroAbonimin();
            a.NumriPersonal = Convert.ToInt32(txtNumriPersonal.Text);
            a.EmriAbonuesit = txtEmriAbonuesit.Text;
            a.MbiemriAbonuesit = txtMbiemriAbonuesit.Text;
            a.Adresa = txtAdresa.Text;
            a.Kontakti = Convert.ToInt32(txtKontakti.Text);
            a.llojet = cboPakoja.SelectedIndex;
            a.DataFillimit = dtpFillimi.Value;
            a.DataMbarimit = dtpMbarimi.Value;
            bool success = Televizioni.RegjistroProgramin(a);
            if (success == false)
                MessageBox.Show("Gabim në regjistrim të artikullit");
            this.txtNumriPersonal.Text = "";
            this.txtEmriAbonuesit.Text = "";
            this.txtMbiemriAbonuesit.Text = "";
            this.txtAdresa.Text = "";
            this.txtKontakti.Text = "";
       

            MessageBox.Show(a.Lista_Abonimeve, "Te Dhenat");
        }

        private void frmRegjistroAbonimin_Load_1(object sender, EventArgs e)
        {

        }

        private void txtMbiemriAbonuesit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmriAbonuesit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmriProgramit_Click(object sender, EventArgs e)
        {

        }

        private void lblLloji_Click(object sender, EventArgs e)
        {

        }

        private void lblShkurtesa_Click(object sender, EventArgs e)
        {

        }

        private void lblAbonimi_Click(object sender, EventArgs e)
        {

        }

        private void lblNumriProgramit_Click(object sender, EventArgs e)
        {

        }

        private void dtpMbarimi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNumriPersonal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
