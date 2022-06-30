namespace Entra21_trabalho_02.Chakras
{
    public partial class ChakraForm : Form
    {

        private ChakraServico chakraServico;

        public ChakraForm()
        {
            InitializeComponent();

            chakraServico = new ChakraServico();

            comboBoxNatureza.DataSource = Enum.GetValues(typeof(Natureza));

            comboBoxTipo.DataSource = Enum.GetValues(typeof(Tipo));           

            PreencherDataGridViewComChakras();

            LimparCampos();
        }

        private void ChakraForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComChakras();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var natureza = Convert.ToString(comboBoxNatureza.SelectedItem);
            var tipo = Convert.ToString(comboBoxTipo.SelectedItem);
            bool elementoEhPrimario;

            if (radioButtonSim.Checked ==  true)
            {
                elementoEhPrimario = true;
            }
            else
            {
                elementoEhPrimario = false;
            }

            var dadosValidos = ValidarDados();

            if (dadosValidos == false)
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                CadastrarChakra(natureza, tipo, elementoEhPrimario);
            }
            else
            {
                EditarChakra(natureza, tipo, elementoEhPrimario);
            }

            PreencherDataGridViewComChakras();

            LimparCampos();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar o endereço?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa, teu registro está ali salvo!", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var chakra = chakraServico.ObterPorId(codigo);

            chakraServico.Apagar(chakra);

            PreencherDataGridViewComChakras();

            dataGridView1.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void PreencherDataGridViewComChakras()
        {
            var chakras = chakraServico.ListarTodos();

            dataGridView1.Rows.Clear();

            for (var i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];

                dataGridView1.Rows.Add(new object[]
                {
                    chakra.Id,
                    chakra.Natureza,                    
                    chakra.Tipo,
                    chakra.Primario
                });
            }

            dataGridView1.ClearSelection();
        }

        private void LimparCampos()
        {
            comboBoxNatureza.SelectedIndex = -1;
            comboBoxTipo.SelectedIndex = -1;
            radioButtonSim.Checked = true;
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um chakra para editar", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var chakra = chakraServico.ObterPorId(codigo);

            comboBoxNatureza.SelectedItem = chakra.Natureza;
            comboBoxTipo.SelectedItem = chakra.Tipo;

            if (chakra.Primario == true)
            {
                radioButtonSim.Checked = true;
            }
            else
            {
                radioButtonNao.Checked = true;
            }
        }

        private bool ValidarDados()
        {
            if (comboBoxNatureza.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma natureza", "Aviso", MessageBoxButtons.OK);

                comboBoxNatureza.DroppedDown = true;

                return false;
            }

            if (comboBoxTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um tipo", "Aviso", MessageBoxButtons.OK);

                comboBoxTipo.DroppedDown = true;

                return false;
            }

            return true;
        }

        private void CadastrarChakra(string natureza, string tipo, bool ehPrimario)
        {
            var chakra = new Chakra();
            chakra.Id = chakraServico.ObterUltimoId() + 1;
            chakra.Natureza = chakraServico.ObterNaturezaChakra(natureza);
            chakra.Tipo = chakraServico.ObterTipoChakra(tipo);
            chakra.Primario = ehPrimario;

            chakraServico.Adicionar(chakra);
        }

        private void EditarChakra(string natureza, string tipo, bool ehPrimario)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var chakra = new Chakra();
            chakra.Id = codigoSelecionado;
            chakra.Natureza = chakraServico.ObterNaturezaChakra(natureza);
            chakra.Tipo = chakraServico.ObterTipoChakra(tipo);
            chakra.Primario = ehPrimario;

            chakraServico.Editar(chakra);
        }        
    }
}