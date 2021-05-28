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
    public partial class RadioBotton : Form
    {
        public RadioBotton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                MessageBox.Show("You select :" + radioButton1.Text);
            }

           else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You select :" + radioButton2.Text);
            }

          else if (radioButton3.Checked == true)
            {
                MessageBox.Show("You select :" + radioButton3.Text);
            }
           else if (radioButton4.Checked == true)
            {
                MessageBox.Show("You select :" + radioButton4.Text);
            }

            else 
            {
                MessageBox.Show("You did not select any items");
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Red.Checked==true)
            {
                groupBox1.BackColor = Color.Red;
            }
             else if (Blue.Checked == true)
            {
                groupBox1.BackColor = Color.Blue;
            }
           else if (Green.Checked == true)
            {
                groupBox1.BackColor = Color.Green;
           
            }
            else if (Orange.Checked == true)
            {
                groupBox1.BackColor = Color.Orange;
            }
            else
            {
                MessageBox.Show("Please select colour");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Red2.Checked==true)
            {
               //this syntax is use to change colour of forms 
                this.BackColor = System.Drawing.Color.Red;
            }
            else if(Green2.Checked==true)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show("Please select at least one colour");
            }
        }
    }
}
