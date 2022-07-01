namespace Entra21_trabalho_02.Ninjas
{
    partial class NinjaForm
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
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.radioButtonVivo = new System.Windows.Forms.RadioButton();
            this.radioButtonMorto = new System.Windows.Forms.RadioButton();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.labelNivel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCla = new System.Windows.Forms.Label();
            this.maskedTextBoxDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCla = new System.Windows.Forms.ComboBox();
            this.labelAldeia = new System.Windows.Forms.Label();
            this.comboBoxAldeia = new System.Windows.Forms.ComboBox();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.checkBoxMasculino = new System.Windows.Forms.CheckBox();
            this.checkBoxFeminino = new System.Windows.Forms.CheckBox();
            this.checkBoxNaoBinario = new System.Windows.Forms.CheckBox();
            this.checkBoxCisgenero = new System.Windows.Forms.CheckBox();
            this.checkBoxTransgenero = new System.Windows.Forms.CheckBox();
            this.labelElementoChakra = new System.Windows.Forms.Label();
            this.comboBoxElementoChakra = new System.Windows.Forms.ComboBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxKekkeiGenkai = new System.Windows.Forms.GroupBox();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChakra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAldeia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKekkeiGenkai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxKekkeiGenkai.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(93, 533);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 0;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 533);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 504);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(93, 504);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(156, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "Nome";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(12, 100);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.labelDataNascimento.TabIndex = 7;
            this.labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(12, 144);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 15);
            this.labelGenero.TabIndex = 9;
            this.labelGenero.Text = "Gênero";
            // 
            // radioButtonVivo
            // 
            this.radioButtonVivo.AutoSize = true;
            this.radioButtonVivo.Location = new System.Drawing.Point(6, 17);
            this.radioButtonVivo.Name = "radioButtonVivo";
            this.radioButtonVivo.Size = new System.Drawing.Size(62, 19);
            this.radioButtonVivo.TabIndex = 10;
            this.radioButtonVivo.TabStop = true;
            this.radioButtonVivo.Text = "Vivo(a)";
            this.radioButtonVivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonMorto
            // 
            this.radioButtonMorto.AutoSize = true;
            this.radioButtonMorto.Location = new System.Drawing.Point(74, 18);
            this.radioButtonMorto.Name = "radioButtonMorto";
            this.radioButtonMorto.Size = new System.Drawing.Size(72, 19);
            this.radioButtonMorto.TabIndex = 11;
            this.radioButtonMorto.TabStop = true;
            this.radioButtonMorto.Text = "Morto(a)";
            this.radioButtonMorto.UseVisualStyleBackColor = true;
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Location = new System.Drawing.Point(12, 346);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(156, 23);
            this.comboBoxNivel.TabIndex = 13;
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Location = new System.Drawing.Point(12, 328);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(34, 15);
            this.labelNivel.TabIndex = 14;
            this.labelNivel.Text = "Nível";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnChakra,
            this.ColumnDataNascimento,
            this.ColumnGenero,
            this.ColumnStatus,
            this.ColumnNivel,
            this.ColumnCla,
            this.ColumnAldeia,
            this.ColumnKekkeiGenkai});
            this.dataGridView1.Location = new System.Drawing.Point(184, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 534);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // labelCla
            // 
            this.labelCla.AutoSize = true;
            this.labelCla.Location = new System.Drawing.Point(12, 372);
            this.labelCla.Name = "labelCla";
            this.labelCla.Size = new System.Drawing.Size(24, 15);
            this.labelCla.TabIndex = 16;
            this.labelCla.Text = "Clã";
            // 
            // maskedTextBoxDataNascimento
            // 
            this.maskedTextBoxDataNascimento.Location = new System.Drawing.Point(13, 118);
            this.maskedTextBoxDataNascimento.Mask = "00/00/0000";
            this.maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            this.maskedTextBoxDataNascimento.Size = new System.Drawing.Size(62, 23);
            this.maskedTextBoxDataNascimento.TabIndex = 17;
            this.maskedTextBoxDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxCla
            // 
            this.comboBoxCla.FormattingEnabled = true;
            this.comboBoxCla.Location = new System.Drawing.Point(12, 390);
            this.comboBoxCla.Name = "comboBoxCla";
            this.comboBoxCla.Size = new System.Drawing.Size(155, 23);
            this.comboBoxCla.TabIndex = 18;
            // 
            // labelAldeia
            // 
            this.labelAldeia.AutoSize = true;
            this.labelAldeia.Location = new System.Drawing.Point(12, 416);
            this.labelAldeia.Name = "labelAldeia";
            this.labelAldeia.Size = new System.Drawing.Size(40, 15);
            this.labelAldeia.TabIndex = 19;
            this.labelAldeia.Text = "Aldeia";
            // 
            // comboBoxAldeia
            // 
            this.comboBoxAldeia.FormattingEnabled = true;
            this.comboBoxAldeia.Location = new System.Drawing.Point(12, 434);
            this.comboBoxAldeia.Name = "comboBoxAldeia";
            this.comboBoxAldeia.Size = new System.Drawing.Size(156, 23);
            this.comboBoxAldeia.TabIndex = 20;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(0, 15);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonSim.TabIndex = 22;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(51, 15);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonNao.TabIndex = 23;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.AutoSize = true;
            this.checkBoxMasculino.Location = new System.Drawing.Point(13, 162);
            this.checkBoxMasculino.Name = "checkBoxMasculino";
            this.checkBoxMasculino.Size = new System.Drawing.Size(81, 19);
            this.checkBoxMasculino.TabIndex = 0;
            this.checkBoxMasculino.Text = "Masculino";
            this.checkBoxMasculino.UseVisualStyleBackColor = true;
            // 
            // checkBoxFeminino
            // 
            this.checkBoxFeminino.AutoSize = true;
            this.checkBoxFeminino.Location = new System.Drawing.Point(13, 187);
            this.checkBoxFeminino.Name = "checkBoxFeminino";
            this.checkBoxFeminino.Size = new System.Drawing.Size(76, 19);
            this.checkBoxFeminino.TabIndex = 24;
            this.checkBoxFeminino.Text = "Feminino";
            this.checkBoxFeminino.UseVisualStyleBackColor = true;
            // 
            // checkBoxNaoBinario
            // 
            this.checkBoxNaoBinario.AutoSize = true;
            this.checkBoxNaoBinario.Location = new System.Drawing.Point(13, 212);
            this.checkBoxNaoBinario.Name = "checkBoxNaoBinario";
            this.checkBoxNaoBinario.Size = new System.Drawing.Size(90, 19);
            this.checkBoxNaoBinario.TabIndex = 25;
            this.checkBoxNaoBinario.Text = "Não-Binário";
            this.checkBoxNaoBinario.UseVisualStyleBackColor = true;
            // 
            // checkBoxCisgenero
            // 
            this.checkBoxCisgenero.AutoSize = true;
            this.checkBoxCisgenero.Location = new System.Drawing.Point(12, 237);
            this.checkBoxCisgenero.Name = "checkBoxCisgenero";
            this.checkBoxCisgenero.Size = new System.Drawing.Size(79, 19);
            this.checkBoxCisgenero.TabIndex = 26;
            this.checkBoxCisgenero.Text = "Cisgênero";
            this.checkBoxCisgenero.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransgenero
            // 
            this.checkBoxTransgenero.AutoSize = true;
            this.checkBoxTransgenero.Location = new System.Drawing.Point(12, 262);
            this.checkBoxTransgenero.Name = "checkBoxTransgenero";
            this.checkBoxTransgenero.Size = new System.Drawing.Size(90, 19);
            this.checkBoxTransgenero.TabIndex = 27;
            this.checkBoxTransgenero.Text = "Transgênero";
            this.checkBoxTransgenero.UseVisualStyleBackColor = true;
            // 
            // labelElementoChakra
            // 
            this.labelElementoChakra.AutoSize = true;
            this.labelElementoChakra.Location = new System.Drawing.Point(12, 53);
            this.labelElementoChakra.Name = "labelElementoChakra";
            this.labelElementoChakra.Size = new System.Drawing.Size(97, 15);
            this.labelElementoChakra.TabIndex = 28;
            this.labelElementoChakra.Text = "Elemento Chakra";
            // 
            // comboBoxElementoChakra
            // 
            this.comboBoxElementoChakra.FormattingEnabled = true;
            this.comboBoxElementoChakra.Location = new System.Drawing.Point(12, 71);
            this.comboBoxElementoChakra.Name = "comboBoxElementoChakra";
            this.comboBoxElementoChakra.Size = new System.Drawing.Size(156, 23);
            this.comboBoxElementoChakra.TabIndex = 29;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioButtonVivo);
            this.groupBoxStatus.Controls.Add(this.radioButtonMorto);
            this.groupBoxStatus.Location = new System.Drawing.Point(12, 283);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(156, 42);
            this.groupBoxStatus.TabIndex = 30;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // groupBoxKekkeiGenkai
            // 
            this.groupBoxKekkeiGenkai.Controls.Add(this.radioButtonSim);
            this.groupBoxKekkeiGenkai.Controls.Add(this.radioButtonNao);
            this.groupBoxKekkeiGenkai.Location = new System.Drawing.Point(12, 463);
            this.groupBoxKekkeiGenkai.Name = "groupBoxKekkeiGenkai";
            this.groupBoxKekkeiGenkai.Size = new System.Drawing.Size(156, 34);
            this.groupBoxKekkeiGenkai.TabIndex = 31;
            this.groupBoxKekkeiGenkai.TabStop = false;
            this.groupBoxKekkeiGenkai.Text = "Kekkei Genkai";
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 150;
            // 
            // ColumnChakra
            // 
            this.ColumnChakra.HeaderText = "Chakra";
            this.ColumnChakra.Name = "ColumnChakra";
            this.ColumnChakra.ReadOnly = true;
            // 
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.HeaderText = "Data Nascimento";
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            this.ColumnDataNascimento.ReadOnly = true;
            // 
            // ColumnGenero
            // 
            this.ColumnGenero.HeaderText = "Gênero";
            this.ColumnGenero.Name = "ColumnGenero";
            this.ColumnGenero.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // ColumnNivel
            // 
            this.ColumnNivel.HeaderText = "Nível";
            this.ColumnNivel.Name = "ColumnNivel";
            this.ColumnNivel.ReadOnly = true;
            // 
            // ColumnCla
            // 
            this.ColumnCla.HeaderText = "Clã";
            this.ColumnCla.Name = "ColumnCla";
            this.ColumnCla.ReadOnly = true;
            // 
            // ColumnAldeia
            // 
            this.ColumnAldeia.HeaderText = "Aldeia";
            this.ColumnAldeia.Name = "ColumnAldeia";
            this.ColumnAldeia.ReadOnly = true;
            // 
            // ColumnKekkeiGenkai
            // 
            this.ColumnKekkeiGenkai.HeaderText = "Kekkei Genkai";
            this.ColumnKekkeiGenkai.Name = "ColumnKekkeiGenkai";
            this.ColumnKekkeiGenkai.ReadOnly = true;
            // 
            // NinjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 566);
            this.Controls.Add(this.groupBoxKekkeiGenkai);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.comboBoxElementoChakra);
            this.Controls.Add(this.labelElementoChakra);
            this.Controls.Add(this.checkBoxTransgenero);
            this.Controls.Add(this.checkBoxCisgenero);
            this.Controls.Add(this.checkBoxNaoBinario);
            this.Controls.Add(this.checkBoxFeminino);
            this.Controls.Add(this.checkBoxMasculino);
            this.Controls.Add(this.comboBoxAldeia);
            this.Controls.Add(this.labelAldeia);
            this.Controls.Add(this.comboBoxCla);
            this.Controls.Add(this.maskedTextBoxDataNascimento);
            this.Controls.Add(this.labelCla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNivel);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Name = "NinjaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NinjaForm";
            this.Load += new System.EventHandler(this.NinjaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxKekkeiGenkai.ResumeLayout(false);
            this.groupBoxKekkeiGenkai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelDataNascimento;
        private Label labelGenero;
        private RadioButton radioButtonVivo;
        private RadioButton radioButtonMorto;
        private ComboBox comboBoxNivel;
        private Label labelNivel;
        private DataGridView dataGridView1;
        private Label labelCla;
        private MaskedTextBox maskedTextBoxDataNascimento;
        private ComboBox comboBoxCla;
        private Label labelAldeia;
        private ComboBox comboBoxAldeia;
        private RadioButton radioButtonSim;
        private RadioButton radioButtonNao;
        private CheckBox checkBoxMasculino;
        private CheckBox checkBoxFeminino;
        private CheckBox checkBoxNaoBinario;
        private CheckBox checkBoxCisgenero;
        private CheckBox checkBoxTransgenero;
        private Label labelElementoChakra;
        private ComboBox comboBoxElementoChakra;
        private GroupBox groupBoxStatus;
        private GroupBox groupBoxKekkeiGenkai;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnChakra;
        private DataGridViewTextBoxColumn ColumnDataNascimento;
        private DataGridViewTextBoxColumn ColumnGenero;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnNivel;
        private DataGridViewTextBoxColumn ColumnCla;
        private DataGridViewTextBoxColumn ColumnAldeia;
        private DataGridViewTextBoxColumn ColumnKekkeiGenkai;
    }
}