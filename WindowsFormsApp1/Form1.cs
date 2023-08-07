using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int resultado = Soma(n1, n2);
            MessageBox.Show($"O resultado da soma foi: {resultado}");
        }

        public static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
