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
    public partial class frmRegjistroProgramin : Form
    {
        public frmRegjistroProgramin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {

            RegjistroProgramin tv = new RegjistroProgramin();
            tv.NumriProgramit = Convert.ToInt32(txtNumriProgramit.Text);
            tv.EmriProgramit = txtEmriProgramit.Text;
            tv.Shkurtesa = txtShkurtesa.Text;
            tv.llojet = cboGrupi.SelectedIndex;
            bool success = Televizioni.RegjistroProgramin(tv);
            if (success == false)
                MessageBox.Show("Gabim në regjistrim të artikullit");
            this. txtNumriProgramit.Text = "";
            this.txtEmriProgramit.Text = "";
            this.txtShkurtesa.Text = "";
            MessageBox.Show(tv.lista_Programeve, "Te Dhenat");

        }



        private void cboLlojiProgramit_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnKthehu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegjistroProgramin_Load(object sender, EventArgs e)
        {

        }

        private void cboGrupi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtShkurtesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmriProgramit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
