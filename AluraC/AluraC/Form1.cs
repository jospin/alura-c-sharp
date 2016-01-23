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

            int a = 2;
            int b = 6;
            int c = 2;
            double delta = b * b - 4 * a * c;
            double a1 = -b + Math.Sqrt(delta) / (2 * a);
            double a2 = -b - Math.Sqrt(delta) / (2 * a);
            MessageBox.Show("Resultado de Bascha é a1 = " + a1 + " Ou a2 = " + a2);

            int idade = 18;
            bool menor = idade < 18;
            if(menor)
            {
                MessageBox.Show("Não pode votar");
            }

            double nota = 2900;
            double taxa;
            if(nota < 1000)
            {
                taxa = 0.02;
            } else if(nota >= 1000 && nota < 3000 )
            {
                taxa = 0.025;
            } else if(nota >= 3000 && nota < 7000)
            {
                taxa = 0.028;
            } else
            {
                taxa = 0.03;
            }
            double imposto = nota * taxa;
            MessageBox.Show("Imposto a pagar: " + imposto + " com taxa de: " + taxa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorInvestido = 2000;
            for (int i =1; i<= 12; i++)
            {
                valorInvestido += 1.01;
            }
            MessageBox.Show("Valor investido: " + valorInvestido);
            valorInvestido = 2000;
            int w = 1;
            while(w <= 12)
            {
                valorInvestido += 1.01;
                w++;

            }
            MessageBox.Show("Valor investido: " + valorInvestido);
            valorInvestido = 2000;
            int dw= 0;
            do
            {
                valorInvestido += 1.01;
                dw++;
            } while (dw < 12);
            MessageBox.Show("Valor investido: " + valorInvestido);

            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial *=  n;
                MessageBox.Show("fat(" + n + ") = " + fatorial);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int linhas = 7;
            string triangulo = "";
            for (int linha = 1; linha <= linhas; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    triangulo += (linha * coluna) + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);
        }
    }
}
