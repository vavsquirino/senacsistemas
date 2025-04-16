namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        public ListaDeAtividades()
        {
            InitializeComponent();
        }
    }

    public void ListaDeAtividades_Load(object sender, EventArgs e)
    {
        atividade atividade = new ();

        var atividadeEmAndamento = atividade. BuscarAtividadeEmAndamento();

        if (atividadeEmAndamento.Id > 0)
        {
            textBoxAtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
        }

        var atividadesPendentes = atividade.ListarAtividadePendentes();
        DataGridViewAtividades.DataSource = atividadesPendentes;
    }
