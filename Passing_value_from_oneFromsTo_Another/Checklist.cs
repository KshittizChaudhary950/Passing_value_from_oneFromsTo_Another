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
    }
}
