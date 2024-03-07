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
            float nota5, nota2, nota3, nota4, media;
            bool verifica1, verifica2, verifica3, verifica4;

            string nome = textBox1.Text;

            verifica1 = float.TryParse(textBox5.Text, out nota5);
            verifica2 = float.TryParse(textBox2.Text, out nota2);
            verifica3 = float.TryParse(textBox3.Text, out nota3);
            verifica4 = float.TryParse(textBox4.Text, out nota4);
            if (!verifica1 || !verifica2 || !verifica3 || !verifica4 )
            {
                MessageBox.Show("digite corretamente os números");
            }
            else
            {
                media = (nota5 + nota2 + nota3 + nota4) / 4;
                MessageBox.Show("a média do aluno " + nome + " foi " + media.ToString());

                if (media <= 5)
                {
                    label6.Text = "o Aluno " + nome + " foi Reprovado";
                    label7.Text += "-" + nome;
                }
                else
                {
                    label6.Text = "o Aluno " + nome + " foi Aprovado";
                    label8.Text += "-" + nome;

                }
            }

          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
