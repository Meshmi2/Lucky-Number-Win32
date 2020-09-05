using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Number_Win32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creates a number between 1 and 90
            Random numerocasuale = new Random();
            int numero1 = Convert.ToInt32(numerocasuale.Next(1, 90).ToString());
            int numero2 = Convert.ToInt32(numerocasuale.Next(1, 90).ToString());
            int numero3 = Convert.ToInt32(numerocasuale.Next(1, 90).ToString());
            int numero4 = Convert.ToInt32(numerocasuale.Next(1, 90).ToString());
            int numero5 = Convert.ToInt32(numerocasuale.Next(1, 90).ToString());
            int numero6 = Convert.ToInt32(numerocasuale.Next(1, 90).ToString());
            //Show Number
            //1
            string replace1 = label1.Text.Replace(label1.Text, "" + numero1);
            label1.Text = replace1;
            label1.Visible = true;
            Thread.Sleep(500);
            //2
            string replace2 = label2.Text.Replace(label2.Text, "" + numero2);
            label2.Text = replace2;
            label2.Visible = true;
            Thread.Sleep(500);
            //3
            string replace3 = label3.Text.Replace(label3.Text, "" + numero3);
            label3.Text = replace3;
            label3.Visible = true;
            Thread.Sleep(500);
            //4
            string replace4 = label4.Text.Replace(label4.Text, "" + numero4);
            label4.Text = replace4;
            label4.Visible = true;
            Thread.Sleep(500);
            //5
            string replace5 = label5.Text.Replace(label5.Text, "" + numero5);
            label5.Text = replace5;
            label5.Visible = true;
            Thread.Sleep(500);
            //6
            string replace6 = label6.Text.Replace(label6.Text, "" + numero6);
            label6.Text = replace6;
            label6.Visible = true;
            Thread.Sleep(500);
        }
    }
}
