using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroCliente
{
    public partial class FormCadastroDeClientes : Form
    {
        List<CadastroCliente> Clientes = new List<CadastroCliente>();

        public FormCadastroDeClientes()
        {
            InitializeComponent();

            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            string dataNascimento = maskedTextBoxNasci.Text;
            string telefone = maskedTextBoxTel.Text;
            string email = textBoxEmail.Text;
            GeneroCliente genero = (GeneroCliente)comboBoxGenero.SelectedIndex;
            string nomeSocial = textBoxSocial.Text;
            EtniaCliente etnia = (EtniaCliente)comboBoxEtnia.SelectedIndex;
            bool estrangeiro = checkBoxEstrangeiro.Checked;

            //TipoCliente tipo;
            //if (radioButtonTipoFisica.Checked)
            //{
            //    tipo = TipoCliente.PessoaFisica;
            //}
            //else if (radioButtonTipoJuridica.Checked)
            //{
            //    tipo = TipoCliente.PessoaJuridica;
            //}
            //else
            //{
            //    labelResultado.Text = "Selecione o tipo de cliente!";
            //    labelResultado.ForeColor = Color.Red;
            //    return;
            //}

            string logradouro = textBoxLogradouro.Text;
            string numero = textBoxNumero.Text;
            string complemento = textBoxComple.Text;
            string bairro = textBoxBairro.Text;
            string cidade = textBoxCidade.Text;
            string estado = comboBoxEstado.Text;
            string cep = maskedTextBoxCep.Text;

            EnderecoCliente EnderecoWillians = new EnderecoCliente()
            { Logradouro = "Rua 1", Numero = "123", Complemento = "Apartamento 25", Bairro = "Centro", Cidade = "Jata�", Estado = "GO", Cep = "75800-000" };
            CadastroCliente Willians = new CadastroCliente()
            {
                Id = 0,
                Nome = "Willians",
                Sobrenome = "Silva",
                DataNascimento = "25/03/2000",
                Telefone = "+55 64 99874 5654",
                Email = "willians.silva12@gmail.com",
                Endereco = EnderecoWillians,
                Genero = GeneroCliente.N�oDeclarado,
                NomeSocial = " ",
                Etnia = EtniaCliente.Branca,
                Estrangeiro = false,
                Tipo = TipoCliente.PessoaFisica
            }; Clientes.Add(Willians);


            EnderecoCliente EnderecoEduarda = new EnderecoCliente()
            { Logradouro = "Rua Alfredo de Moraes", Numero = "456", Complemento = "Casa B", Bairro = "Jardim Flores", Cidade = "Carr�o", Estado = "SP", Cep = "15695-002" };
            CadastroCliente Eduarda = new CadastroCliente()
            {
                Id = 1,
                Nome = "Eduarda",
                Sobrenome = "Martins",
                DataNascimento = "15/07/1999",
                Email = "eduarda.martins@hotmail.com",
                Telefone = "+55 11 98745 6548",
                Tipo = TipoCliente.PessoaJuridica,
                Etnia = EtniaCliente.Amarela,
                Genero = GeneroCliente.Feminino,
                Estrangeiro = false,
                NomeSocial = " ",
                Endereco = EnderecoEduarda,

            }; Clientes.Add(Eduarda);

            EnderecoCliente EnderecoEmilly = new EnderecoCliente()
            { Logradouro = "Avenida Ipiranga", Numero = "1009", Complemento = " ", Bairro = "Independencia", Cidade = "Ipiranga", Estado = "SP", Cep = "486357-053" };
            CadastroCliente Emilly = new CadastroCliente()
            {
                Id = 2,
                Nome = "Emilly",
                Sobrenome = "Carvalho",
                DataNascimento = "04/12/1988",
                Email = "emilly.carvalho@hotmail.com",
                Telefone = "+55 11 96585 1477",
                Endereco = EnderecoEmilly,
                Genero = GeneroCliente.Feminino,
                NomeSocial = " ",
                Etnia = EtniaCliente.Ind�gena,
                Estrangeiro = false,
                Tipo = TipoCliente.PessoaJuridica,
            }; Clientes.Add(Emilly);
        }

        public bool ValidarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome)) // Verifica se o nome � nulo ou vazio
            {
                labelResultado.Text = "O campo nome � obrigat�rio!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(nome.Trim())) // Verifica se o nome cont�m apenas espa�os em branco
            {
                labelResultado.Text = "O campo nome n�o pode ser vazio!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (nome.Length <= 3) // Verifica se o nome � maior que 3 caracteres
            {
                labelResultado.Text = "O campo nome deve conter no m�nimo 3 caracteres!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (nome.All(c => char.IsLetter(c) && char.IsWhiteSpace(c))) // Verifica se o nome cont�m apenas letras e espa�os
            {
                labelResultado.Text = "O campo nome deve conter apenas letras!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            labelResultado.Text = " ";
            return true;
        }

        public bool ValidarSobrenome (string sobrenome)
        {
            if (string.IsNullOrEmpty(sobrenome)) // Verifica se o sobrenome � nulo ou vazio
            {
                labelResultado.Text = "O campo sobrenome � obrigat�rio!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(sobrenome.Trim())) // Verifica se o sobrenome cont�m apenas espa�os em branco
            {
                labelResultado.Text = "O campo sobrenome n�o pode ser vazio!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (sobrenome.Length <= 3) // Verifica se o nome � maior que 3 caracteres
            {
                labelResultado.Text = "O campo sobrenome deve conter no m�nimo 3 caracteres!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (sobrenome.All(c => char.IsLetter(c) && char.IsWhiteSpace(c))) // Verifica se o sobrenome cont�m apenas letras e espa�os
            {
                labelResultado.Text = "O campo sobrenome deve conter apenas letras!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            labelResultado.Text = " "; // Limpa a mensagem de erro caso a valida��o passe
            return true;
        }
        public bool ValidarDataNascimento(string dataNascimento)
        {
            if (!maskedTextBoxNasci.MaskFull) // todos os campos dentro da mask est�o preenchidos
            {
                labelResultado.Text = "O campo data de nascimento n�o pode estar em branco!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }

            if (dataNascimento.Length != 10) // Verifica se o comprimento da string de data � igual a 10
            {
                labelResultado.Text = "O campo data de nascimento deve preencher todos os caracteres!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (!DateTime.TryParse(dataNascimento, out DateTime data)) // Tenta converter a string para uma data. Se falhar, a data n�o � v�lida
            {
                labelResultado.Text = "Data de nascimento inv�lida";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (data >= DateTime.Today) // Verifica se a data de nascimento � maior ou igual � data de hoje (n�o pode ser uma data futura)
                if (data >= DateTime.Today)
                {
                labelResultado.Text = "Data de nascimento deve ser menor que hoje";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            int idade = DateTime.Today.Year - DateTime.Parse(dataNascimento).Year; // Calcula a idade com base na data de nascimento
            {
                if (idade < 18)
                {
                    labelResultado.Text = "O cliente deve ser maior de idade!";
                    labelResultado.ForeColor = Color.Red;
                    return false;
                }
            }

            labelResultado.Text = " "; // Limpa a mensagem de erro
            return true; // Retorna verdadeiro, indicando que a valida��o passou
        }

        public bool ValidarTelefone(string telefone)
        {
            if (!maskedTextBoxTel.MaskFull) // todos os campos dentro da mask est�o preenchidos
            {
                labelResultado.Text = "O campo telefone deve preencher todos os caracteres!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            labelResultado.Text = " ";
            return true;
        }

        public bool ValidarEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) // Verifica se o email � nulo ou vazio
            {
                labelResultado.Text = "O campo email � obrigat�rio!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            if (!email.Contains("@") || !email.Contains(".")) // Verifica se o email cont�m um "@" e um "."
            {
                labelResultado.Text = "O campo email deve conter um dom�nio v�lido!";
                labelResultado.ForeColor = Color.Red;
                return false;
            }
            labelResultado.Text = " ";
            return true;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarNome(textBoxNome.Text))
            {
                return;
            }

            if (!ValidarSobrenome(textBoxSobrenome.Text))
            {
                return;
            }

            if (!ValidarDataNascimento(maskedTextBoxNasci.Text))
            {
                return;
            }
            if (!ValidarTelefone(maskedTextBoxTel.Text))
            {
                return;
            }
            if (!ValidarEmail(textBoxEmail.Text))
            {
                return;
            }
        }
    }
}
