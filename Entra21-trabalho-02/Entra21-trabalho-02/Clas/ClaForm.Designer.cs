namespace Entra21_trabalho_02.Clas
{
    partial class ClaForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelLider = new System.Windows.Forms.Label();
            this.comboBoxLider = new System.Windows.Forms.ComboBox();
            this.labelKekkeiGenkai = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKekkeiGenkai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataFormacaoDoCla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDataFormacaoDoCLa = new System.Windows.Forms.DateTimePicker();
            this.labelDataFormacaoCla = new System.Windows.Forms.Label();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Líder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 187);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(93, 216);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(93, 187);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 216);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 4;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelLider
            // 
            this.labelLider.AutoSize = true;
            this.labelLider.Location = new System.Drawing.Point(12, 53);
            this.labelLider.Name = "labelLider";
            this.labelLider.Size = new System.Drawing.Size(33, 15);
            this.labelLider.TabIndex = 6;
            this.labelLider.Text = "Líder";
            // 
            // comboBoxLider
            // 
            this.comboBoxLider.FormattingEnabled = true;
            this.comboBoxLider.Location = new System.Drawing.Point(12, 71);
            this.comboBoxLider.Name = "comboBoxLider";
            this.comboBoxLider.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLider.TabIndex = 7;
            // 
            // labelKekkeiGenkai
            // 
            this.labelKekkeiGenkai.AutoSize = true;
            this.labelKekkeiGenkai.Location = new System.Drawing.Point(12, 97);
            this.labelKekkeiGenkai.Name = "labelKekkeiGenkai";
            this.labelKekkeiGenkai.Size = new System.Drawing.Size(80, 15);
            this.labelKekkeiGenkai.TabIndex = 8;
            this.labelKekkeiGenkai.Text = "Kekkei Genkai";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnLider,
            this.ColumnKekkeiGenkai,
            this.ColumnDataFormacaoDoCla});
            this.dataGridView1.Location = new System.Drawing.Point(202, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(586, 237);
            this.dataGridView1.TabIndex = 9;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnLider
            // 
            this.ColumnLider.HeaderText = "Líder";
            this.ColumnLider.Name = "ColumnLider";
            this.ColumnLider.ReadOnly = true;
            // 
            // ColumnKekkeiGenkai
            // 
            this.ColumnKekkeiGenkai.HeaderText = "Kekkei Genkai";
            this.ColumnKekkeiGenkai.Name = "ColumnKekkeiGenkai";
            this.ColumnKekkeiGenkai.ReadOnly = true;
            // 
            // ColumnDataFormacaoDoCla
            // 
            this.ColumnDataFormacaoDoCla.HeaderText = "Data Formação do Clã";
            this.ColumnDataFormacaoDoCla.Name = "ColumnDataFormacaoDoCla";
            this.ColumnDataFormacaoDoCla.ReadOnly = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(12, 115);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonSim.TabIndex = 10;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(65, 115);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonNao.TabIndex = 11;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataFormacaoDoCLa
            // 
            this.dateTimePickerDataFormacaoDoCLa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFormacaoDoCLa.Location = new System.Drawing.Point(12, 158);
            this.dateTimePickerDataFormacaoDoCLa.Name = "dateTimePickerDataFormacaoDoCLa";
            this.dateTimePickerDataFormacaoDoCLa.Size = new System.Drawing.Size(156, 23);
            this.dateTimePickerDataFormacaoDoCLa.TabIndex = 12;
            // 
            // labelDataFormacaoCla
            // 
            this.labelDataFormacaoCla.AutoSize = true;
            this.labelDataFormacaoCla.Location = new System.Drawing.Point(12, 137);
            this.labelDataFormacaoCla.Name = "labelDataFormacaoCla";
            this.labelDataFormacaoCla.Size = new System.Drawing.Size(124, 15);
            this.labelDataFormacaoCla.TabIndex = 13;
            this.labelDataFormacaoCla.Text = "Data Formação do Clã";
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "ColumnId";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "ColumnNome";
            this.Nome.Name = "Nome";
            // 
            // Líder
            // 
            this.Líder.HeaderText = "ColumnLider";
            this.Líder.Name = "Líder";
            // 
            // ClaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.labelDataFormacaoCla);
            this.Controls.Add(this.dateTimePickerDataFormacaoDoCLa);
            this.Controls.Add(this.radioButtonNao);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelKekkeiGenkai);
            this.Controls.Add(this.comboBoxLider);
            this.Controls.Add(this.labelLider);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelNome);
            this.Name = "ClaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private Button buttonSalvar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private Button buttonEditar;
        private TextBox textBoxNome;
        private Label labelLider;
        private ComboBox comboBoxLider;
        private Label labelKekkeiGenkai;
        private DataGridView dataGridView1;
        private RadioButton radioButtonSim;
        private RadioButton radioButtonNao;
        private DateTimePicker dateTimePickerDataFormacaoDoCLa;
        private Label labelDataFormacaoCla;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Líder;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnLider;
        private DataGridViewTextBoxColumn ColumnKekkeiGenkai;
        private DataGridViewTextBoxColumn ColumnDataFormacaoDoCla;
    }
}