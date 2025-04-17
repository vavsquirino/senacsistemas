using ListaAtividades.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAtividades
{
    public partial class criarAtiv : Form
    {
        public criarAtiv()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            labelErro = new Label();
            buttonDescartar = new Button();
            buttonCriar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(27, 365);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 0;
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(199, 204);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(143, 27);
            buttonDescartar.TabIndex = 1;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.UseVisualStyleBackColor = true;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(348, 205);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(149, 26);
            buttonCriar.TabIndex = 2;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 3;
            // 
            // criarAtiv
            // 
            ClientSize = new Size(690, 405);
            Controls.Add(textBox1);
            Controls.Add(buttonCriar);
            Controls.Add(buttonDescartar);
            Controls.Add(labelErro);
            Name = "criarAtiv";
            Load += criarAtiv_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade()
            {
                Titulo = textBox1.Text
            };

            if (!atividade.Criar())
            {
                MessageBox.Show("Atividade foi criada");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private Label labelErro;
        private Button buttonDescartar;
        private TextBox textBox1;
        private Button buttonCriar;

        private void criarAtiv_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
        }
    }
}
