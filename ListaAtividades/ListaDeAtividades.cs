using ListaAtividades.Dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (DataGridViewAtividades.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma atividade para atualizar.");
                return;
            }

            var linhaSelecionada = DataGridViewAtividades.SelectedRows[0];

            Atividade atividade = new()
            {
                Id = (int)linhaSelecionada.Cells["Id"].Value,
                Titulo = (string)linhaSelecionada.Cells["Titulo"].Value,
                Situacao = (Situacao)linhaSelecionada.Cells["Situacao"].Value
            };

            if (!atividade.AtualizarSituacao())
            {
                MessageBox.Show("Não foi possível criar a atividade");
                return;
            }

            atividade.AtualizarSituacao();
        }

        public void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new();

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();

            if (atividadeEmAndamento.Id > 0)
            {
                textBoxAtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            }

            var atividadesPendentes = atividade.ListarAtividadePendentes();
            DataGridViewAtividades.DataSource = atividadesPendentes;
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new criarAtiv().ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("A atividade criada com sucesso");
                return;
            }

            MessageBox.Show("A atividade uiii?");
            CarregarListaAtividades();
        }

        private void CarregarListaAtividades()
        {
            var atividade = new Atividade();
            var atividadesPendentes = atividade.ListarAtividadePendentes();
            DataGridViewAtividades.DataSource = atividadesPendentes;
        }

        private void CarregarAtividadeEmAndamento()
        {
            Atividade atividade = new();

            var AtividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            string textoAtividade = $"{AtividadeEmAndamento.Id} - {AtividadeEmAndamento.Titulo}";
            textBoxAtividadeEmAndamento.Text = AtividadeEmAndamento.Id < 0 ? textoAtividade : string.Empty;
        }
    }
}