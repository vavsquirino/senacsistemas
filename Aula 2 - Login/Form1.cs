using System.Diagnostics.Eventing.Reader;

namespace Aula_2___Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = BoxUsu�rio.Text;
            string senha = BoxSenha.Text;

            if (usuario == null || usuario == "")
            {
                labelresultado.Text = "Usu�rio � obrigat�rio!";
                labelresultado.ForeColor = Color.Red;
            }
            else if (usuario == "valerya.cruz" && senha == "12345")
            {
                labelresultado.Text = "Autenticado com sucesso";
                labelresultado.ForeColor = Color.Green;
            }
            else
            {
                labelresultado.Text = "Usu�rio e Senha incorretos";
                labelresultado.ForeColor= Color.Red;
            }
              
        }
    }
}
