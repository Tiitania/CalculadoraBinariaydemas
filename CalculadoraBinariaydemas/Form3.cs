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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        int Dec;
        private void button1_Click(object sender, EventArgs e)
        {
            Dec = int.Parse(textBox1.Text);


            //Binario a decimal
            
            string basse= Convert.ToString(Dec,2);
            textBox2.Text = basse;
            string octa = Convert.ToString(Dec, 8);
            textBox3.Text = octa;
            string hexa = Convert.ToString(Dec, 16);
            textBox4.Text = hexa;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
