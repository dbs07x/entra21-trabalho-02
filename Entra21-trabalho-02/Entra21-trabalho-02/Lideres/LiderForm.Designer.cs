namespace Entra21_trabalho_02.Lideres
{
    partial class LiderForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInicioLideranca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFimLideranca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChakra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKekkeiGenkai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelInicioLideranca = new System.Windows.Forms.Label();
            this.labelFimLideranca = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelElementoChakra = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxTitulo = new System.Windows.Forms.ComboBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.comboBoxChakra = new System.Windows.Forms.ComboBox();
            this.dateTimePickerInicioLideranca = new System.Windows.Forms.DateTimePicker();
            this.radioButtonVivo = new System.Windows.Forms.RadioButton();
            this.radioButtonMorto = new System.Windows.Forms.RadioButton();
            this.checkBoxMasculino = new System.Windows.Forms.CheckBox();
            this.checkBoxCisgenero = new System.Windows.Forms.CheckBox();
            this.checkBoxFeminino = new System.Windows.Forms.CheckBox();
            this.checkBoxTransgenero = new System.Windows.Forms.CheckBox();
            this.checkBoxNaoBinario = new System.Windows.Forms.CheckBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.maskedTextBoxFimLideranca = new System.Windows.Forms.MaskedTextBox();
            this.labelKekkeiGenkai = new System.Windows.Forms.Label();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnTitulo,
            this.ColumnIdade,
            this.ColumnGenero,
            this.ColumnInicioLideranca,
            this.ColumnFimLideranca,
            this.ColumnStatus,
            this.ColumnChakra,
            this.ColumnKekkeiGenkai,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(342, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Codigo";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 65;
            // 
            // ColumnTitulo
            // 
            this.ColumnTitulo.HeaderText = "Nome";
            this.ColumnTitulo.MinimumWidth = 6;
            this.ColumnTitulo.Name = "ColumnTitulo";
            this.ColumnTitulo.ReadOnly = true;
            // 
            // ColumnIdade
            // 
            this.ColumnIdade.HeaderText = "Titulo";
            this.ColumnIdade.MinimumWidth = 6;
            this.ColumnIdade.Name = "ColumnIdade";
            this.ColumnIdade.ReadOnly = true;
            // 
            // ColumnGenero
            // 
            this.ColumnGenero.HeaderText = "Idade";
            this.ColumnGenero.MinimumWidth = 6;
            this.ColumnGenero.Name = "ColumnGenero";
            this.ColumnGenero.ReadOnly = true;
            this.ColumnGenero.Width = 60;
            // 
            // ColumnInicioLideranca
            // 
            this.ColumnInicioLideranca.HeaderText = "Genero";
            this.ColumnInicioLideranca.MinimumWidth = 6;
            this.ColumnInicioLideranca.Name = "ColumnInicioLideranca";
            this.ColumnInicioLideranca.ReadOnly = true;
            this.ColumnInicioLideranca.Width = 125;
            // 
            // ColumnFimLideranca
            // 
            this.ColumnFimLideranca.HeaderText = "Inicio da Liderança";
            this.ColumnFimLideranca.MinimumWidth = 6;
            this.ColumnFimLideranca.Name = "ColumnFimLideranca";
            this.ColumnFimLideranca.ReadOnly = true;
            this.ColumnFimLideranca.Width = 125;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Fim da Liderança";
            this.ColumnStatus.MinimumWidth = 6;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 125;
            // 
            // ColumnChakra
            // 
            this.ColumnChakra.HeaderText = "Status";
            this.ColumnChakra.MinimumWidth = 6;
            this.ColumnChakra.Name = "ColumnChakra";
            this.ColumnChakra.ReadOnly = true;
            this.ColumnChakra.Width = 80;
            // 
            // ColumnKekkeiGenkai
            // 
            this.ColumnKekkeiGenkai.HeaderText = "Elemento Chakra";
            this.ColumnKekkeiGenkai.MinimumWidth = 6;
            this.ColumnKekkeiGenkai.Name = "ColumnKekkeiGenkai";
            this.ColumnKekkeiGenkai.ReadOnly = true;
            this.ColumnKekkeiGenkai.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Kekkei Genkai";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(194, 546);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(120, 71);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(342, 58);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 40);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(423, 58);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(80, 40);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(12, 34);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 21);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(12, 83);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(49, 21);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.BackColor = System.Drawing.Color.Transparent;
            this.labelIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdade.Location = new System.Drawing.Point(12, 134);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(48, 21);
            this.labelIdade.TabIndex = 6;
            this.labelIdade.Text = "Idade";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.BackColor = System.Drawing.Color.Transparent;
            this.labelGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGenero.Location = new System.Drawing.Point(12, 184);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(61, 21);
            this.labelGenero.TabIndex = 7;
            this.labelGenero.Text = "Genero";
            // 
            // labelInicioLideranca
            // 
            this.labelInicioLideranca.AutoSize = true;
            this.labelInicioLideranca.BackColor = System.Drawing.Color.Transparent;
            this.labelInicioLideranca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInicioLideranca.Location = new System.Drawing.Point(12, 267);
            this.labelInicioLideranca.Name = "labelInicioLideranca";
            this.labelInicioLideranca.Size = new System.Drawing.Size(139, 21);
            this.labelInicioLideranca.TabIndex = 8;
            this.labelInicioLideranca.Text = "Início da Liderança";
            // 
            // labelFimLideranca
            // 
            this.labelFimLideranca.AutoSize = true;
            this.labelFimLideranca.BackColor = System.Drawing.Color.Transparent;
            this.labelFimLideranca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFimLideranca.Location = new System.Drawing.Point(12, 317);
            this.labelFimLideranca.Name = "labelFimLideranca";
            this.labelFimLideranca.Size = new System.Drawing.Size(128, 21);
            this.labelFimLideranca.TabIndex = 9;
            this.labelFimLideranca.Text = "Fim da Liderança";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(12, 365);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 21);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status";
            // 
            // labelElementoChakra
            // 
            this.labelElementoChakra.AutoSize = true;
            this.labelElementoChakra.BackColor = System.Drawing.Color.Transparent;
            this.labelElementoChakra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElementoChakra.Location = new System.Drawing.Point(12, 427);
            this.labelElementoChakra.Name = "labelElementoChakra";
            this.labelElementoChakra.Size = new System.Drawing.Size(128, 21);
            this.labelElementoChakra.TabIndex = 11;
            this.labelElementoChakra.Text = "Elemento Chakra";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(13, 58);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(302, 23);
            this.textBoxNome.TabIndex = 12;
            // 
            // comboBoxTitulo
            // 
            this.comboBoxTitulo.FormattingEnabled = true;
            this.comboBoxTitulo.Location = new System.Drawing.Point(12, 108);
            this.comboBoxTitulo.Name = "comboBoxTitulo";
            this.comboBoxTitulo.Size = new System.Drawing.Size(302, 23);
            this.comboBoxTitulo.TabIndex = 13;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(13, 158);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(301, 23);
            this.textBoxIdade.TabIndex = 14;
            // 
            // comboBoxChakra
            // 
            this.comboBoxChakra.FormattingEnabled = true;
            this.comboBoxChakra.Location = new System.Drawing.Point(12, 453);
            this.comboBoxChakra.Name = "comboBoxChakra";
            this.comboBoxChakra.Size = new System.Drawing.Size(302, 23);
            this.comboBoxChakra.TabIndex = 15;
            // 
            // dateTimePickerInicioLideranca
            // 
            this.dateTimePickerInicioLideranca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicioLideranca.Location = new System.Drawing.Point(12, 291);
            this.dateTimePickerInicioLideranca.Name = "dateTimePickerInicioLideranca";
            this.dateTimePickerInicioLideranca.Size = new System.Drawing.Size(302, 23);
            this.dateTimePickerInicioLideranca.TabIndex = 16;
            // 
            // radioButtonVivo
            // 
            this.radioButtonVivo.AutoSize = true;
            this.radioButtonVivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonVivo.Location = new System.Drawing.Point(6, 14);
            this.radioButtonVivo.Name = "radioButtonVivo";
            this.radioButtonVivo.Size = new System.Drawing.Size(51, 21);
            this.radioButtonVivo.TabIndex = 18;
            this.radioButtonVivo.TabStop = true;
            this.radioButtonVivo.Text = "Vivo";
            this.radioButtonVivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonMorto
            // 
            this.radioButtonMorto.AutoSize = true;
            this.radioButtonMorto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMorto.Location = new System.Drawing.Point(214, 14);
            this.radioButtonMorto.Name = "radioButtonMorto";
            this.radioButtonMorto.Size = new System.Drawing.Size(63, 21);
            this.radioButtonMorto.TabIndex = 19;
            this.radioButtonMorto.TabStop = true;
            this.radioButtonMorto.Text = "Morto";
            this.radioButtonMorto.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.AutoSize = true;
            this.checkBoxMasculino.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMasculino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMasculino.Location = new System.Drawing.Point(12, 211);
            this.checkBoxMasculino.Name = "checkBoxMasculino";
            this.checkBoxMasculino.Size = new System.Drawing.Size(86, 21);
            this.checkBoxMasculino.TabIndex = 20;
            this.checkBoxMasculino.Text = "Masculino";
            this.checkBoxMasculino.UseVisualStyleBackColor = false;
            // 
            // checkBoxCisgenero
            // 
            this.checkBoxCisgenero.AutoSize = true;
            this.checkBoxCisgenero.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCisgenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCisgenero.Location = new System.Drawing.Point(19, 245);
            this.checkBoxCisgenero.Name = "checkBoxCisgenero";
            this.checkBoxCisgenero.Size = new System.Drawing.Size(86, 21);
            this.checkBoxCisgenero.TabIndex = 21;
            this.checkBoxCisgenero.Text = "Cisgênero";
            this.checkBoxCisgenero.UseVisualStyleBackColor = false;
            // 
            // checkBoxFeminino
            // 
            this.checkBoxFeminino.AutoSize = true;
            this.checkBoxFeminino.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFeminino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFeminino.Location = new System.Drawing.Point(126, 211);
            this.checkBoxFeminino.Name = "checkBoxFeminino";
            this.checkBoxFeminino.Size = new System.Drawing.Size(79, 21);
            this.checkBoxFeminino.TabIndex = 22;
            this.checkBoxFeminino.Text = "Feminino";
            this.checkBoxFeminino.UseVisualStyleBackColor = false;
            // 
            // checkBoxTransgenero
            // 
            this.checkBoxTransgenero.AutoSize = true;
            this.checkBoxTransgenero.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTransgenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTransgenero.Location = new System.Drawing.Point(126, 245);
            this.checkBoxTransgenero.Name = "checkBoxTransgenero";
            this.checkBoxTransgenero.Size = new System.Drawing.Size(100, 21);
            this.checkBoxTransgenero.TabIndex = 23;
            this.checkBoxTransgenero.Text = "Transgênero";
            this.checkBoxTransgenero.UseVisualStyleBackColor = false;
            // 
            // checkBoxNaoBinario
            // 
            this.checkBoxNaoBinario.AutoSize = true;
            this.checkBoxNaoBinario.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxNaoBinario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNaoBinario.Location = new System.Drawing.Point(232, 211);
            this.checkBoxNaoBinario.Name = "checkBoxNaoBinario";
            this.checkBoxNaoBinario.Size = new System.Drawing.Size(97, 21);
            this.checkBoxNaoBinario.TabIndex = 24;
            this.checkBoxNaoBinario.Text = "Não-Binario";
            this.checkBoxNaoBinario.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(57, 546);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(122, 71);
            this.buttonCancelar.TabIndex = 25;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // maskedTextBoxFimLideranca
            // 
            this.maskedTextBoxFimLideranca.Location = new System.Drawing.Point(13, 340);
            this.maskedTextBoxFimLideranca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxFimLideranca.Mask = "99/99/9999";
            this.maskedTextBoxFimLideranca.Name = "maskedTextBoxFimLideranca";
            this.maskedTextBoxFimLideranca.Size = new System.Drawing.Size(302, 23);
            this.maskedTextBoxFimLideranca.TabIndex = 26;
            // 
            // labelKekkeiGenkai
            // 
            this.labelKekkeiGenkai.AutoSize = true;
            this.labelKekkeiGenkai.BackColor = System.Drawing.Color.Transparent;
            this.labelKekkeiGenkai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKekkeiGenkai.Location = new System.Drawing.Point(12, 479);
            this.labelKekkeiGenkai.Name = "labelKekkeiGenkai";
            this.labelKekkeiGenkai.Size = new System.Drawing.Size(107, 21);
            this.labelKekkeiGenkai.TabIndex = 27;
            this.labelKekkeiGenkai.Text = "Kekkei Genkai";
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonSim.Location = new System.Drawing.Point(6, 11);
            this.radioButtonSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(47, 21);
            this.radioButtonSim.TabIndex = 28;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNao.Location = new System.Drawing.Point(220, 11);
            this.radioButtonNao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(51, 21);
            this.radioButtonNao.TabIndex = 29;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonVivo);
            this.groupBox1.Controls.Add(this.radioButtonMorto);
            this.groupBox1.Location = new System.Drawing.Point(12, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 48);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButtonNao);
            this.groupBox2.Controls.Add(this.radioButtonSim);
            this.groupBox2.Location = new System.Drawing.Point(12, 497);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 35);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // LiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Entra21_trabalho_02.Properties.Resources.kakashi_naruto_reprod_shonen_jump_widelg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1425, 637);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelKekkeiGenkai);
            this.Controls.Add(this.maskedTextBoxFimLideranca);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.checkBoxNaoBinario);
            this.Controls.Add(this.checkBoxTransgenero);
            this.Controls.Add(this.checkBoxFeminino);
            this.Controls.Add(this.checkBoxCisgenero);
            this.Controls.Add(this.checkBoxMasculino);
            this.Controls.Add(this.dateTimePickerInicioLideranca);
            this.Controls.Add(this.comboBoxChakra);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.comboBoxTitulo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelElementoChakra);
            this.Controls.Add(this.labelFimLideranca);
            this.Controls.Add(this.labelInicioLideranca);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LiderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Lider";
            this.Load += new System.EventHandler(this.LiderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelNome;
        private Label labelTitulo;
        private Label labelIdade;
        private Label labelGenero;
        private Label labelInicioLideranca;
        private Label labelFimLideranca;
        private Label labelStatus;
        private Label labelElementoChakra;
        private TextBox textBoxNome;
        private ComboBox comboBoxTitulo;
        private TextBox textBoxIdade;
        private ComboBox comboBoxChakra;
        private DateTimePicker dateTimePickerInicioLideranca;
        private RadioButton radioButtonVivo;
        private RadioButton radioButtonMorto;
        private CheckBox checkBoxMasculino;
        private CheckBox checkBoxCisgenero;
        private CheckBox checkBoxFeminino;
        private CheckBox checkBoxTransgenero;
        private CheckBox checkBoxNaoBinario;
        private MaskedTextBox maskedTextBoxFimLideranca;
        private RadioButton radioButtonSim;
        private Button buttonCancelar;
        private Label labelKekkeiGenkai;
        private RadioButton radioButtonNao;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnTitulo;
        private DataGridViewTextBoxColumn ColumnIdade;
        private DataGridViewTextBoxColumn ColumnGenero;
        private DataGridViewTextBoxColumn ColumnInicioLideranca;
        private DataGridViewTextBoxColumn ColumnFimLideranca;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnChakra;
        private DataGridViewTextBoxColumn ColumnKekkeiGenkai;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}