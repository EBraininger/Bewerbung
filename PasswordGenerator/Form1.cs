using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {

        Password Zufall = new Password(5);
        List<string> speicher = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generiere_Click(object sender, EventArgs e)
        {
            if (Zahl.Text != string.Empty) 
            {

                Zufall.passwortln = Convert.ToInt32(textB1.Text);
                textB1.Text = Zufall.Generator(Zufall.passwortln);


            }
        }

        private void speichern_Click(object sender, EventArgs e)
        {

        }

        private void Anzeigen_Click(object sender, EventArgs e)
        {

        }

        private void textB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
