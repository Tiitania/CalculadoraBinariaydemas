using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBinariaydemas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string hexa,octa,dec;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            hexa= Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 2);
            textBox4.Text = hexa;

            octa = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 8);
            textBox3.Text = octa;

            dec = Convert.ToString(Convert.ToInt32(textBox1.Text, 16));
            textBox2.Text = dec;



        }
    }
}
