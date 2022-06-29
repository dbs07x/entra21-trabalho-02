namespace Entra21_trabalho_02.Lideres
{
    public partial class LiderForm : Form
    {
        private LiderServico liderServico;

        public LiderForm()
        {
            InitializeComponent();

            comboBoxTitulo.DataSource = Enum.GetValues(typeof(Titulo));
            comboBoxChakra.DataSource = Enum.GetValues(typeof(Chakra));

            liderServico = new LiderServico();
        }

        private void AdicionarLider(string nome, string titulo, string genero, int idade, DateTime inicioLideranca, DateTime fimLideranca)
        {
            var lider = new Lider
            {
                //Codigo = codigo,
                Nome = nome,
                Titulo = titulo,
                Idade = idade,
                Genero = genero,
                InicioLideranca = inicioLideranca,
                FimLideranca = fimLideranca
            };

            liderServico.Cadastrar(lider);

            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            comboBoxTitulo.SelectedIndex = -1;
            textBoxIdade.Clear();
            comboBoxChakra.SelectedIndex = -1;
            dateTimePickerInicioLideranca.CustomFormat = "yyyy-MM-dd";
            maskedTextBoxFimLideranca.Text = string.Empty;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim().ToLower();
            var titulo = Convert.ToString(comboBoxTitulo.SelectedItem);
            var idade = Convert.ToInt32(textBoxIdade.Text.Trim().ToLower());
            string genero = ValidarGenero();
            var inicioLideranca = Convert.ToDateTime(dateTimePickerInicioLideranca.Text);
            var fimLideranca = Convert.ToDateTime(maskedTextBoxFimLideranca.Text);

            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarLider(nome, titulo, genero, idade, inicioLideranca, fimLideranca);

                return;
            }
        }

        private  string ValidarGenero()
        {
            var genero = string.Empty;
            var identidadeGenero = string.Empty;

            if(checkBoxMasculino.Checked == true)
            {
                genero = "Masculino";
            }
            var generoCompleto = genero + " / " + identidadeGenero;

            return generoCompleto;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um lider para remover!");

                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar o lider?", "Aviso", MessageBoxButtons.YesNo);

            if(resposta != DialogResult.Yes)
            {
                MessageBox.Show("O lider não foi apagado");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var lider = liderServico.ObterPorCodigo(codigo);

            liderServico.Excluir(lider);

            PreencherDataGridViewComLider();

            dataGridView1.ClearSelection();
        }

        private void PreencherDataGridViewComLider()
        {
            var lideres = liderServico.ListarTodos();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];

                dataGridView1.Rows.Add(new object[]
                {
                    lider.Codigo,
                    lider.Idade,
                    lider.Nome,
                    lider.Titulo,
                    lider.Genero,
                    lider.InicioLideranca,
                    lider.FimLideranca,
                    lider.Status,
                    lider.KekkeiGenkai
                }) ;
            }

            dataGridView1.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void checkBoxMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
