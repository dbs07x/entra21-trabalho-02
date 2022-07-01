namespace Entra21_trabalho_02.Aldeias
{
    partial class AldeiaForm
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelLider = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.comboBoxLider = new System.Windows.Forms.ComboBox();
            this.dataGridViewAldeia = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAldeia)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(193, 556);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(135, 64);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(344, 13);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(425, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 42);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(12, 86);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(28, 15);
            this.labelPais.TabIndex = 4;
            this.labelPais.Text = "País";
            // 
            // labelLider
            // 
            this.labelLider.AutoSize = true;
            this.labelLider.Location = new System.Drawing.Point(12, 130);
            this.labelLider.Name = "labelLider";
            this.labelLider.Size = new System.Drawing.Size(33, 15);
            this.labelLider.TabIndex = 5;
            this.labelLider.Text = "Lider";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 60);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(316, 23);
            this.textBoxNome.TabIndex = 6;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(12, 104);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(316, 23);
            this.textBoxPais.TabIndex = 7;
            // 
            // comboBoxLider
            // 
            this.comboBoxLider.FormattingEnabled = true;
            this.comboBoxLider.Location = new System.Drawing.Point(12, 148);
            this.comboBoxLider.Name = "comboBoxLider";
            this.comboBoxLider.Size = new System.Drawing.Size(316, 23);
            this.comboBoxLider.TabIndex = 8;
            // 
            // dataGridViewAldeia
            // 
            this.dataGridViewAldeia.AllowUserToAddRows = false;
            this.dataGridViewAldeia.AllowUserToDeleteRows = false;
            this.dataGridViewAldeia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAldeia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnPais,
            this.ColumnLider});
            this.dataGridViewAldeia.Location = new System.Drawing.Point(344, 42);
            this.dataGridViewAldeia.Name = "dataGridViewAldeia";
            this.dataGridViewAldeia.ReadOnly = true;
            this.dataGridViewAldeia.RowHeadersWidth = 51;
            this.dataGridViewAldeia.RowTemplate.Height = 25;
            this.dataGridViewAldeia.Size = new System.Drawing.Size(549, 578);
            this.dataGridViewAldeia.TabIndex = 9;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 125;
            // 
            // ColumnPais
            // 
            this.ColumnPais.HeaderText = "País";
            this.ColumnPais.MinimumWidth = 6;
            this.ColumnPais.Name = "ColumnPais";
            this.ColumnPais.ReadOnly = true;
            this.ColumnPais.Width = 125;
            // 
            // ColumnLider
            // 
            this.ColumnLider.HeaderText = "Lider";
            this.ColumnLider.MinimumWidth = 6;
            this.ColumnLider.Name = "ColumnLider";
            this.ColumnLider.ReadOnly = true;
            this.ColumnLider.Width = 125;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(51, 556);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(136, 64);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // AldeiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 636);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewAldeia);
            this.Controls.Add(this.comboBoxLider);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelLider);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "AldeiaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aldeia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAldeia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelNome;
        private Label labelPais;
        private Label labelLider;
        private TextBox textBoxNome;
        private TextBox textBoxPais;
        private ComboBox comboBoxLider;
        private DataGridView dataGridViewAldeia;
        private Button buttonCancelar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnPais;
        private DataGridViewTextBoxColumn ColumnLider;
    }
}