using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 g1 = new Class1();
            label1.Text = g1.GetNumber().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 g2 = new Class1();
            label2.Text = g2.GetNumber2().ToString();
        }
    }
}
