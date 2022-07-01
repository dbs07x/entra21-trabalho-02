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

            chakraServico = new ChakraServico();

            liderServico = new LiderServico();

            comboBoxTitulo.DataSource = Enum.GetValues(typeof(Titulo));

            PreencherDataGridViewComLider();

            PreencherComboBoxComOsChakras();
        }

        private void PreencherComboBoxComOsChakras()
        {
            var chakras = chakraServico.ListarTodos();

            for(int i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];
                comboBoxChakra.Items.Add(chakra.Natureza);
            }
        }

        private void AdicionarLider(string nome, string titulo, string genero, int idade, DateTime inicioLideranca, string fimLideranca, bool statusVivo, string? chakra, bool kekkeiGenkai)
        {
            var lider = new Lider
            {
                Codigo = liderServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                Titulo = ObterTituloLider(titulo),
                Idade = idade,
                Genero = genero,
                InicioLideranca = inicioLideranca,
                FimLideranca = fimLideranca,
                Status = statusVivo,
                Chakra = chakraServico.ObterPorNatureza(chakra),
                KekkeiGenkai = kekkeiGenkai
            };

            liderServico.Cadastrar(lider);

            LimparCampos();
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

        private void LimparCampos()
        {
            textBoxNome.Clear();
            comboBoxTitulo.SelectedIndex = -1;
            textBoxIdade.Clear();
            dateTimePickerInicioLideranca.CustomFormat = " ";
            maskedTextBoxFimLideranca.Text = string.Empty;
            comboBoxChakra.SelectedIndex = -1;

            dataGridView1.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            bool statusVivo;

            if (radioButtonVivo.Checked == true)
               statusVivo = true;
            else
               statusVivo = false;

            bool kekkeiGenkai;

            if (radioButtonSim.Checked == true)
                kekkeiGenkai = true;
            else
                kekkeiGenkai = false;

            var nome = textBoxNome.Text;
            var titulo = Convert.ToString(comboBoxTitulo.SelectedItem);
            var idade = Convert.ToInt32(textBoxIdade.Text);
            string genero = ValidarGenero();
            var inicioLideranca = Convert.ToDateTime(dateTimePickerInicioLideranca.Text);
            var fimLideranca = maskedTextBoxFimLideranca.Text;
            var chakra = Convert.ToString(comboBoxChakra.SelectedItem);

            if (dataGridView1.SelectedRows.Count == 0)
                AdicionarLider(nome, titulo, genero, idade, inicioLideranca, fimLideranca, statusVivo, chakra, kekkeiGenkai);
            else
                EditarLider(nome, titulo, genero, idade, inicioLideranca, fimLideranca, statusVivo, chakra, kekkeiGenkai);

            PreencherDataGridViewComLider();

            LimparCampos();
        }

        private  string ValidarGenero()
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
                    lider.Nome,
                    lider.Titulo,
                    lider.Idade,
                    lider.Genero,
                    lider.InicioLideranca,
                    lider.FimLideranca,
                    lider.Status,
                    lider.Chakra,
                    //lider.KekkeiGenkai
                }) ;
            }

            dataGridView1.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void EditarLider(string nome, string titulo, string genero, int idade, DateTime inicioLideranca, string fimLideranca, bool statusVivo, string chakra, bool kekkeiGenkai)
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
            lider.Chakra = chakraServico.ObterPorNatureza(chakra);
            lider.Status = statusVivo;
            lider.KekkeiGenkai = kekkeiGenkai;

            liderServico.Editar(lider);
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
    }
}
