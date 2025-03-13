namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Valor1 = BoxValor1.Text;
            string Valor2 = BoxValor2.Text;

            if (!Valor1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor deve ser um n�mero";
                return;
            }
            if (!Valor2.All(char.IsNumber))
            {
                labelResultado.Text = "O valor deve ser um n�mero";
                return;
            }

            if (!double.TryParse(Valor1, out double valores1))
            {
                labelResultado.Text = "O valor deve ser um n�mero v�lido";
                return;
            }
            if (!double.TryParse(Valor2, out double valores2))
            {
                labelResultado.Text = "O valor deve ser um n�mero v�lido";
                return;
            }

            double resultadoFinal = 0;

            int[] operacoes = { 0, 1, 2, 3 };

            for (int i = 0; i < operacoes.Length; i++)
            {
                operacoes[i] = (comboBoxOperacao.SelectedIndex);
                switch (operacoes[i])
                {
                    case 0: // Soma
                        resultadoFinal = valores1 + valores2;
                        labelResultado.Text = ($"Opera��o {i + 1} (Soma): {valores1} + {valores2} = {resultadoFinal}");
                        break;

                    case 1: // Subtra��o
                        resultadoFinal = valores1 - valores2;
                        labelResultado.Text = ($"Opera��o {i + 1} (Subtra��o): {valores1} - {valores2} = {resultadoFinal}");
                        break;

                    case 2: // Multiplica��o
                        resultadoFinal = valores1 * valores2;
                        labelResultado.Text = ($"Opera��o {i + 1} (Multipliaca��o): {valores1} * {valores2} = {resultadoFinal}");
                        break;

                    case 3: // Divis�o
                        resultadoFinal = valores1 / valores2;
                        labelResultado.Text = ($"Opera��o {i + 1} (Divis�o): {valores1} / {valores2} = {resultadoFinal}");

                        if (resultadoFinal != 0)
                        {
                            labelResultado.Text = ($"Opera��o {i + 1} (Divis�o): {valores1} / {valores2} = {resultadoFinal}");
                            break;
                        }
                        else
                        {
                            resultadoFinal.CompareTo($"Opera��o {i + 1} (Divis�o): Divis�o por zero n�o � permitida");
                        }
                        break;
                }
            }

            labelResultado.Text = resultadoFinal + "";
        }

        private void comboBoxOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perimetro form = new Perimetro();
            form.Show();

            this.Hide();
        }
    }
}
