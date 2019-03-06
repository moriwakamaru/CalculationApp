using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算アプリ
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

        private void button1_Click(object sender, EventArgs e)
        {
            int in1 = Int32.Parse(textBox1.Text);
            int in2 = Int32.Parse(textBox2.Text);
            int ans = 0;
            if(label1.Text== "＋")
            {
                ans = in1 + in2;
            }
            if (label1.Text == "－")
            {
                ans = in1 - in2;
            }
            if (label1.Text == "×")
            {
                ans = in1 * in2;
            }
            if (label1.Text == "÷")
            {
                ans = in1 / in2;
            }


            label2.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "＋";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "－";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "×";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "÷";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int in3 = Int32.Parse(textBox3.Text);
            int in4 = Int32.Parse(textBox4.Text);
            int sum = 1;
            for(int i=0;i<in4;i++)
            {
                sum *= in3;
            }
            label4.Text = sum.ToString();
        }
    }
}
