using Entra21_trabalho_02.Chakras;

namespace Entra21_trabalho_02.Lideres
{
    public partial class LiderForm : Form
    {
        private LiderServico liderServico;

        private ChakraServico chakraServico;

        public LiderForm()
        {
            InitializeComponent();

            liderServico = new LiderServico();

            chakraServico = new ChakraServico();

            comboBoxTitulo.DataSource = Enum.GetValues(typeof(Titulo));

            dataGridView1.ClearSelection();

            PreencherDataGridViewComLider();

            PreencherComboBoxComOsChakras();

            LimparCampos();
        }

        private void LiderForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComLider();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var titulo = Convert.ToString(comboBoxTitulo.SelectedItem);
            var idade = Convert.ToInt32(textBoxIdade.Text);
            string genero = ValidarGenero();
            var inicioLideranca = Convert.ToDateTime(dateTimePickerInicioLideranca.Text);
            var fimLideranca = maskedTextBoxFimLideranca.Text;
            bool statusVivo;
            var chakra = Convert.ToString(comboBoxChakra.SelectedItem);
            bool kekkeiGenkai;

            if (radioButtonVivo.Checked == true)
                statusVivo = true;
            else
                statusVivo = false;

            if (radioButtonSim.Checked == true)
                kekkeiGenkai = true;
            else
                kekkeiGenkai = false;

            var validarDados = ValidarDados();

            if (validarDados == false)
                return;

            if (dataGridView1.SelectedRows.Count == 0)
                AdicionarLider(nome, titulo, idade, genero, inicioLideranca, fimLideranca, statusVivo, chakra, kekkeiGenkai);
            else
                EditarLider(nome, titulo, idade, genero, inicioLideranca, fimLideranca, statusVivo, chakra, kekkeiGenkai);

            PreencherDataGridViewComLider();

            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um lider para editar!");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var lider = liderServico.ObterPorCodigo(codigo);

            textBoxNome.Text = lider.Nome;
            comboBoxTitulo.SelectedItem = lider.Titulo;
            textBoxIdade.Text = lider.Idade.ToString();
            string genero = ValidarGenero();
            dateTimePickerInicioLideranca.Text = lider.InicioLideranca.ToString();
            maskedTextBoxFimLideranca.Text = lider.FimLideranca.ToString();
            comboBoxChakra.SelectedItem = lider.Chakra.ToString();

            if (lider.Status == true)
                radioButtonVivo.Checked = true;
            else
                radioButtonMorto.Checked = true;

            if (lider.KekkeiGenkai == true)
                radioButtonSim.Checked = true;
            else
                radioButtonNao.Checked = true;

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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
                    lider.Nome,
                    lider.Titulo,
                    lider.Idade,
                    lider.Genero,
                    lider.InicioLideranca,
                    lider.FimLideranca,
                    lider.Status,
                    lider.Chakra,
                    lider.KekkeiGenkai
                });
            }

            dataGridView1.ClearSelection();
        }

        private void LimparCampos()
        {
            var hoje = DateTime.Today;

            textBoxNome.Clear();
            comboBoxTitulo.SelectedIndex = -1;
            textBoxIdade.Clear();
            checkBoxMasculino.Checked = false;
            checkBoxFeminino.Checked = false;
            checkBoxNaoBinario.Checked = false;
            checkBoxCisgenero.Checked = false;
            checkBoxTransgenero.Checked = false;
            dateTimePickerInicioLideranca.Value = hoje;
            maskedTextBoxFimLideranca.Clear();
            radioButtonVivo.Checked = true;
            comboBoxChakra.SelectedIndex = -1;
            radioButtonSim.Checked = true;
        }

        private bool ValidarDados()
        {
            if(textBoxNome.Text == string.Empty)
            {
                MessageBox.Show("Digite o nome do lider!", "Aviso", MessageBoxButtons.OK);

                textBoxNome.Focus();

                return false;
            }

            if(comboBoxTitulo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione algum titulo!", "Aviso", MessageBoxButtons.OK);

                comboBoxTitulo.DroppedDown = true;

                return false;
            }

            if(textBoxIdade.Text == string.Empty)
            {
                MessageBox.Show("Digite uma idade!", "Aviso", MessageBoxButtons.OK);

                textBoxIdade.Focus();

                return false;
            }

            if(dateTimePickerInicioLideranca.Value > DateTime.Today)
            {
                MessageBox.Show("Informe a data de inicio da liderança!", "Aviso", MessageBoxButtons.OK);

                dateTimePickerInicioLideranca.Select();

                return false;
            }

            if(maskedTextBoxFimLideranca.Text == String.Empty)
            {
                MessageBox.Show("informe a data de fim da liderança!", "Aviso", MessageBoxButtons.OK);

                maskedTextBoxFimLideranca.Focus();

                return false;
            }

            if(comboBoxChakra.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um chakra!", "Aviso", MessageBoxButtons.OK);

                comboBoxChakra.DroppedDown = true;

                return false;
            }

            return true;
        }

        private string ValidarGenero()
        {
            var genero = string.Empty;
            var identidadeGenero = string.Empty;

            if (checkBoxMasculino.Checked == true)
                genero = "Masculino";
            else if (checkBoxFeminino.Checked == true)
                genero = "Feminino";
            else
                genero = "Não-Binario";

            if (checkBoxCisgenero.Checked == true)
                identidadeGenero = "Cisgênero";
            else
                identidadeGenero = "Transgênero";

            var generoCompleto = genero + " / " + identidadeGenero;

            return generoCompleto;
        }

        private void AdicionarLider(string nome, string titulo, int idade, string genero, DateTime inicioLideranca, string fimLideranca, bool statusVivo, string chakra, bool kekkeiGenkai)
        {
            var lider = new Lider();
            lider.Codigo = liderServico.ObterUltimoCodigo() + 1;
            lider.Nome = nome;
            lider.Titulo = ObterTituloLider(titulo);
            lider.Genero = genero;
            lider.Idade = idade;
            lider.InicioLideranca = inicioLideranca;
            lider.FimLideranca = fimLideranca;
            lider.Status = statusVivo;
            lider.Chakra = chakra;
            lider.KekkeiGenkai = kekkeiGenkai;
           
            liderServico.Cadastrar(lider);
        }

        private void EditarLider(string nome, string titulo, int idade, string genero, DateTime inicioLideranca, string fimLideranca, bool statusVivo, string chakra, bool kekkeiGenkai)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var lider = new Lider();
            lider.Codigo = codigoSelecionado;
            lider.Nome = nome;
            lider.Titulo = ObterTituloLider(titulo);
            lider.Genero = genero;
            lider.Idade = idade;
            lider.InicioLideranca = inicioLideranca;
            lider.FimLideranca= fimLideranca;
            lider.Chakra = chakra;
            lider.Status = statusVivo;
            lider.KekkeiGenkai = kekkeiGenkai;

            liderServico.Editar(lider);
        }

        private void PreencherComboBoxComOsChakras()
        {
            var chakras = chakraServico.ListarTodos();

            for (int i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];
                comboBoxChakra.Items.Add(chakra.Natureza);
            }
        }

        private Titulo ObterTituloLider(string titulo)
        {
            if (titulo == "Hokage")
                return Titulo.Hokage;
            else if (titulo == "Kazekage")
                return Titulo.Hokage;
            else if (titulo == "Raikage")
                return Titulo.Raikage;
            else if (titulo == "Tsuchokage")
                return Titulo.Tsuchikage;
            else if (titulo == "Mizukage")
                return Titulo.Mizukage;
            else 
                return Titulo.Lider;
        }
    }
}
