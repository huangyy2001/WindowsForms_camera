using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A109221063_1111_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            label2.Text = "挑選後請按確認鍵";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int totle = 0;
            string msg = "購買商品：\n";

            if (radioButton1.Checked == true)
            {
                totle += 50000;
                msg += "canon\n";
            }
            else if (radioButton2.Checked == true)
            {
                totle += 40000;
                msg += "fujifilm\n";
            }
            else if (radioButton3.Checked == true)
            {
                totle += 55000;
                msg += "sony\n";
            }

            if (checkBox1.Checked == true)
            {
                totle += 588;
                msg += "4G記憶卡\n";
            }
            if (checkBox2.Checked == true)
            {
                totle += 390;
                msg += "專用電池\n";
            }

            msg += "贈品：\n";

            if (radioButton4.Checked == true)
            {
                
                msg += "清潔組\n";
            }
            else if (radioButton5.Checked == true)
            {
                
                msg += "保護貼\n";
            }
            else if (radioButton6.Checked == true)
            {
                
                msg += "防潮盒";
            }

            label2.Text = $"總額為{totle}\n{msg}";
            MessageBox.Show($"總額為{totle}\n{msg}");
        }
    }
}
