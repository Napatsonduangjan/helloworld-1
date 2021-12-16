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

        private void button1_Click(object sender, EventArgs e)
        {
            //convert to c
            double f = Convert.ToDouble(textBoxF.Text);
            double c =  (f -32) * 5/9 ;
            //show input to textbox
            textBoxC.Text = c.ToString();
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}
