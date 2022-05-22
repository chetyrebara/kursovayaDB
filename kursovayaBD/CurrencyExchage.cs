using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace kursovayaBD
{
    public partial class CurrencyExchage : Form
    {
        public CurrencyExchage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void CurrencyExchage_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CurrencyExchage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Currency a = new Currency();
            a.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exchanger_rate a = new Exchanger_rate();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee a = new Employee();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Incassations a = new Incassations();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Transactions a = new Transactions();
            a.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           insert a = new insert();
            a.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
