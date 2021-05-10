using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimTraining
{
    public partial class form13 : Form
    {
        int yansay = 0;
        int dorsay = 0;
        int sansay = 0;
        int daksay = 0;
        public form13()
        {
            InitializeComponent();
            label1.Text = "Wrong Click\n" + yansay;
            label2.Text = "Correct Click\n" + dorsay;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sansay++;
            if (sansay == 60)
            { daksay++; sansay = 0; label3.Text = Convert.ToString(daksay); }
            label4.Text = Convert.ToString(sansay);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(12, 422);
            int b = rnd.Next(44, 399);
            button1.Location = new Point(a, b);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==false)
            { timer1.Enabled = true;button1.Enabled = true; timer2.Enabled = true; }
            else if (timer1.Enabled==true)
            { timer1.Enabled = false;button1.Enabled = false; timer2.Enabled = false; }
            Random rnd = new Random();
            int a = rnd.Next(12, 422);
            int b = rnd.Next(44, 399);
            button1.Location = new Point(a, b);
        }
        private void form13_Click(object sender, EventArgs e)
        {
            yansay++;
            label1.Text = "Wrong Click\n" + yansay;
            Random rnd = new Random();
            int a = rnd.Next(12, 422);
            int b = rnd.Next(44, 399);
            button1.Location = new Point(a, b);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dorsay++;
            label2.Text = "Correct Click\n" + dorsay;
            Random rnd = new Random();
            int a = rnd.Next(12, 422);
            int b = rnd.Next(44, 399);
            button1.Location = new Point(a, b);
            timer2.Stop();
            timer2.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            yansay = 0;
            dorsay = 0;
            daksay = 0;
            sansay = 0;
            label3.Text = "00";
            label4.Text = "00";
            label1.Text = "Wrong Click\n" + yansay;
            label2.Text = "Correct Click\n" + dorsay;
        }
    }
}