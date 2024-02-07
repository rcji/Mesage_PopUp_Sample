using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesage_Pop_up_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Message Pop-up initialization    Syntax: Text, caption, buttons
            //res = MessageButton click result
            DialogResult res = MessageBox.Show("Wyd?!", "This is the caption", MessageBoxButtons.YesNoCancel);

            //ff handles different click results
            if (res == DialogResult.Yes)
            {
                button1.Text = "You clicked on Yes!";
            }

            if (res == DialogResult.No)
            {
                button1.Text = "You clicked on No!";
            }

            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Canceled", "Ain't no way.");
            }
        }
    }
}