using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {

        const String constantaCNP = "279146358279";
        const int lungimeCNP = 13;

        public Form1()
        {
            InitializeComponent();
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(numeTB.Text))
            {
                MessageBox.Show("Nume incorect!\n");
                return;
            }
            if(!validareCNP())
            {
                MessageBox.Show("CNP incorect!\n");
                return;
            }


            Grila gr = new Grila(numeTB.Text, cnpTB.Text);
            gr.Show();
            gr.Focus();
            gr.parentForm = this;

            this.Hide();
        }

        bool validareCNP()
        {
            String cnp = cnpTB.Text;

            if (String.IsNullOrWhiteSpace(cnp) || cnp.Length != lungimeCNP) return false;

            int sum = 0;

            for (int i = 0; i < constantaCNP.Length; i++)
            {
                sum += (int.Parse(cnp[i].ToString()) * int.Parse(constantaCNP[i].ToString()));
            }

            int control = (sum % 11 > 9) ? 1 : sum % 11;

            if (control != int.Parse(cnp[cnp.Length - 1].ToString())) return false;

            return true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
