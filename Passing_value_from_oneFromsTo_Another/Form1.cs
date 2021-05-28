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
    public partial class Form1 : Form
    {
        public static string text1;
        public static string text2;
        public static string text3;


        public Form1()
        {
            InitializeComponent();
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (FirsttextBox.Text != "" && LasttextBox.Text != "")
            {
                text1 = FirsttextBox.Text;
                text2 = MiddletextBox.Text;
                text3 = LasttextBox.Text;

                this.Hide();
                NextForm f2 = new NextForm();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter First and last name to enter next step ");
            }

        }

        private void Radiobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadioBotton f3 = new RadioBotton();
            f3.ShowDialog();
        }
    }
}
