using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraWF
{
    public partial class Form1 : Form
    {

        decimal primeiroValor = 0, segundoValor;
        string operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

                             // numeral //
        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private void btn_1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
                              // numeral //







     // apagar e limpar //

        private void btn_apag_Click(object sender, EventArgs e)
        {
            string valorAtual = textBox1.Text;
            if (valorAtual.Length > 0)
            {
                valorAtual = valorAtual.Substring(0, valorAtual.Length - 1);
                textBox1.Text = valorAtual;
            }
            }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
     // apagar e limpar //








                                            // operações //
        private void btn_raiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = Convert.ToString(Math.Sqrt((double)primeiroValor));
                operacao = "raiz";
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "divi";
            }
        }


        private void btn_mult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "mult";
            }

        }

        private void btn_subt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "sub";
            }
        }
        private void btn_som_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "soma";
            }
        }
                                            // operações //






           // operação igual //
        private void btn_igual_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                segundoValor = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

                if (operacao == "soma")
                {
                    textBox1.Text = Convert.ToString(primeiroValor + segundoValor);
                }

                else if (operacao == "sub")//se não for soma, se for sutração: faça isso
                {
                    textBox1.Text = Convert.ToString(primeiroValor - segundoValor);
                }

                else if (operacao == "mult")
                {
                    textBox1.Text = Convert.ToString(primeiroValor * segundoValor);
                }

                else if (operacao == "divi")
                {
                    textBox1.Text = Convert.ToString(primeiroValor / segundoValor);
                }

                else if (operacao == "raiz")
                {
                    textBox1.Text = Convert.ToString(Math.Sqrt((double)primeiroValor));
                }


            }
        }
        // operação igual //































        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
