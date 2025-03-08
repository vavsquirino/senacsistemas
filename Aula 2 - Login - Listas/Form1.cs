using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Aula_2___Login
{
    public partial class Login : Form
    {
        
        Usuario pablo = new Usuario() { Email = "pablo.vittar@gmil.com", Senha = "12345Abc!" };
        Usuario sakuna = new Usuario() { Email = "sakuna.silva@gmil.com", Senha = "Sete7Sete!" };

        List<Usuario> usuarios = new List<Usuario>();

        public Login()
        {
            InitializeComponent();
            usuarios.Add(new Usuario() { Email = "neymar.jr@gmil.com", Senha = "Brun@123" });
            usuarios.Add (new Usuario() { Email = "pablo.vittar@gmil.com", Senha = "12345Abc!" });
            usuarios.Add (new Usuario() { Email = "sakuna.silva@gmil.com", Senha = "Sete7Sete!" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = BoxUsuário.Text;
            string senha = BoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelresultado.Text = "Usuário é obrigatório!";
                labelresultado.ForeColor = Color.Red;
                return;
            }
            if (senha == null || senha == "")
            {
                labelresultado.Text = "A senha é obrigatório!";
                labelresultado.ForeColor = Color.Red;
                return;
            }

            bool autenticado = false;
            for (int i = 0; i < usuarioBuscado.Count; i++)

            if (Usuario[i].Email == usuarioBuscado && usuarios[i].Senha == senha)
            {

            }

            int posicaoUsuarioEncontrado = listaUsuario.IndexOf(usuarioBuscado);

            if (posicaoUsuarioEncontrado == -1 || senha != listaSenha[posicaoUsuarioEncontrado]) ; 
            {
                labelresultado.Text = "Autenticado com sucesso";
                labelresultado.ForeColor = Color.Red;
                return;
            }

            labelresultado.Text = "Autenticado com sucesso";
            labelresultado.ForeColor = Color.Red;
            BoxUsuário.Clear();
            BoxSenha.Clear();
        }

        private void EntrarCriar_Click(object sender, EventArgs e)
        {
            {

                string criarUsuario = BoxUsuarioCriar.Text;
                string criarSenha = BoxSenhaCriar.Text;

                if (string.IsNullOrWhiteSpace(criarUsuario))
                {
                    labelRespostaCriar.Text = "Usuário é obrigatório!";
                    return;
                }
                if (string.IsNullOrWhiteSpace(criarSenha))
                {
                    labelRespostaCriar.Text = "A senha é obrigatório!";
                    return;
                }

                if (criarSenha.Length < 8)
                {
                    labelRespostaCriar.Text = "A senha deve ter pelo menos 8 caracteres";
                    return;
                }

                if (!criarSenha.Any(char.IsUpper))
                {
                    labelRespostaCriar.Text = "A senha deve ter pelo menos uma letra maiuscula";
                    return;
                }

                if (!criarSenha.Any(char.IsLower))
                {
                    labelRespostaCriar.Text = "A senha deve ter pelo menos uma letra minuscula";
                    return;
                }

                if (!criarSenha.Any(char.IsDigit))
                {
                    labelRespostaCriar.Text = "A senha deve ter pelo menos um numero";
                    return;
                }

                if (!criarSenha.Any(char.IsPunctuation) && !criarSenha.Any(char.IsSymbol) && !criarSenha.Contains('@'))
                {
                    labelRespostaCriar.Text = "A senha deve ter pelo menos um caracter especial";
                    return;
                }

                if (criarSenha.Contains(' '))
                {
                    labelRespostaCriar.Text = "A senha nao deve ter espacos em branco";
                    return;
                }

                if (criarUsuario.Contains(criarUsuario))
                {
                    labelRespostaCriar.Text = "Já existe um usuário cadastrado";
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
                    BoxUsuarioCriar.Clear();
                    BoxSenhaCriar.Clear();
                }
            }
        }
    }
}
