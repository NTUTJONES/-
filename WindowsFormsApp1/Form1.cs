using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = 0;
            age = int.Parse(textBox1.Text);
            if (age >= 18)
            {
                label2.Text = "年齡"+string.Concat(age)+"大於18歲";
            }
            else
            {
                label2.Text = "年齡" + string.Concat(age) + "小於18歲未成年";
            }
            
        }
    }
}
