using System.Diagnostics.Eventing.Reader;

namespace Aula_2___Login
{
    public partial class Login : Form
    {
        List<string> listaUsuario = new List<string>() { "valerya.cruz", "maria.eduarda", "joao.carlos" };
        List<string> listaSenha = new List<string>() { "12345", "mamari", "JP" };

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = BoxUsu�rio.Text;
            string senha = BoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelresultado.Text = "Usu�rio � obrigat�rio!";
                labelresultado.ForeColor = Color.Red;
                return;
            }
            if (senha == null || senha == "")
            {
                labelresultado.Text = "A senha � obrigat�rio!";
                labelresultado.ForeColor = Color.Red;
                return;
            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuario.Count; i++)
            {
                if (usuarioBuscado == listaUsuario[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenha[posicaoUsuarioEncontrado])
            {
                labelresultado.Text = "Autenticado com sucesso";
                labelresultado.ForeColor = Color.Green;
            }
            else
            {
                labelresultado.Text = "Usu�rio ou Senha incorretos";
                labelresultado.ForeColor = Color.Red;
            }
        }

        private void EntrarCriar_Click(object sender, EventArgs e)
        {
            {
                string criarUsuario = BoxUsuarioCriar.Text;
                string criarSenha = BoxSenhaCriar.Text;

                if (string.IsNullOrWhiteSpace(criarUsuario))
                {
                    labelRespostaCriar.Text = "Usu�rio � obrigat�rio!";
                    labelRespostaCriar.ForeColor = Color.Red;
                    return;
                }
                if (string.IsNullOrWhiteSpace(criarSenha))
                {
                    labelRespostaCriar.Text = "A senha � obrigat�rio!";
                    labelRespostaCriar.ForeColor = Color.Red;
                    return;
                }

                bool usuarioEncontrado = false;

                for (int i = 0; i < listaUsuario.Count; i++)
                {
                    if (criarUsuario == listaUsuario[i])
                    {
                        usuarioEncontrado = true;
                    }
                }

                if (!usuarioEncontrado)
                {
                    listaUsuario.Add(criarUsuario);
                    listaSenha.Add(criarSenha);
                    labelRespostaCriar.Text = "Usuario cadastrado.";
                    labelRespostaCriar.ForeColor = Color.Goldenrod;
                }
                else
                {
                    labelRespostaCriar.Text = "J� existe um um usuario cadastrado.";
                }
            }
        }
    }
}
