using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebastian_Krnjus_PPZ2
{
    public partial class Form1 : Form
    {
        List<Gazirana> listGazirana = new List<Gazirana>();
        List<Negazirana> listnegazirana = new List<Negazirana>();
        List<Alkoholna> listAlkoholna = new List<Alkoholna>();
        public Form1()
        {
            InitializeComponent();
        }

        private void rbGazirana_CheckedChanged(object sender, EventArgs e)
        {
            lblAlkohol.Visible = false;
            trckAlkohol.Visible = false;
        }

        private void rbNegazirana_CheckedChanged(object sender, EventArgs e)
        {
            lblAlkohol.Visible = false;
            trckAlkohol.Visible = false;
        }

        private void rbAlkoholna_CheckedChanged(object sender, EventArgs e)
        {
            lblAlkohol.Visible = true;
            trckAlkohol.Visible = true;
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (rbGazirana.Checked)
            {
                Gazirana gazirana = new Gazirana(txtBoxNaziv.Text, cmbPakiranje.Text, cmbKolicina.Text, Convert.ToDouble(txtBoxCijena.Text));
               listGazirana.Add(gazirana);
                MessageBox.Show("Unos je uspješan", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbNegazirana.Checked)
            {
                Negazirana negazirana = new Negazirana(txtBoxNaziv.Text, cmbPakiranje.Text, cmbKolicina.Text, Convert.ToDouble(txtBoxCijena.Text));
                listnegazirana.Add(negazirana);
                MessageBox.Show("Unos je uspješan", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbAlkoholna.Checked)
            {
                Alkoholna alkoholna = new Alkoholna(txtBoxNaziv.Text, cmbPakiranje.Text, cmbKolicina.Text, Convert.ToDouble(txtBoxCijena.Text) ,trckAlkohol.Value);
                listAlkoholna.Add(alkoholna);
                MessageBox.Show("Unos je uspješan", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtBoxNaziv.Clear();
            txtBoxCijena.Clear();
           
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
           rtbIspis.Clear();
            rtbIspis.AppendText(Environment.NewLine + "Gazirana pića: " + Environment.NewLine);
            foreach (Gazirana gazirana in listGazirana)
            {
                rtbIspis.AppendText(gazirana.ToString());
                rtbIspis.AppendText(Environment.NewLine);
            }
            rtbIspis.AppendText(Environment.NewLine + "Negazirana pića: " + Environment.NewLine);
            foreach (Negazirana negazirana in listnegazirana)
            {
                rtbIspis.AppendText(negazirana.ToString());
                rtbIspis.AppendText(Environment.NewLine);
            }
            rtbIspis.AppendText(Environment.NewLine + "Alkoholna pića: " + Environment.NewLine);
            foreach (Alkoholna alkoholna in listAlkoholna)
            {
                rtbIspis.AppendText(alkoholna.ToString());
                rtbIspis.AppendText(Environment.NewLine);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trckAlkohol_Scroll(object sender, EventArgs e)
        {
          lblAlk.Text = Convert.ToString(trckAlkohol.Value);
        }
    }
}
