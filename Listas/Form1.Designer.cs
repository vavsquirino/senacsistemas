namespace Aula_2___Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            BoxUsuário = new TextBox();
            BoxSenha = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelresultado = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            EntrarCriar = new Button();
            BoxSenhaCriar = new TextBox();
            BoxUsuarioCriar = new TextBox();
            labelRespostaCriar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BoxUsuário
            // 
            BoxUsuário.ForeColor = SystemColors.WindowText;
            BoxUsuário.Location = new Point(100, 165);
            BoxUsuário.Name = "BoxUsuário";
            BoxUsuário.Size = new Size(170, 23);
            BoxUsuário.TabIndex = 0;
            // 
            // BoxSenha
            // 
            BoxSenha.Location = new Point(131, 227);
            BoxSenha.Name = "BoxSenha";
            BoxSenha.Size = new Size(100, 23);
            BoxSenha.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(141, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 81);
            label1.Name = "label1";
            label1.Size = new Size(209, 31);
            label1.TabIndex = 3;
            label1.Text = "Acesse sua conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 147);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 209);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(357, 320);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(0, 15);
            labelresultado.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(811, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 209);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(542, 147);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 12;
            label5.Text = "Usuário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(469, 81);
            label6.Name = "label6";
            label6.Size = new Size(184, 31);
            label6.TabIndex = 11;
            label6.Text = "Crie sua conta";
            // 
            // EntrarCriar
            // 
            EntrarCriar.Location = new Point(524, 284);
            EntrarCriar.Name = "EntrarCriar";
            EntrarCriar.Size = new Size(75, 23);
            EntrarCriar.TabIndex = 10;
            EntrarCriar.Text = "Criar";
            EntrarCriar.UseVisualStyleBackColor = true;
            EntrarCriar.Click += EntrarCriar_Click;
            // 
            // BoxSenhaCriar
            // 
            BoxSenhaCriar.Location = new Point(514, 227);
            BoxSenhaCriar.Name = "BoxSenhaCriar";
            BoxSenhaCriar.Size = new Size(100, 23);
            BoxSenhaCriar.TabIndex = 9;
            // 
            // BoxUsuarioCriar
            // 
            BoxUsuarioCriar.ForeColor = SystemColors.WindowText;
            BoxUsuarioCriar.Location = new Point(483, 165);
            BoxUsuarioCriar.Name = "BoxUsuarioCriar";
            BoxUsuarioCriar.Size = new Size(170, 23);
            BoxUsuarioCriar.TabIndex = 8;
         
            // 
            // labelRespostaCriar
            // 
            labelRespostaCriar.AutoSize = true;
            labelRespostaCriar.Location = new Point(542, 339);
            labelRespostaCriar.Name = "labelRespostaCriar";
            labelRespostaCriar.Size = new Size(0, 15);
            labelRespostaCriar.TabIndex = 14;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRespostaCriar);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(EntrarCriar);
            Controls.Add(BoxSenhaCriar);
            Controls.Add(BoxUsuarioCriar);
            Controls.Add(labelresultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(BoxSenha);
            Controls.Add(BoxUsuário);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Login";
            RightToLeft = RightToLeft.No;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxUsuário;
        private TextBox BoxSenha;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelresultado;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button EntrarCriar;
        private TextBox BoxSenhaCriar;
        private TextBox BoxUsuarioCriar;
        private Label labelRespostaCriar;
    }
}
