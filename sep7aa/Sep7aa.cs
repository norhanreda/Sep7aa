using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sep7aa
{
    public partial class Sep7aa : Form
    {
        int count = 5;
        public Sep7aa()
        {
            InitializeComponent();
        }

        private void Sep7aa_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            textBox1.Text = Convert.ToString(count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                count = 0;
            else
            count = Convert.ToInt32(textBox1.Text);
            
            count++;
            textBox1.Text = Convert.ToString(count);
        }
    }
}
