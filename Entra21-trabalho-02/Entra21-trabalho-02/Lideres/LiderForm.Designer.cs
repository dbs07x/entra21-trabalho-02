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
            this.dateTimePickerFimLideranca = new System.Windows.Forms.DateTimePicker();
            this.radioButtonVivo = new System.Windows.Forms.RadioButton();
            this.radioButtonMorto = new System.Windows.Forms.RadioButton();
            this.checkBoxMasculino = new System.Windows.Forms.CheckBox();
            this.checkBoxCisgenero = new System.Windows.Forms.CheckBox();
            this.checkBoxFeminino = new System.Windows.Forms.CheckBox();
            this.checkBoxTransgenero = new System.Windows.Forms.CheckBox();
            this.checkBoxNaoBinario = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 578);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(821, 554);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(120, 71);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(93, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(639, 47);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(639, 91);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(37, 15);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(639, 135);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(36, 15);
            this.labelIdade.TabIndex = 6;
            this.labelIdade.Text = "Idade";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(639, 192);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 15);
            this.labelGenero.TabIndex = 7;
            this.labelGenero.Text = "Genero";
            // 
            // labelInicioLideranca
            // 
            this.labelInicioLideranca.AutoSize = true;
            this.labelInicioLideranca.Location = new System.Drawing.Point(639, 294);
            this.labelInicioLideranca.Name = "labelInicioLideranca";
            this.labelInicioLideranca.Size = new System.Drawing.Size(106, 15);
            this.labelInicioLideranca.TabIndex = 8;
            this.labelInicioLideranca.Text = "Início da Liderança";
            // 
            // labelFimLideranca
            // 
            this.labelFimLideranca.AutoSize = true;
            this.labelFimLideranca.Location = new System.Drawing.Point(639, 338);
            this.labelFimLideranca.Name = "labelFimLideranca";
            this.labelFimLideranca.Size = new System.Drawing.Size(97, 15);
            this.labelFimLideranca.TabIndex = 9;
            this.labelFimLideranca.Text = "Fim da Liderança";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(639, 393);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 15);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status";
            // 
            // labelElementoChakra
            // 
            this.labelElementoChakra.AutoSize = true;
            this.labelElementoChakra.Location = new System.Drawing.Point(639, 452);
            this.labelElementoChakra.Name = "labelElementoChakra";
            this.labelElementoChakra.Size = new System.Drawing.Size(97, 15);
            this.labelElementoChakra.TabIndex = 11;
            this.labelElementoChakra.Text = "Elemento Chakra";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(640, 66);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(302, 23);
            this.textBoxNome.TabIndex = 12;
            // 
            // comboBoxTitulo
            // 
            this.comboBoxTitulo.FormattingEnabled = true;
            this.comboBoxTitulo.Items.AddRange(new object[] {
            "Hokage",
            "Kazekage",
            "Raikage",
            "Tsuchikage",
            "Mizukage",
            "Líder"});
            this.comboBoxTitulo.Location = new System.Drawing.Point(640, 110);
            this.comboBoxTitulo.Name = "comboBoxTitulo";
            this.comboBoxTitulo.Size = new System.Drawing.Size(302, 23);
            this.comboBoxTitulo.TabIndex = 13;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(640, 154);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(301, 23);
            this.textBoxIdade.TabIndex = 14;
            // 
            // comboBoxChakra
            // 
            this.comboBoxChakra.FormattingEnabled = true;
            this.comboBoxChakra.Items.AddRange(new object[] {
            "Fogo",
            "Vento",
            "Relâmpago",
            "Terra",
            "Água"});
            this.comboBoxChakra.Location = new System.Drawing.Point(639, 470);
            this.comboBoxChakra.Name = "comboBoxChakra";
            this.comboBoxChakra.Size = new System.Drawing.Size(302, 23);
            this.comboBoxChakra.TabIndex = 15;
            // 
            // dateTimePickerInicioLideranca
            // 
            this.dateTimePickerInicioLideranca.Location = new System.Drawing.Point(639, 312);
            this.dateTimePickerInicioLideranca.Name = "dateTimePickerInicioLideranca";
            this.dateTimePickerInicioLideranca.Size = new System.Drawing.Size(302, 23);
            this.dateTimePickerInicioLideranca.TabIndex = 16;
            // 
            // dateTimePickerFimLideranca
            // 
            this.dateTimePickerFimLideranca.Location = new System.Drawing.Point(639, 356);
            this.dateTimePickerFimLideranca.Name = "dateTimePickerFimLideranca";
            this.dateTimePickerFimLideranca.Size = new System.Drawing.Size(302, 23);
            this.dateTimePickerFimLideranca.TabIndex = 17;
            // 
            // radioButtonVivo
            // 
            this.radioButtonVivo.AutoSize = true;
            this.radioButtonVivo.Location = new System.Drawing.Point(639, 420);
            this.radioButtonVivo.Name = "radioButtonVivo";
            this.radioButtonVivo.Size = new System.Drawing.Size(48, 19);
            this.radioButtonVivo.TabIndex = 18;
            this.radioButtonVivo.TabStop = true;
            this.radioButtonVivo.Text = "Vivo";
            this.radioButtonVivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonMorto
            // 
            this.radioButtonMorto.AutoSize = true;
            this.radioButtonMorto.Location = new System.Drawing.Point(821, 420);
            this.radioButtonMorto.Name = "radioButtonMorto";
            this.radioButtonMorto.Size = new System.Drawing.Size(58, 19);
            this.radioButtonMorto.TabIndex = 19;
            this.radioButtonMorto.TabStop = true;
            this.radioButtonMorto.Text = "Morto";
            this.radioButtonMorto.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasculino
            // 
            this.checkBoxMasculino.AutoSize = true;
            this.checkBoxMasculino.Location = new System.Drawing.Point(639, 219);
            this.checkBoxMasculino.Name = "checkBoxMasculino";
            this.checkBoxMasculino.Size = new System.Drawing.Size(81, 19);
            this.checkBoxMasculino.TabIndex = 20;
            this.checkBoxMasculino.Text = "Masculino";
            this.checkBoxMasculino.UseVisualStyleBackColor = true;
            // 
            // checkBoxCisgenero
            // 
            this.checkBoxCisgenero.AutoSize = true;
            this.checkBoxCisgenero.Location = new System.Drawing.Point(640, 253);
            this.checkBoxCisgenero.Name = "checkBoxCisgenero";
            this.checkBoxCisgenero.Size = new System.Drawing.Size(79, 19);
            this.checkBoxCisgenero.TabIndex = 21;
            this.checkBoxCisgenero.Text = "Cisgênero";
            this.checkBoxCisgenero.UseVisualStyleBackColor = true;
            // 
            // checkBoxFeminino
            // 
            this.checkBoxFeminino.AutoSize = true;
            this.checkBoxFeminino.Location = new System.Drawing.Point(753, 219);
            this.checkBoxFeminino.Name = "checkBoxFeminino";
            this.checkBoxFeminino.Size = new System.Drawing.Size(76, 19);
            this.checkBoxFeminino.TabIndex = 22;
            this.checkBoxFeminino.Text = "Feminino";
            this.checkBoxFeminino.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransgenero
            // 
            this.checkBoxTransgenero.AutoSize = true;
            this.checkBoxTransgenero.Location = new System.Drawing.Point(753, 253);
            this.checkBoxTransgenero.Name = "checkBoxTransgenero";
            this.checkBoxTransgenero.Size = new System.Drawing.Size(90, 19);
            this.checkBoxTransgenero.TabIndex = 23;
            this.checkBoxTransgenero.Text = "Transgênero";
            this.checkBoxTransgenero.UseVisualStyleBackColor = true;
            // 
            // checkBoxNaoBinario
            // 
            this.checkBoxNaoBinario.AutoSize = true;
            this.checkBoxNaoBinario.Location = new System.Drawing.Point(859, 219);
            this.checkBoxNaoBinario.Name = "checkBoxNaoBinario";
            this.checkBoxNaoBinario.Size = new System.Drawing.Size(90, 19);
            this.checkBoxNaoBinario.TabIndex = 24;
            this.checkBoxNaoBinario.Text = "Não-Binario";
            this.checkBoxNaoBinario.UseVisualStyleBackColor = true;
            // 
            // LiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 637);
            this.Controls.Add(this.checkBoxNaoBinario);
            this.Controls.Add(this.checkBoxTransgenero);
            this.Controls.Add(this.checkBoxFeminino);
            this.Controls.Add(this.checkBoxCisgenero);
            this.Controls.Add(this.checkBoxMasculino);
            this.Controls.Add(this.radioButtonMorto);
            this.Controls.Add(this.radioButtonVivo);
            this.Controls.Add(this.dateTimePickerFimLideranca);
            this.Controls.Add(this.dateTimePickerInicioLideranca);
            this.Controls.Add(this.comboBoxChakra);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.comboBoxTitulo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelElementoChakra);
            this.Controls.Add(this.labelStatus);
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
            this.Text = "Cadastro do Lider";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DateTimePicker dateTimePickerFimLideranca;
        private RadioButton radioButtonVivo;
        private RadioButton radioButtonMorto;
        private CheckBox checkBoxMasculino;
        private CheckBox checkBoxCisgenero;
        private CheckBox checkBoxFeminino;
        private CheckBox checkBoxTransgenero;
        private CheckBox checkBoxNaoBinario;
    }
}