using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, delta,kokdelta, kok1,kok2;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
       
          
            delta = (b * b) - (4 * a * c);
          

            if (delta < 0)

            {
                MessageBox.Show("Bu denklemin kökü yok!");

            }
            
            else if (delta == 0)
            {
                kokdelta = Math.Sqrt(delta);
                kok1 = (-b + kokdelta) / (2 * a);
                MessageBox.Show("Denklemin kökü: " + kok1);
            }
            else if(delta > 0)
            {
                kokdelta = Math.Sqrt(delta);
                kok1 = (-b + kokdelta) / (2 * a);
                kok2 = (-b - kokdelta) / (2 * a);

                MessageBox.Show("Denklemin birinci kökü: " + kok1 + " ikinci kökü: " + kok2);
            }


















        }

   
    }
}
