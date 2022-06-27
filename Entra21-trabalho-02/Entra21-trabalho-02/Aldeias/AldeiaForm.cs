using Entra21_trabalho_02.Lideres;

namespace Entra21_trabalho_02.Aldeias
{
    public partial class AldeiaForm : Form
    {
        private AldeiaServico aldeiaServico;
        private LiderServico liderServico;

        
        public AldeiaForm()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxPais.Text = string.Empty;
            comboBoxLider.SelectedIndex = -1;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarInformacoesParaEdicao();
        }

        private void ApresentarInformacoesParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma aldeia para edição");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var aldeia = aldeiaServico.ApresentarPorCodigo(codigo);

            textBoxNome.Text = aldeia.Nome;
            textBoxPais.Text = aldeia.Pais;
            comboBoxLider.SelectedItem = aldeia.LiderAldeia.Nome;
        }

        public void PreencherDataGridViewComAldeias()
        {
            var aldeias = aldeiaServico.ListarTodas();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < aldeias.Count; i++)
            {
                var aldeia = aldeias[i];

                dataGridView1.Rows.Add(new object[]
                {
                    aldeia.Nome,
                    aldeia.Pais,
                    aldeia.LiderAldeia.Nome
                });
            }

            dataGridView1.ClearSelection();
        }
        
        public bool ValidarDados(string nome, string pais, string nomeLider)
        {
            if(nome.Trim().Length < 3)
            {
                MessageBox.Show("Nome deve conter no minímo 3 caracteres!");

                textBoxNome.Focus();

                return false;
            }

            if(pais.Trim().Length < 3)
            {
                MessageBox.Show("País deve conter no minímo 3 caracteres!");

                textBoxPais.Focus();

                return false;
            }

            if(comboBoxLider.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um lider!");

                comboBoxLider.DroppedDown = true;

                return false;
            }

            return true;
        }

        public void CadastrarAldeia(string nome, string pais, string nomeLider)
        {
            var aldeia = new Aldeia();
            aldeia.Codigo = aldeiaServico.ObterUltimoCodigo() + 1;
            aldeia.Nome = nome;
            aldeia.Pais = pais;
            aldeia.LiderAldeia = liderServico.ObterPorNomeLider(nome);

            aldeiaServico.Adicionar(aldeia);
        }

        public void EditarAldeia(string nome, string pais, string nomeLider)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var aldeia = new Aldeia();
            aldeia.Codigo = codigoSelecionado;
            aldeia.Nome = nome;
            aldeia.Pais = pais;
            aldeia.LiderAldeia = liderServico.ObterPorNomeLider(nomeLider);

            aldeiaServico.Adicionar(aldeia);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma aldeia para remover!");

                return;
            }

            var questionar = MessageBox.Show("Deseja realmente apagar essa aldeia?", "Aviso", MessageBoxButtons.YesNo);
           
            if(questionar != DialogResult.Yes)
            {
                MessageBox.Show("Aldeia não foi removida!");

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var aldeia = aldeiaServico.ApresentarPorCodigo(codigo);

            aldeiaServico.Apagar(aldeia);

            PreencherDataGridViewComAldeias();

            dataGridView1.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var pais = textBoxPais.Text;
            var nomeLider = Convert.ToString(comboBoxLider.SelectedItem);

            var dadosValidos = ValidarDados(nome, pais, nomeLider);

            if (dadosValidos == false)
                return;

            if (dataGridView1.SelectedCells.Count == 0)
                CadastrarAldeia(nome, pais, nomeLider);
            else
                EditarAldeia(nome, pais, nomeLider);

            PreencherDataGridViewComAldeias();

            LimparCampos();
        }
    }
}
