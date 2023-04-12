using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remainder
{
    public partial class Form1 : Form
    {
        //M.A.M.Ali Razah
        public Form1()
        {
            InitializeComponent();
        }
        string currentime;
        string messagetime;


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentime = DateTime.Now.ToString("dddd-MMMM-dd-yyyy-hh:mm:ss tt");
            label1.Text = currentime;
            dateTimePicker1.ResetText();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            messagetime = dateTimePicker1.Text + "-" + maskedTextBox1.Text + "" + comboBox1.Text;
            label4.Text = "Reminder Set FOR : " + messagetime;
            if (currentime == messagetime)
            {
                timer2.Stop();
                MessageBox.Show(textBox1.Text);

                label4.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
