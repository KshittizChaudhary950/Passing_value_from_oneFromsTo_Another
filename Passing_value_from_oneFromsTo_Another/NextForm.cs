using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passing_value_from_oneFromsTo_Another
{
    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();
        }

        private void NextForm_Load(object sender, EventArgs e)
        {
            //label2.text = form1.text1;
            //label3.text = form1.text2;
            //label4.text = form1.text3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this assign value of forms one labels to another forms label
            label2.Text = Form1.text1;

            label3.Text = Form1.text2;

            label4.Text = Form1.text3;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
