namespace ListaAtividades
{
    partial class ListaDeAtividades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAtividadeEmAndamento = new TextBox();
            buttonFinalizar = new Button();
            DataGridViewAtividades = new DataGridView();
            buttonAtualizar = new Button();
            buttonCriar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAtividades).BeginInit();
            SuspendLayout();
            // 
            // textBoxAtividadeEmAndamento
            // 
            textBoxAtividadeEmAndamento.Location = new Point(23, 17);
            textBoxAtividadeEmAndamento.Name = "textBoxAtividadeEmAndamento";
            textBoxAtividadeEmAndamento.ReadOnly = true;
            textBoxAtividadeEmAndamento.Size = new Size(601, 23);
            textBoxAtividadeEmAndamento.TabIndex = 0;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(632, 17);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(143, 23);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
 
            // 
            // DataGridViewAtividades
            // 
            DataGridViewAtividades.AllowUserToAddRows = false;
            DataGridViewAtividades.AllowUserToDeleteRows = false;
            DataGridViewAtividades.AllowUserToResizeColumns = false;
            DataGridViewAtividades.AllowUserToResizeRows = false;
            DataGridViewAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewAtividades.Location = new Point(23, 52);
            DataGridViewAtividades.MultiSelect = false;
            DataGridViewAtividades.Name = "DataGridViewAtividades";
            DataGridViewAtividades.ReadOnly = true;
            DataGridViewAtividades.Size = new Size(601, 336);
            DataGridViewAtividades.TabIndex = 2;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(632, 52);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(143, 23);
            buttonAtualizar.TabIndex = 3;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(632, 365);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(143, 23);
            buttonCriar.TabIndex = 4;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 414);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // ListaDeAtividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonCriar);
            Controls.Add(buttonAtualizar);
            Controls.Add(DataGridViewAtividades);
            Controls.Add(buttonFinalizar);
            Controls.Add(textBoxAtividadeEmAndamento);
            Name = "ListaDeAtividades";
            Text = "Lista de Atividades";
            ((System.ComponentModel.ISupportInitialize)DataGridViewAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAtividadeEmAndamento;
        private Button buttonFinalizar;
        private DataGridView DataGridViewAtividades;
        private Button buttonAtualizar;
        private Button buttonCriar;
        private Label label1;
    }
}
