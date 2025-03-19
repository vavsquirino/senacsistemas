using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace CadastroCliente
{
    public partial class FormCadastroDeClientes : Form
    {
        List<CadastroCliente> Clientes = new List<CadastroCliente>();

        public FormCadastroDeClientes()
        {
            InitializeComponent();

            EnderecoCliente EnderecoWillians = new EnderecoCliente() { Logradouro = "Rua 1", Numero = "123", Complemento = "Apartamento 25", Bairro = "Centro", Cidade = "Jataí", Estado = "GO", Cep = "75800-000" };
            CadastroCliente Willians = new CadastroCliente()
            {
                Id = 0,
                Nome = "Willians",
                DataNascimento = "25/03/2000",
                Telefone = "+55 64 99874 5654",
                Email = "willians.silva12@gmail.com",
                Endereco = EnderecoWillians,
                Genero = GeneroCliente.NãoDeclarado,
                NomeSocial = " ",
                Etnia = EtniaCliente.Branca,
                Estrangeiro = false,
                Tipo = TipoCliente.PessoaFisica
            }; Clientes.Add(Willians);

            EnderecoCliente EnderecoEduarda = new EnderecoCliente() { Logradouro = "Rua Alfredo de Moraes", Numero = "456", Complemento = "Casa B", Bairro = "Jardim Flores", Cidade = "Carrão", Estado = "SP", Cep = "15695-002" };
            CadastroCliente Eduarda = new CadastroCliente()
            {
                Id = 1,
                Nome = "Eduarda",
                DataNascimento = "15/07/1999",
                Telefone = "+55 11 98745 6548",
                Email = "eduarda.martis@hotmail.com",
                Endereco = EnderecoEduarda,
                Genero = GeneroCliente.Feminino,
                NomeSocial = " ",
                Etnia = EtniaCliente.Amarela,
                Estrangeiro = false,
                Tipo = TipoCliente.PessoaJuridica,
            }; Clientes.Add(Eduarda);

            EnderecoCliente EnderecoEmilly = new EnderecoCliente() { Logradouro = "Avenida Ipiranga", Numero = "1009", Complemento = " ", Bairro = "ídependencia", Cidade = "Ipiranga", Estado = "SP", Cep = "486357-053" };
            CadastroCliente Emilly = new CadastroCliente()
            {
                Id = 2,
                Nome = "Emilly",
                DataNascimento = "04/12/1988",
                Telefone = "+55 11 96585 1477",
                Email = "emilly.carvalho@hotmail.com",
                Endereco = EnderecoEmilly,
                Genero = GeneroCliente.Feminino,
                NomeSocial = " ",
                Etnia = EtniaCliente.Indígena,
                Estrangeiro = false,
                Tipo = TipoCliente.PessoaJuridica,
            }; Clientes.Add(Emilly);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string dataNascimento = maskedTextBoxNasci.Text;
            string telefone = maskedTextBoxTel.Text;
            string email = textBoxEmail.Text;
            GeneroCliente genero = (GeneroCliente)comboBoxGenero.SelectedIndex;
            string nomeSocial = textBoxSocial.Text;
            EtniaCliente etnia = (EtniaCliente)comboBoxEtnia.SelectedIndex;
            bool estrangeiro = checkBoxEstrangeiro.Checked;

            TipoCliente tipo;
            if (radioButtonTipoFisica.Checked)
            {
                tipo = TipoCliente.PessoaFisica;
            }
            else if (radioButtonTipoJuridica.Checked)
            {
                tipo = TipoCliente.PessoaJuridica;
            }
            else
            {
                labelResultado.Text = "Selecione o tipo de cliente!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            string logradouro = textBoxLogradouro.Text;
            string numero = textBoxNumero.Text;
            string complemento = textBoxComple.Text;
            string bairro = textBoxBairro.Text;
            string cidade = textBoxCidade.Text;
            string estado = comboBoxEstado.Text;
            string cep = maskedTextBoxCep.Text;

        }
    }
}
