namespace calculoEsfera
{
    public partial class Form1 : Form
    {
        string perimetro;
            string diametro;
            string area;
            string volume;
            string circuferencia;

        public Form1()
        {
            InitializeComponent();
        }

        private void BoxPerimetro_TextChanged(object sender, EventArgs e)
        {
            perimetro = BoxPerimetro.Text;
            double calPeri = Convert.ToDouble(perimetro);
            double calDiam = Convert.ToDouble(diametro);
            double calArea = Convert.ToDouble(area);
            double calVolu = Convert.ToDouble(volume);
            double calCirc = Convert.ToDouble(circuferencia);


            double raio = calDiam / 2;

            calPeri = 2 * 3.14 * (calDiam/2);
            calDiam = calCirc * calPeri;
            calArea = 3.14 * (Math.Pow(raio,2));

            labelRespostaAcao.Text = calPeri.ToString();
        }
    }
}
