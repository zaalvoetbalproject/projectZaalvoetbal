using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Fifa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void scoreTeam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void scoreTeam2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gambleButton_Click(object sender, EventArgs e)
        {
            string temp = (nameInput.Text + " voorspelt dat de uitslag van wedstrijd " + matchInput.Text + " " + scoreTeam1.Value + " - " + scoreTeam2.Value + " zal zijn, met " + winnerInput.Text + " als winnaar.");
            predictionsBox.Items.Add(temp);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
