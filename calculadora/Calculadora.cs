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
                labelResultado.Text = "O valor deve ser um número";
                return;
            }
            if (!Valor2.All(char.IsNumber))
            {
                labelResultado.Text = "O valor deve ser um número";
                return;
            }

            double valores1 = Convert.ToDouble(BoxValor1.Text);
            double valores2 = Convert.ToDouble(BoxValor2.Text);
            double resultadoFinal = 0;

            labelResultado.Text = $"Resultado = {resultadoFinal.ToString()} ";

            int[] operacoes = { 1, 2, 3, 4 };

            for (int i = 0; i < valores1; i++)
            {
                switch (operacoes[i])
                {
                    case 1: // Soma
                        resultadoFinal = valores1 + valores2;

                        labelResultado.Text = ($"Operação {i + 1} (Soma): {valores1} + {valores2} = {resultadoFinal}");
                        break;

                    case 2: // Subtração
                        resultadoFinal = valores1 - valores2;
                        labelResultado.Text = ($"Operação {i + 1} (Subtração): {valores1} - {valores2} = {resultadoFinal}");
                        break;

                }
            }
        }
    }
}
