namespace calculoEsfera
{
    partial class Form1
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
            labelAvisoPrincipal = new Label();
            BoxPerimetro = new TextBox();
            BoxVolume = new TextBox();
            BoxArea = new TextBox();
            BoxDiametro = new TextBox();
            labelPerimetro = new Label();
            labelDiametro = new Label();
            labelArea = new Label();
            labelVolume = new Label();
            labelRespostaAcao = new Label();
            button1 = new Button();
            BoxCircuferencia = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelAvisoPrincipal
            // 
            labelAvisoPrincipal.AutoSize = true;
            labelAvisoPrincipal.Location = new Point(20, 21);
            labelAvisoPrincipal.Name = "labelAvisoPrincipal";
            labelAvisoPrincipal.Size = new Size(160, 15);
            labelAvisoPrincipal.TabIndex = 0;
            labelAvisoPrincipal.Text = "Insira os valores para calcular";
            // 
            // BoxPerimetro
            // 
            BoxPerimetro.Location = new Point(20, 75);
            BoxPerimetro.Name = "BoxPerimetro";
            BoxPerimetro.Size = new Size(138, 23);
            BoxPerimetro.TabIndex = 1;
            BoxPerimetro.TextChanged += BoxPerimetro_TextChanged;
            // 
            // BoxVolume
            // 
            BoxVolume.Location = new Point(20, 254);
            BoxVolume.Name = "BoxVolume";
            BoxVolume.Size = new Size(138, 23);
            BoxVolume.TabIndex = 2;
            // 
            // BoxArea
            // 
            BoxArea.Location = new Point(20, 194);
            BoxArea.Name = "BoxArea";
            BoxArea.Size = new Size(138, 23);
            BoxArea.TabIndex = 3;
            // 
            // BoxDiametro
            // 
            BoxDiametro.Location = new Point(20, 133);
            BoxDiametro.Name = "BoxDiametro";
            BoxDiametro.Size = new Size(138, 23);
            BoxDiametro.TabIndex = 4;
            // 
            // labelPerimetro
            // 
            labelPerimetro.AutoSize = true;
            labelPerimetro.Location = new Point(20, 57);
            labelPerimetro.Name = "labelPerimetro";
            labelPerimetro.Size = new Size(59, 15);
            labelPerimetro.TabIndex = 5;
            labelPerimetro.Text = "Perímetro";
            // 
            // labelDiametro
            // 
            labelDiametro.AutoSize = true;
            labelDiametro.Location = new Point(20, 115);
            labelDiametro.Name = "labelDiametro";
            labelDiametro.Size = new Size(56, 15);
            labelDiametro.TabIndex = 6;
            labelDiametro.Text = "Diametro";
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(20, 176);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(31, 15);
            labelArea.TabIndex = 7;
            labelArea.Text = "Área";
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.Location = new Point(20, 236);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(47, 15);
            labelVolume.TabIndex = 8;
            labelVolume.Text = "Volume";
            // 
            // labelRespostaAcao
            // 
            labelRespostaAcao.AutoSize = true;
            labelRespostaAcao.Location = new Point(20, 313);
            labelRespostaAcao.Name = "labelRespostaAcao";
            labelRespostaAcao.Size = new Size(0, 15);
            labelRespostaAcao.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(24, 382);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 10;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BoxCircuferencia
            // 
            BoxCircuferencia.Location = new Point(20, 313);
            BoxCircuferencia.Name = "BoxCircuferencia";
            BoxCircuferencia.Size = new Size(138, 23);
            BoxCircuferencia.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 295);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 12;
            label1.Text = "Circuferência";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BoxCircuferencia);
            Controls.Add(button1);
            Controls.Add(labelRespostaAcao);
            Controls.Add(labelVolume);
            Controls.Add(labelArea);
            Controls.Add(labelDiametro);
            Controls.Add(labelPerimetro);
            Controls.Add(BoxDiametro);
            Controls.Add(BoxArea);
            Controls.Add(BoxVolume);
            Controls.Add(BoxPerimetro);
            Controls.Add(labelAvisoPrincipal);
            Name = "Form1";
            Text = "Cálculo Círculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAvisoPrincipal;
        private TextBox BoxPerimetro;
        private TextBox BoxVolume;
        private TextBox BoxArea;
        private TextBox BoxDiametro;
        private Label labelPerimetro;
        private Label labelDiametro;
        private Label labelArea;
        private Label labelVolume;
        private Label labelRespostaAcao;
        private Button button1;
        private TextBox BoxCircuferencia;
        private Label label1;
    }
}
