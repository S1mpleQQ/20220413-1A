using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220413_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        
        
            private void button1_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
                timer1.Enabled=true;
            
                
            button1.Text =(Convert.ToInt32(button1.Text)+1).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text= (Convert.ToInt32(label1.Text) -1).ToString();
            if (label1.Text=="0")
            {
                button1.Enabled = false;
                timer1.Enabled = false;
            }

        }
        private void buttonNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            label1.Text = btn.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
