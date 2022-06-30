namespace Entra21_trabalho_02.Chakras
{
    partial class ChakraForm
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
            this.labelNatureza = new System.Windows.Forms.Label();
            this.comboBoxNatureza = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelPrimario = new System.Windows.Forms.Label();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNatureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnElementoPrimario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNatureza
            // 
            this.labelNatureza.AutoSize = true;
            this.labelNatureza.Location = new System.Drawing.Point(14, 24);
            this.labelNatureza.Name = "labelNatureza";
            this.labelNatureza.Size = new System.Drawing.Size(69, 20);
            this.labelNatureza.TabIndex = 0;
            this.labelNatureza.Text = "Natureza";
            // 
            // comboBoxNatureza
            // 
            this.comboBoxNatureza.FormattingEnabled = true;
            this.comboBoxNatureza.Location = new System.Drawing.Point(14, 48);
            this.comboBoxNatureza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxNatureza.Name = "comboBoxNatureza";
            this.comboBoxNatureza.Size = new System.Drawing.Size(182, 28);
            this.comboBoxNatureza.TabIndex = 1;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(14, 123);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(182, 28);
            this.comboBoxTipo.TabIndex = 3;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(14, 99);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(39, 20);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Tipo";
            // 
            // labelPrimario
            // 
            this.labelPrimario.AutoSize = true;
            this.labelPrimario.Location = new System.Drawing.Point(14, 185);
            this.labelPrimario.Name = "labelPrimario";
            this.labelPrimario.Size = new System.Drawing.Size(177, 20);
            this.labelPrimario.TabIndex = 4;
            this.labelPrimario.Text = "É um elemento primário?";
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Location = new System.Drawing.Point(14, 225);
            this.radioButtonSim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(55, 24);
            this.radioButtonSim.TabIndex = 5;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(87, 225);
            this.radioButtonNao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(58, 24);
            this.radioButtonNao.TabIndex = 6;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(14, 291);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(98, 47);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(129, 291);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(98, 47);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(14, 357);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(98, 47);
            this.buttonApagar.TabIndex = 9;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(129, 357);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(98, 47);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNatureza,
            this.ColumnTipo,
            this.ColumnElementoPrimario});
            this.dataGridView1.Location = new System.Drawing.Point(270, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(439, 380);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnNatureza
            // 
            this.ColumnNatureza.HeaderText = "Natureza";
            this.ColumnNatureza.MinimumWidth = 6;
            this.ColumnNatureza.Name = "ColumnNatureza";
            this.ColumnNatureza.ReadOnly = true;
            this.ColumnNatureza.Width = 125;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.MinimumWidth = 6;
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            this.ColumnTipo.Width = 125;
            // 
            // ColumnElementoPrimario
            // 
            this.ColumnElementoPrimario.HeaderText = "Elemento primário?";
            this.ColumnElementoPrimario.MinimumWidth = 6;
            this.ColumnElementoPrimario.Name = "ColumnElementoPrimario";
            this.ColumnElementoPrimario.ReadOnly = true;
            this.ColumnElementoPrimario.Width = 140;
            // 
            // ChakraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.radioButtonNao);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.labelPrimario);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.comboBoxNatureza);
            this.Controls.Add(this.labelNatureza);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChakraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chakra";
            this.Load += new System.EventHandler(this.ChakraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNatureza;
        private ComboBox comboBoxNatureza;
        private ComboBox comboBoxTipo;
        private Label labelTipo;
        private Label labelPrimario;
        private RadioButton radioButtonSim;
        private RadioButton radioButtonNao;
        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNatureza;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnElementoPrimario;
    }
}