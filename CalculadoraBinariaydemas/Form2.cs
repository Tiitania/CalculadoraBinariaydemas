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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        int binario;
        private void button1_Click(object sender, EventArgs e)
        {
            binario = int.Parse(textBox1.Text);


            //Binario a decimal
            int Decimal = Convert.ToInt32(binario.ToString(), 2);
            textBox2.Text = Convert.ToString(Decimal);
            //Binario a octal
            int octal = Convert.ToInt32(binario.ToString(), 2);
            textBox3.Text = Convert.ToString(octal, 8);
            //Binario a hexadecimal
            int hexa = Convert.ToInt32(binario.ToString(), 2);
            textBox4.Text = Convert.ToString(hexa, 16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
