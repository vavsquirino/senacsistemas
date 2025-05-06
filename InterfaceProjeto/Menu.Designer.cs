namespace InterfaceProjeto
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            buttonCriarPedido = new Button();
            label1 = new Label();
            buttonCriarCliente = new Button();
            buttonEditarPedido = new Button();
            SuspendLayout();
            // 
            // buttonCriarPedido
            // 
            buttonCriarPedido.Anchor = AnchorStyles.None;
            buttonCriarPedido.BackColor = Color.FromArgb(224, 224, 224);
            buttonCriarPedido.Cursor = Cursors.Hand;
            buttonCriarPedido.FlatAppearance.BorderSize = 0;
            buttonCriarPedido.FlatStyle = FlatStyle.Flat;
            buttonCriarPedido.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonCriarPedido.ForeColor = SystemColors.ActiveCaptionText;
            buttonCriarPedido.Image = (Image)resources.GetObject("buttonCriarPedido.Image");
            buttonCriarPedido.Location = new Point(805, 430);
            buttonCriarPedido.Name = "buttonCriarPedido";
            buttonCriarPedido.Size = new Size(300, 300);
            buttonCriarPedido.TabIndex = 0;
            buttonCriarPedido.Text = "\r\n\r\nCriar pedido";
            buttonCriarPedido.TextAlign = ContentAlignment.TopCenter;
            buttonCriarPedido.UseVisualStyleBackColor = false;
            buttonCriarPedido.Click += buttonCriarPedido_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(915, 1013);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // buttonCriarCliente
            // 
            buttonCriarCliente.Anchor = AnchorStyles.None;
            buttonCriarCliente.BackColor = Color.FromArgb(224, 224, 224);
            buttonCriarCliente.Cursor = Cursors.Hand;
            buttonCriarCliente.FlatAppearance.BorderSize = 0;
            buttonCriarCliente.FlatStyle = FlatStyle.Flat;
            buttonCriarCliente.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCriarCliente.ForeColor = Color.Black;
            buttonCriarCliente.Image = (Image)resources.GetObject("buttonCriarCliente.Image");
            buttonCriarCliente.Location = new Point(499, 430);
            buttonCriarCliente.Name = "buttonCriarCliente";
            buttonCriarCliente.Size = new Size(300, 300);
            buttonCriarCliente.TabIndex = 2;
            buttonCriarCliente.Text = "\r\n\r\nCriar cliente";
            buttonCriarCliente.TextAlign = ContentAlignment.TopCenter;
            buttonCriarCliente.UseVisualStyleBackColor = false;
            buttonCriarCliente.Click += buttonCriarCliente_Click;
            buttonCriarCliente.MouseEnter += buttonCriarCliente_MouseEnter;
            buttonCriarCliente.MouseLeave += buttonCriarCliente_MouseLeave;
            // 
            // buttonEditarPedido
            // 
            buttonEditarPedido.Anchor = AnchorStyles.None;
            buttonEditarPedido.BackColor = Color.FromArgb(224, 224, 224);
            buttonEditarPedido.Cursor = Cursors.Hand;
            buttonEditarPedido.FlatAppearance.BorderSize = 0;
            buttonEditarPedido.FlatStyle = FlatStyle.Flat;
            buttonEditarPedido.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            buttonEditarPedido.ForeColor = Color.Black;
            buttonEditarPedido.Image = (Image)resources.GetObject("buttonEditarPedido.Image");
            buttonEditarPedido.Location = new Point(1111, 430);
            buttonEditarPedido.Name = "buttonEditarPedido";
            buttonEditarPedido.Size = new Size(300, 300);
            buttonEditarPedido.TabIndex = 3;
            buttonEditarPedido.Text = "\r\n\r\nEditar pedido ";
            buttonEditarPedido.TextAlign = ContentAlignment.TopCenter;
            buttonEditarPedido.UseVisualStyleBackColor = false;
            buttonEditarPedido.Click += buttonEditarPedido_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1900, 1037);
            Controls.Add(buttonEditarPedido);
            Controls.Add(buttonCriarCliente);
            Controls.Add(label1);
            Controls.Add(buttonCriarPedido);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCriarPedido;
        private Label label1;
        private Button buttonCriarCliente;
        private Button buttonEditarPedido;
    }
}
