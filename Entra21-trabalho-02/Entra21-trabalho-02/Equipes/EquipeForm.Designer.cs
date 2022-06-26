namespace Entra21_trabalho_02.Equipes
{
    partial class EquipeForm
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
            this.labelNomeEquipe = new System.Windows.Forms.Label();
            this.textBoxNomeEquipe = new System.Windows.Forms.TextBox();
            this.labelLider = new System.Windows.Forms.Label();
            this.comboBoxLider = new System.Windows.Forms.ComboBox();
            this.comboBoxMembro1 = new System.Windows.Forms.ComboBox();
            this.labelMembro1 = new System.Windows.Forms.Label();
            this.comboBoxMembro3 = new System.Windows.Forms.ComboBox();
            this.labelMembro3 = new System.Windows.Forms.Label();
            this.comboBoxMembro2 = new System.Windows.Forms.ComboBox();
            this.labelMembro2 = new System.Windows.Forms.Label();
            this.labelDataFormacao = new System.Windows.Forms.Label();
            this.labelDataProximaMissao = new System.Windows.Forms.Label();
            this.dateTimePickerDataFormacao = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxDataProximaMissao = new System.Windows.Forms.MaskedTextBox();
            this.labelSituacao = new System.Windows.Forms.Label();
            this.checkBoxEmMissao = new System.Windows.Forms.CheckBox();
            this.checkBoxNaAldeia = new System.Windows.Forms.CheckBox();
            this.checkBoxTemporariamenteInativa = new System.Windows.Forms.CheckBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMembro1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMembro2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMembro3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataFormacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataProximaMissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNomeEquipe,
            this.ColumnLider,
            this.ColumnMembro1,
            this.ColumnMembro2,
            this.ColumnMembro3,
            this.ColumnDataFormacao,
            this.ColumnDataProximaMissao,
            this.ColumnSituacao});
            this.dataGridView1.Location = new System.Drawing.Point(339, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(839, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelNomeEquipe
            // 
            this.labelNomeEquipe.AutoSize = true;
            this.labelNomeEquipe.Location = new System.Drawing.Point(12, 12);
            this.labelNomeEquipe.Name = "labelNomeEquipe";
            this.labelNomeEquipe.Size = new System.Drawing.Size(95, 15);
            this.labelNomeEquipe.TabIndex = 1;
            this.labelNomeEquipe.Text = "Nome da equipe";
            // 
            // textBoxNomeEquipe
            // 
            this.textBoxNomeEquipe.Location = new System.Drawing.Point(12, 30);
            this.textBoxNomeEquipe.Name = "textBoxNomeEquipe";
            this.textBoxNomeEquipe.Size = new System.Drawing.Size(303, 23);
            this.textBoxNomeEquipe.TabIndex = 2;
            // 
            // labelLider
            // 
            this.labelLider.AutoSize = true;
            this.labelLider.Location = new System.Drawing.Point(12, 72);
            this.labelLider.Name = "labelLider";
            this.labelLider.Size = new System.Drawing.Size(33, 15);
            this.labelLider.TabIndex = 3;
            this.labelLider.Text = "Lider";
            // 
            // comboBoxLider
            // 
            this.comboBoxLider.FormattingEnabled = true;
            this.comboBoxLider.Location = new System.Drawing.Point(12, 90);
            this.comboBoxLider.Name = "comboBoxLider";
            this.comboBoxLider.Size = new System.Drawing.Size(137, 23);
            this.comboBoxLider.TabIndex = 4;
            // 
            // comboBoxMembro1
            // 
            this.comboBoxMembro1.FormattingEnabled = true;
            this.comboBoxMembro1.Location = new System.Drawing.Point(178, 90);
            this.comboBoxMembro1.Name = "comboBoxMembro1";
            this.comboBoxMembro1.Size = new System.Drawing.Size(137, 23);
            this.comboBoxMembro1.TabIndex = 6;
            // 
            // labelMembro1
            // 
            this.labelMembro1.AutoSize = true;
            this.labelMembro1.Location = new System.Drawing.Point(178, 72);
            this.labelMembro1.Name = "labelMembro1";
            this.labelMembro1.Size = new System.Drawing.Size(62, 15);
            this.labelMembro1.TabIndex = 5;
            this.labelMembro1.Text = "Membro 1";
            // 
            // comboBoxMembro3
            // 
            this.comboBoxMembro3.FormattingEnabled = true;
            this.comboBoxMembro3.Location = new System.Drawing.Point(178, 143);
            this.comboBoxMembro3.Name = "comboBoxMembro3";
            this.comboBoxMembro3.Size = new System.Drawing.Size(137, 23);
            this.comboBoxMembro3.TabIndex = 10;
            // 
            // labelMembro3
            // 
            this.labelMembro3.AutoSize = true;
            this.labelMembro3.Location = new System.Drawing.Point(178, 125);
            this.labelMembro3.Name = "labelMembro3";
            this.labelMembro3.Size = new System.Drawing.Size(62, 15);
            this.labelMembro3.TabIndex = 9;
            this.labelMembro3.Text = "Membro 3";
            // 
            // comboBoxMembro2
            // 
            this.comboBoxMembro2.FormattingEnabled = true;
            this.comboBoxMembro2.Location = new System.Drawing.Point(12, 143);
            this.comboBoxMembro2.Name = "comboBoxMembro2";
            this.comboBoxMembro2.Size = new System.Drawing.Size(137, 23);
            this.comboBoxMembro2.TabIndex = 8;
            // 
            // labelMembro2
            // 
            this.labelMembro2.AutoSize = true;
            this.labelMembro2.Location = new System.Drawing.Point(12, 125);
            this.labelMembro2.Name = "labelMembro2";
            this.labelMembro2.Size = new System.Drawing.Size(62, 15);
            this.labelMembro2.TabIndex = 7;
            this.labelMembro2.Text = "Membro 2";
            // 
            // labelDataFormacao
            // 
            this.labelDataFormacao.AutoSize = true;
            this.labelDataFormacao.Location = new System.Drawing.Point(12, 193);
            this.labelDataFormacao.Name = "labelDataFormacao";
            this.labelDataFormacao.Size = new System.Drawing.Size(101, 15);
            this.labelDataFormacao.TabIndex = 11;
            this.labelDataFormacao.Text = "Data de formação";
            // 
            // labelDataProximaMissao
            // 
            this.labelDataProximaMissao.AutoSize = true;
            this.labelDataProximaMissao.Location = new System.Drawing.Point(178, 193);
            this.labelDataProximaMissao.Name = "labelDataProximaMissao";
            this.labelDataProximaMissao.Size = new System.Drawing.Size(118, 15);
            this.labelDataProximaMissao.TabIndex = 12;
            this.labelDataProximaMissao.Text = "Data próxima missão";
            // 
            // dateTimePickerDataFormacao
            // 
            this.dateTimePickerDataFormacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFormacao.Location = new System.Drawing.Point(12, 211);
            this.dateTimePickerDataFormacao.Name = "dateTimePickerDataFormacao";
            this.dateTimePickerDataFormacao.Size = new System.Drawing.Size(137, 23);
            this.dateTimePickerDataFormacao.TabIndex = 13;
            // 
            // maskedTextBoxDataProximaMissao
            // 
            this.maskedTextBoxDataProximaMissao.Location = new System.Drawing.Point(178, 211);
            this.maskedTextBoxDataProximaMissao.Mask = "00/00/0000";
            this.maskedTextBoxDataProximaMissao.Name = "maskedTextBoxDataProximaMissao";
            this.maskedTextBoxDataProximaMissao.Size = new System.Drawing.Size(62, 23);
            this.maskedTextBoxDataProximaMissao.TabIndex = 14;
            this.maskedTextBoxDataProximaMissao.ValidatingType = typeof(System.DateTime);
            // 
            // labelSituacao
            // 
            this.labelSituacao.AutoSize = true;
            this.labelSituacao.Location = new System.Drawing.Point(12, 258);
            this.labelSituacao.Name = "labelSituacao";
            this.labelSituacao.Size = new System.Drawing.Size(52, 15);
            this.labelSituacao.TabIndex = 15;
            this.labelSituacao.Text = "Situação";
            // 
            // checkBoxEmMissao
            // 
            this.checkBoxEmMissao.AutoSize = true;
            this.checkBoxEmMissao.Location = new System.Drawing.Point(12, 285);
            this.checkBoxEmMissao.Name = "checkBoxEmMissao";
            this.checkBoxEmMissao.Size = new System.Drawing.Size(83, 19);
            this.checkBoxEmMissao.TabIndex = 16;
            this.checkBoxEmMissao.Text = "Em missão";
            this.checkBoxEmMissao.UseVisualStyleBackColor = true;
            // 
            // checkBoxNaAldeia
            // 
            this.checkBoxNaAldeia.AutoSize = true;
            this.checkBoxNaAldeia.Location = new System.Drawing.Point(97, 285);
            this.checkBoxNaAldeia.Name = "checkBoxNaAldeia";
            this.checkBoxNaAldeia.Size = new System.Drawing.Size(77, 19);
            this.checkBoxNaAldeia.TabIndex = 17;
            this.checkBoxNaAldeia.Text = "Na Aldeia";
            this.checkBoxNaAldeia.UseVisualStyleBackColor = true;
            // 
            // checkBoxTemporariamenteInativa
            // 
            this.checkBoxTemporariamenteInativa.AutoSize = true;
            this.checkBoxTemporariamenteInativa.Location = new System.Drawing.Point(176, 285);
            this.checkBoxTemporariamenteInativa.Name = "checkBoxTemporariamenteInativa";
            this.checkBoxTemporariamenteInativa.Size = new System.Drawing.Size(157, 19);
            this.checkBoxTemporariamenteInativa.TabIndex = 18;
            this.checkBoxTemporariamenteInativa.Text = "Temporariamente Inativa";
            this.checkBoxTemporariamenteInativa.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(12, 333);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(101, 40);
            this.buttonCadastrar.TabIndex = 19;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(139, 333);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(101, 40);
            this.buttonEditar.TabIndex = 20;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(139, 379);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(101, 40);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // Apagar
            // 
            this.Apagar.Location = new System.Drawing.Point(12, 379);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(101, 40);
            this.Apagar.TabIndex = 21;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = true;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnNomeEquipe
            // 
            this.ColumnNomeEquipe.HeaderText = "Nome";
            this.ColumnNomeEquipe.Name = "ColumnNomeEquipe";
            this.ColumnNomeEquipe.ReadOnly = true;
            // 
            // ColumnLider
            // 
            this.ColumnLider.HeaderText = "Líder";
            this.ColumnLider.Name = "ColumnLider";
            this.ColumnLider.ReadOnly = true;
            // 
            // ColumnMembro1
            // 
            this.ColumnMembro1.HeaderText = "Membro 1";
            this.ColumnMembro1.Name = "ColumnMembro1";
            this.ColumnMembro1.ReadOnly = true;
            // 
            // ColumnMembro2
            // 
            this.ColumnMembro2.HeaderText = "Membro2";
            this.ColumnMembro2.Name = "ColumnMembro2";
            this.ColumnMembro2.ReadOnly = true;
            // 
            // ColumnMembro3
            // 
            this.ColumnMembro3.HeaderText = "Membro 3";
            this.ColumnMembro3.Name = "ColumnMembro3";
            this.ColumnMembro3.ReadOnly = true;
            // 
            // ColumnDataFormacao
            // 
            this.ColumnDataFormacao.HeaderText = "Data formação";
            this.ColumnDataFormacao.Name = "ColumnDataFormacao";
            this.ColumnDataFormacao.ReadOnly = true;
            // 
            // ColumnDataProximaMissao
            // 
            this.ColumnDataProximaMissao.HeaderText = "Data próxima missão";
            this.ColumnDataProximaMissao.Name = "ColumnDataProximaMissao";
            this.ColumnDataProximaMissao.ReadOnly = true;
            // 
            // ColumnSituacao
            // 
            this.ColumnSituacao.HeaderText = "Situação";
            this.ColumnSituacao.Name = "ColumnSituacao";
            this.ColumnSituacao.ReadOnly = true;
            // 
            // EquipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 425);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.checkBoxTemporariamenteInativa);
            this.Controls.Add(this.checkBoxNaAldeia);
            this.Controls.Add(this.checkBoxEmMissao);
            this.Controls.Add(this.labelSituacao);
            this.Controls.Add(this.maskedTextBoxDataProximaMissao);
            this.Controls.Add(this.dateTimePickerDataFormacao);
            this.Controls.Add(this.labelDataProximaMissao);
            this.Controls.Add(this.labelDataFormacao);
            this.Controls.Add(this.comboBoxMembro3);
            this.Controls.Add(this.labelMembro3);
            this.Controls.Add(this.comboBoxMembro2);
            this.Controls.Add(this.labelMembro2);
            this.Controls.Add(this.comboBoxMembro1);
            this.Controls.Add(this.labelMembro1);
            this.Controls.Add(this.comboBoxLider);
            this.Controls.Add(this.labelLider);
            this.Controls.Add(this.textBoxNomeEquipe);
            this.Controls.Add(this.labelNomeEquipe);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EquipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelNomeEquipe;
        private TextBox textBoxNomeEquipe;
        private Label labelLider;
        private ComboBox comboBoxLider;
        private ComboBox comboBoxMembro1;
        private Label labelMembro1;
        private ComboBox comboBoxMembro3;
        private Label labelMembro3;
        private ComboBox comboBoxMembro2;
        private Label labelMembro2;
        private Label labelDataFormacao;
        private Label labelDataProximaMissao;
        private DateTimePicker dateTimePickerDataFormacao;
        private MaskedTextBox maskedTextBoxDataProximaMissao;
        private Label labelSituacao;
        private CheckBox checkBoxEmMissao;
        private CheckBox checkBoxNaAldeia;
        private CheckBox checkBoxTemporariamenteInativa;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNomeEquipe;
        private DataGridViewTextBoxColumn ColumnLider;
        private DataGridViewTextBoxColumn ColumnMembro1;
        private DataGridViewTextBoxColumn ColumnMembro2;
        private DataGridViewTextBoxColumn ColumnMembro3;
        private DataGridViewTextBoxColumn ColumnDataFormacao;
        private DataGridViewTextBoxColumn ColumnDataProximaMissao;
        private DataGridViewTextBoxColumn ColumnSituacao;
        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonCancelar;
        private Button Apagar;
    }
}