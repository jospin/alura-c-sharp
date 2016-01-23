using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            double avg;
            avg = (idadeJoao + idadeMaria) / 2;
            MessageBox.Show("A média de idade é: " + avg);
            int a = 6;
            int b = 2;
            int c = 2;
            double delta ;
            delta = b * b - 4 * a * c;
            double a1 = -b + Math.Sqrt(delta) / (2 * a);
            double a2 = -b - Math.Sqrt(delta) / (2 * a);
            MessageBox.Show("Resultado de Bascha é a1 = " + a1 + " Ou a2 = " + a2);
        }
    }
}
