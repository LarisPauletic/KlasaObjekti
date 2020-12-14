using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlaseObjekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {

                Class osoba = new Class(txtUnosS.Text, Convert.ToInt32(txtUnosI.Text));

                txtIspis.Text = osoba.ToString;


            }
            catch(Exception greska)
            {
                MessageBox.Show("Greska", greska.Message);
            }
        }
    }
}
