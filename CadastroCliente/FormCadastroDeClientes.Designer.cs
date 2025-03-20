namespace CadastroCliente
{
    partial class FormCadastroDeClientes
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
            labelRealizeCadastro = new Label();
            textBoxNome = new TextBox();
            maskedTextBoxNasci = new MaskedTextBox();
            maskedTextBoxTel = new MaskedTextBox();
            textBoxEmail = new TextBox();
            comboBoxGenero = new ComboBox();
            textBoxSocial = new TextBox();
            comboBoxEtnia = new ComboBox();
            checkBoxEstrangeiro = new CheckBox();
            radioButtonTipoFisica = new RadioButton();
            radioButtonTipoJuridica = new RadioButton();
            textBoxLogradouro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxComple = new TextBox();
            textBoxBairro = new TextBox();
            textBoxCidade = new TextBox();
            comboBoxEstado = new ComboBox();
            maskedTextBoxCep = new MaskedTextBox();
            labelEndereco = new Label();
            labelCep = new Label();
            labelEstado = new Label();
            labelCidade = new Label();
            labelBairro = new Label();
            labelComple = new Label();
            labelNumero = new Label();
            labelLogradouro = new Label();
            labelNome = new Label();
            labelNascimento = new Label();
            labelTelefone = new Label();
            labelEmail = new Label();
            labelGenero = new Label();
            labelSocial = new Label();
            labelEtnia = new Label();
            button1 = new Button();
            labelResultado = new Label();
            textBoxSobrenome = new TextBox();
            labelSobrenome = new Label();
            SuspendLayout();
            // 
            // labelRealizeCadastro
            // 
            labelRealizeCadastro.AutoSize = true;
            labelRealizeCadastro.Location = new Point(22, 37);
            labelRealizeCadastro.Name = "labelRealizeCadastro";
            labelRealizeCadastro.Size = new Size(312, 15);
            labelRealizeCadastro.TabIndex = 0;
            labelRealizeCadastro.Text = "Para realizar seu cadastro, preencha todas as informações:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(23, 88);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(121, 23);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxNasci
            // 
            maskedTextBoxNasci.Location = new Point(277, 88);
            maskedTextBoxNasci.Mask = "00/00/0000";
            maskedTextBoxNasci.Name = "maskedTextBoxNasci";
            maskedTextBoxNasci.Size = new Size(113, 23);
            maskedTextBoxNasci.TabIndex = 2;
            maskedTextBoxNasci.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(396, 88);
            maskedTextBoxTel.Mask = "(00)00000-9999";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(133, 23);
            maskedTextBoxTel.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(535, 88);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(129, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(23, 144);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(132, 23);
            comboBoxGenero.TabIndex = 5;
            // 
            // textBoxSocial
            // 
            textBoxSocial.Location = new Point(161, 144);
            textBoxSocial.Name = "textBoxSocial";
            textBoxSocial.Size = new Size(131, 23);
            textBoxSocial.TabIndex = 6;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Location = new Point(298, 144);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(135, 23);
            comboBoxEtnia.TabIndex = 7;
            // 
            // checkBoxEstrangeiro
            // 
            checkBoxEstrangeiro.AutoSize = true;
            checkBoxEstrangeiro.Location = new Point(444, 146);
            checkBoxEstrangeiro.Name = "checkBoxEstrangeiro";
            checkBoxEstrangeiro.Size = new Size(85, 19);
            checkBoxEstrangeiro.TabIndex = 8;
            checkBoxEstrangeiro.Text = "Estrangeiro";
            checkBoxEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipoFisica
            // 
            radioButtonTipoFisica.AutoSize = true;
            radioButtonTipoFisica.Location = new Point(560, 145);
            radioButtonTipoFisica.Name = "radioButtonTipoFisica";
            radioButtonTipoFisica.Size = new Size(93, 19);
            radioButtonTipoFisica.TabIndex = 9;
            radioButtonTipoFisica.TabStop = true;
            radioButtonTipoFisica.Text = "Pessoa Física";
            radioButtonTipoFisica.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipoJuridica
            // 
            radioButtonTipoJuridica.AutoSize = true;
            radioButtonTipoJuridica.Location = new Point(560, 170);
            radioButtonTipoJuridica.Name = "radioButtonTipoJuridica";
            radioButtonTipoJuridica.Size = new Size(104, 19);
            radioButtonTipoJuridica.TabIndex = 10;
            radioButtonTipoJuridica.TabStop = true;
            radioButtonTipoJuridica.Text = "Pessoa Jurídica";
            radioButtonTipoJuridica.UseVisualStyleBackColor = true;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(22, 299);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(135, 23);
            textBoxLogradouro.TabIndex = 11;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(163, 299);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(89, 23);
            textBoxNumero.TabIndex = 12;
            // 
            // textBoxComple
            // 
            textBoxComple.Location = new Point(258, 299);
            textBoxComple.Name = "textBoxComple";
            textBoxComple.Size = new Size(131, 23);
            textBoxComple.TabIndex = 13;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(395, 299);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(133, 23);
            textBoxBairro.TabIndex = 14;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(534, 299);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(130, 23);
            textBoxCidade.TabIndex = 15;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(22, 352);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(133, 23);
            comboBoxEstado.TabIndex = 16;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(163, 352);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(89, 23);
            maskedTextBoxCep.TabIndex = 17;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(19, 252);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(125, 15);
            labelEndereco.TabIndex = 18;
            labelEndereco.Text = "Cadastro de Endereço:";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(163, 330);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(28, 15);
            labelCep.TabIndex = 21;
            labelCep.Text = "Cep";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(22, 334);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 22;
            labelEstado.Text = "Estado";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(534, 281);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(44, 15);
            labelCidade.TabIndex = 23;
            labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(395, 281);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 24;
            labelBairro.Text = "Bairro";
            // 
            // labelComple
            // 
            labelComple.AutoSize = true;
            labelComple.Location = new Point(258, 281);
            labelComple.Name = "labelComple";
            labelComple.Size = new Size(84, 15);
            labelComple.TabIndex = 25;
            labelComple.Text = "Complemento";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(163, 281);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 26;
            labelNumero.Text = "Número";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(22, 281);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 27;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(20, 70);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 28;
            labelNome.Text = "Nome";
            // 
            // labelNascimento
            // 
            labelNascimento.AutoSize = true;
            labelNascimento.Location = new Point(274, 70);
            labelNascimento.Name = "labelNascimento";
            labelNascimento.Size = new Size(115, 15);
            labelNascimento.TabIndex = 29;
            labelNascimento.Text = "Data De Nascimento";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(396, 70);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 30;
            labelTelefone.Text = "Telefone";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(535, 70);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 31;
            labelEmail.Text = "E-mail";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(23, 126);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 32;
            labelGenero.Text = "Gênero";
            // 
            // labelSocial
            // 
            labelSocial.AutoSize = true;
            labelSocial.Location = new Point(161, 126);
            labelSocial.Name = "labelSocial";
            labelSocial.Size = new Size(74, 15);
            labelSocial.TabIndex = 33;
            labelSocial.Text = "Nome Social";
            // 
            // labelEtnia
            // 
            labelEtnia.AutoSize = true;
            labelEtnia.Location = new Point(298, 126);
            labelEtnia.Name = "labelEtnia";
            labelEtnia.Size = new Size(33, 15);
            labelEtnia.TabIndex = 34;
            labelEtnia.Text = "Etnia";
            // 
            // button1
            // 
            button1.Location = new Point(262, 413);
            button1.Name = "button1";
            button1.Size = new Size(146, 27);
            button1.TabIndex = 35;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(214, 454);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 36;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(153, 88);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(118, 23);
            textBoxSobrenome.TabIndex = 37;
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Location = new Point(153, 70);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(68, 15);
            labelSobrenome.TabIndex = 38;
            labelSobrenome.Text = "Sobrenome";
            // 
            // FormCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(691, 495);
            Controls.Add(labelSobrenome);
            Controls.Add(textBoxSobrenome);
            Controls.Add(labelResultado);
            Controls.Add(button1);
            Controls.Add(labelEtnia);
            Controls.Add(labelSocial);
            Controls.Add(labelGenero);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefone);
            Controls.Add(labelNascimento);
            Controls.Add(labelNome);
            Controls.Add(labelLogradouro);
            Controls.Add(labelNumero);
            Controls.Add(labelComple);
            Controls.Add(labelBairro);
            Controls.Add(labelCidade);
            Controls.Add(labelEstado);
            Controls.Add(labelCep);
            Controls.Add(labelEndereco);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxCidade);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxComple);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(radioButtonTipoJuridica);
            Controls.Add(radioButtonTipoFisica);
            Controls.Add(checkBoxEstrangeiro);
            Controls.Add(comboBoxEtnia);
            Controls.Add(textBoxSocial);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxEmail);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(maskedTextBoxNasci);
            Controls.Add(textBoxNome);
            Controls.Add(labelRealizeCadastro);
            Name = "FormCadastroDeClientes";
            Text = " Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRealizeCadastro;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxNasci;
        private MaskedTextBox maskedTextBoxTel;
        private TextBox textBoxEmail;
        private ComboBox comboBoxGenero;
        private TextBox textBoxSocial;
        private ComboBox comboBoxEtnia;
        private CheckBox checkBoxEstrangeiro;
        private RadioButton radioButtonTipoFisica;
        private RadioButton radioButtonTipoJuridica;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private TextBox textBoxComple;
        private TextBox textBoxBairro;
        private TextBox textBoxCidade;
        private ComboBox comboBoxEstado;
        private MaskedTextBox maskedTextBoxCep;
        private Label labelEndereco;
        private Label labelCep;
        private Label labelEstado;
        private Label labelCidade;
        private Label labelBairro;
        private Label labelComple;
        private Label labelNumero;
        private Label labelLogradouro;
        private Label labelNome;
        private Label labelNascimento;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelGenero;
        private Label labelSocial;
        private Label labelEtnia;
        private Button button1;
        private Label labelResultado;
        private TextBox textBoxSobrenome;
        private Label labelSobrenome;
    }
}
