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
    public partial class checkbox : Form
    {
        string Text1 = "";
        string Text2 = "";
        string Text3 = "";
        string Text4 = "";

        public checkbox()
        {
            InitializeComponent();
        }

        private void NokiacheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
            if (NokiacheckBox.Checked==true)
            {
                Text1 = NokiacheckBox.Text;
                SubmitBtn.Enabled = NokiacheckBox.Checked; // this code is use to enable the submit button
            }
            else
            {
                Text1 = "";
            }
        }

        private void IphonecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IphonecheckBox.Checked == true)
            {
                Text2 = IphonecheckBox.Text;
                SubmitBtn.Enabled = IphonecheckBox.Checked;
            }
            else
            {
                Text2 = "";
            }
        }

        private void GioneecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GioneecheckBox.Checked == true)
            {
                Text3 = GioneecheckBox.Text;
                SubmitBtn.Enabled = GioneecheckBox.Checked;
            }
            else
            {
                Text3 = "";
            }
        }

        private void MicromaxcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MicromaxcheckBox.Checked == true)
            {
                Text4 = MicromaxcheckBox.Text;
                SubmitBtn.Enabled = MicromaxcheckBox.Checked;
            }
            else
            {
                Text4 = "";
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your select mobile is: " + Text1 + " " + Text2 + " " + Text3 + " " + Text4);
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
