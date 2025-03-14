using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace calculadora
{
    public partial class Perimetro : Form
    {
        public Perimetro()
        {
            InitializeComponent();
        }
        private void radioQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioQuadrado.Checked)
            {
                textBoxLado.Enabled = true;
                textBoxAltura.Enabled = false;
                textBoxLargura.Enabled = false;
                return;
            }
        }

        private void radioRetangulo_CheckedChanged(object sender, EventArgs e)
        {

            if (radioRetangulo.Checked)
            {
                textBoxLado.Enabled = true;
                textBoxAltura.Enabled = true;
                textBoxLargura.Enabled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lado = textBoxLado.Text;

            if (!lado.All(char.IsNumber))
            {
                labelResultado.Text = "O valor deve ser um número";
                return;
            }
            if (string.IsNullOrEmpty(lado))
            {
                labelResultado.Text = "Deve-se inserir um valor";
            }

            float calLado = float.Parse(lado);

            float area = calLado * calLado;
            float perimetro = calLado + calLado + calLado + calLado;
            float volume = calLado * calLado * calLado;

        }
    }
}
