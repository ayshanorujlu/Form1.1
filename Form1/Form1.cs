using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Time = System.Windows.Forms.Timer;

namespace Form1
{
    
    public partial class Form1 : Form
    {   
        int a = 0;
        public Form1()
        {
            InitializeComponent();
            Time time = new Time();
            time.Interval = 1000;
            time.Tick += Time_tick;
            time.Start();
        }
        private void Time_tick(object sender, EventArgs e)
        {
            if (a == 0)
                textBox1.Text = DateTime.Now.ToLongTimeString();
            else if (a == 1)
                textBox1.Text = DateTime.UtcNow.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Form1.Properties.Resources.baku;
            textBox1.Text = DateTime.Now.ToLongTimeString();
            a = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::Form1.Properties.Resources.london;
            textBox1.Text = DateTime.UtcNow.ToLongTimeString();
            a = 1;
        }

        
    }
}
