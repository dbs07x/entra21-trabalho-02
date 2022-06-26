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
            this.labelNatureza.Location = new System.Drawing.Point(12, 18);
            this.labelNatureza.Name = "labelNatureza";
            this.labelNatureza.Size = new System.Drawing.Size(54, 15);
            this.labelNatureza.TabIndex = 0;
            this.labelNatureza.Text = "Natureza";
            // 
            // comboBoxNatureza
            // 
            this.comboBoxNatureza.FormattingEnabled = true;
            this.comboBoxNatureza.Items.AddRange(new object[] {
            "Aço",
            "Água",
            "Calor",
            "Chama",
            "Cristal",
            "Ebulição",
            "Escuro",
            "Espuma",
            "Explosão",
            "Fogo",
            "Fusão",
            "Gelo",
            "Lama",
            "Madeira",
            "Magnetismo",
            "Pó",
            "Raio",
            "Rápido",
            "Tempestade",
            "Terra",
            "Tufão",
            "Vento",
            "Yang",
            "Yin"});
            this.comboBoxNatureza.Location = new System.Drawing.Point(12, 36);
            this.comboBoxNatureza.Name = "comboBoxNatureza";
            this.comboBoxNatureza.Size = new System.Drawing.Size(160, 23);
            this.comboBoxNatureza.TabIndex = 1;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Besta de Cauda",
            "Normal",
            "Sábio"});
            this.comboBoxTipo.Location = new System.Drawing.Point(12, 92);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(160, 23);
            this.comboBoxTipo.TabIndex = 3;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(12, 74);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(30, 15);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Tipo";
            // 
            // labelPrimario
            // 
            this.labelPrimario.AutoSize = true;
            this.labelPrimario.Location = new System.Drawing.Point(12, 139);
            this.labelPrimario.Name = "labelPrimario";
            this.labelPrimario.Size = new System.Drawing.Size(140, 15);
            this.labelPrimario.TabIndex = 4;
            this.labelPrimario.Text = "É um elemento primário?";
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Location = new System.Drawing.Point(12, 169);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonSim.TabIndex = 5;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(76, 169);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonNao.TabIndex = 6;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(12, 218);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(86, 35);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(113, 218);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(86, 35);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(12, 268);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(86, 35);
            this.buttonApagar.TabIndex = 9;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(113, 268);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 35);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(236, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(384, 285);
            this.dataGridView1.TabIndex = 11;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnNatureza
            // 
            this.ColumnNatureza.HeaderText = "Natureza";
            this.ColumnNatureza.Name = "ColumnNatureza";
            this.ColumnNatureza.ReadOnly = true;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            // 
            // ColumnElementoPrimario
            // 
            this.ColumnElementoPrimario.HeaderText = "Elemento primário?";
            this.ColumnElementoPrimario.Name = "ColumnElementoPrimario";
            this.ColumnElementoPrimario.ReadOnly = true;
            this.ColumnElementoPrimario.Width = 140;
            // 
            // ChakraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 315);
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
            this.Name = "ChakraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chakra";
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