﻿namespace Aula_2___Login
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BoxUsuário
            // 
            BoxUsuário.ForeColor = SystemColors.WindowText;
            BoxUsuário.Location = new Point(298, 151);
            BoxUsuário.Name = "BoxUsuário";
            BoxUsuário.Size = new Size(170, 23);
            BoxUsuário.TabIndex = 0;
            BoxUsuário.TextChanged += textBox1_TextChanged;
            // 
            // BoxSenha
            // 
            BoxSenha.Location = new Point(329, 213);
            BoxSenha.Name = "BoxSenha";
            BoxSenha.Size = new Size(100, 23);
            BoxSenha.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(339, 270);
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
            label1.Location = new Point(277, 67);
            label1.Name = "label1";
            label1.Size = new Size(209, 31);
            label1.TabIndex = 3;
            label1.Text = "Acesse sua conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 133);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 195);
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
            pictureBox1.Size = new Size(809, 522);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
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
    }
}
