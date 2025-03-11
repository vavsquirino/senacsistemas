namespace calculadora
{
    partial class Calculadora
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
            BoxValor1 = new TextBox();
            labelResultado = new Label();
            button1 = new Button();
            BoxValor2 = new TextBox();
            SuspendLayout();
            // 
            // BoxValor1
            // 
            BoxValor1.Location = new Point(323, 54);
            BoxValor1.Name = "BoxValor1";
            BoxValor1.Size = new Size(182, 23);
            BoxValor1.TabIndex = 0;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(345, 270);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(160, 15);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Insira os valores para calcular";
            // 
            // button1
            // 
            button1.Location = new Point(381, 209);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BoxValor2
            // 
            BoxValor2.Location = new Point(323, 143);
            BoxValor2.Name = "BoxValor2";
            BoxValor2.Size = new Size(182, 23);
            BoxValor2.TabIndex = 4;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BoxValor2);
            Controls.Add(button1);
            Controls.Add(labelResultado);
            Controls.Add(BoxValor1);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxValor1;
        private Label labelResultado;
        private Button button1;
        private TextBox BoxValor2;
    }
}
