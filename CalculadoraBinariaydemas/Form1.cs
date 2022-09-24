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
    public partial class Form1 : Form
    {
      
       Form a = new Form2();
        Form Dec = new Form3();
        Form Oct = new Form4();
        Form Hex = new Form5();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
      

            private void button1_Click(object sender, EventArgs e)
        {
          a.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dec.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hex.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Oct.Show();
            
        }
    }
}
