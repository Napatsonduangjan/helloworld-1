using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeampCalculator
{
    public partial class bouttonConvert : Form
    {
        public bouttonConvert()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             //input
            //นี้คือคอมเม้นท์
            //textBoxC.Text = "hello";
            //textBoxF.Text = "world";
            //get input form textbox
            string input = textBoxC.Text;
            //convert to f 
            // f= c* 9/5 +32
            double c = Convert.ToDouble(input); 
            double f = c * 9 / 5 + 32;
            //show input to textbox
            textBoxF.Text = f.ToString();
        }
    }
}
