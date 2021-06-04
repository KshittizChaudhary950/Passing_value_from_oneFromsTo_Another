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
    public partial class Checklist : Form
    {
        public Checklist()
        {
            InitializeComponent();
        }

        private void Checklist_Load(object sender, EventArgs e)
        {

            //multiple check box is added in checkList 

        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
        }

        private void Indexbtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            for(int i=0; i<checkedListBox1.CheckedIndices.Count;i++)
            {

                listBox2.Items.Add(checkedListBox1.CheckedIndices[i]);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {

                checkedListBox1.Items.Add(textBox1.Text);

                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please enter the items which u want to add");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select items first to do operations");
            }
          
        }
    }
}
