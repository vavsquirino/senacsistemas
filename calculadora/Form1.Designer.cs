namespace calculadora
{
    partial class Perimetro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            listBoxOpcoes = new ListBox();
            radioQuadrado = new RadioButton();
            radioRetangulo = new RadioButton();
            labelResultado = new Label();
            textBoxLado = new TextBox();
            textBoxAltura = new TextBox();
            textBoxLargura = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 309);
            button1.Name = "button1";
            button1.Size = new Size(129, 31);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(195, 15);
            label1.TabIndex = 1;
            label1.Text = "Escolha a opção que deseja calcular";
            // 
            // listBoxOpcoes
            // 
            listBoxOpcoes.FormattingEnabled = true;
            listBoxOpcoes.ItemHeight = 15;
            listBoxOpcoes.Items.AddRange(new object[] { "Área", "Perímetro", "Volume" });
            listBoxOpcoes.Location = new Point(12, 120);
            listBoxOpcoes.Name = "listBoxOpcoes";
            listBoxOpcoes.Size = new Size(194, 19);
            listBoxOpcoes.TabIndex = 2;
            // 
            // radioQuadrado
            // 
            radioQuadrado.AutoSize = true;
            radioQuadrado.Location = new Point(13, 55);
            radioQuadrado.Name = "radioQuadrado";
            radioQuadrado.Size = new Size(78, 19);
            radioQuadrado.TabIndex = 3;
            radioQuadrado.TabStop = true;
            radioQuadrado.Text = "Quadrado";
            radioQuadrado.UseVisualStyleBackColor = true;
            radioQuadrado.CheckedChanged += radioQuadrado_CheckedChanged;
            // 
            // radioRetangulo
            // 
            radioRetangulo.AutoSize = true;
            radioRetangulo.Location = new Point(13, 80);
            radioRetangulo.Name = "radioRetangulo";
            radioRetangulo.Size = new Size(79, 19);
            radioRetangulo.TabIndex = 4;
            radioRetangulo.TabStop = true;
            radioRetangulo.Text = "Retangulo";
            radioRetangulo.UseVisualStyleBackColor = true;
            radioRetangulo.CheckedChanged += radioRetangulo_CheckedChanged;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(12, 356);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(62, 15);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "Resultado:";
            // 
            // textBoxLado
            // 
            textBoxLado.Location = new Point(12, 158);
            textBoxLado.Name = "textBoxLado";
            textBoxLado.Size = new Size(194, 23);
            textBoxLado.TabIndex = 6;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(13, 204);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(194, 23);
            textBoxAltura.TabIndex = 7;
            // 
            // textBoxLargura
            // 
            textBoxLargura.Location = new Point(12, 246);
            textBoxLargura.Name = "textBoxLargura";
            textBoxLargura.Size = new Size(194, 23);
            textBoxLargura.TabIndex = 8;
            // 
            // Perimetro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxLargura);
            Controls.Add(textBoxAltura);
            Controls.Add(textBoxLado);
            Controls.Add(labelResultado);
            Controls.Add(radioRetangulo);
            Controls.Add(radioQuadrado);
            Controls.Add(listBoxOpcoes);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Perimetro";
            Text = "Cálculo Perímetro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ListBox listBoxOpcoes;
        private RadioButton radioQuadrado;
        private RadioButton radioRetangulo;
        private Label labelResultado;
        private TextBox textBoxLado;
        private TextBox textBoxAltura;
        private TextBox textBoxLargura;
    }
}