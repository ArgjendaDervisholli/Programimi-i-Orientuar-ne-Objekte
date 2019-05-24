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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegjistroProgramin frm = new frmRegjistroProgramin();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Televizioni.Programi = new List<RegjistroProgramin>();
            Televizioni.Abonimi = new List<RegjistroAbonimin>();
          
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegjistroAbonimin frm = new frmRegjistroAbonimin();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            RegjistroProgramin prog = new RegjistroProgramin();
            string b = "";
            foreach (RegjistroProgramin p in Televizioni.Programi)
            {
                if (p.NumriProgramit != 0)
                {
                    
                    b = b + p.NumriProgramit.ToString() + " Emri i Programit : "+ p.EmriProgramit.ToString() + "  Shkurtesa : " + p.Shkurtesa.ToString() +" LLoji :  "+ (RegjistroProgramin.lloji)p.llojet  + Environment.NewLine;

                }
            }
            MessageBox.Show( b ,"Lista e programeve",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (RegjistroProgramin item in Televizioni.Programi)
            {
                if (item.NumriPersonal != 0)
                {
                    s += item.Lista_Abonimeve + "\n\n";
                }
            }
            MessageBox.Show(s, "Lista e abonimeve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegjistroProgramin.G objGrupi = new RegjistroProgramin.G();
            lblGrupi.Text = objGrupi.grupi5();
        }
    }
}
