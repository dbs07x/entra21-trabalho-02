using Entra21_trabalho_02.Lideres;

namespace Entra21_trabalho_02.Clas
{
    public partial class ClaForm : Form
    {
        private ClaServico claServico;

        private LiderServico liderServico;

        public ClaForm()
        {
            InitializeComponent();

            claServico = new ClaServico();

            liderServico = new LiderServico();

            PreencherDataGridViewComClas();

            PreencherComboBoxComOsNomesDosLideres();

            LimparCampos();
        }



        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var lider = Convert.ToString(comboBoxLider.SelectedItem);
            bool kekkeiGenkai;

            if (radioButtonSim.Checked == true)
            {
                kekkeiGenkai = true;
            }
            else
            {
                kekkeiGenkai = false;
            }

            var dataFormacaoDoCla = Convert.ToDateTime(dateTimePickerDataFormacaoDoCLa.Value);

            if (dataGridView1.SelectedRows.Count == 0)
                CadastarCla(nome, lider, kekkeiGenkai, dataFormacaoDoCla);
            else
                EditarCla(nome, lider, kekkeiGenkai, dataFormacaoDoCla);

            PreencherDataGridViewComClas();

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
                MessageBox.Show("Selecione um clã para apagar", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var resposta = MessageBox.Show("Deseja apagar o clã?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("O clã permanece na lista", "Aviso", MessageBoxButtons.OK);
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cla = claServico.ObterPorCodigo(codigo);

            claServico.Apagar(cla);

            PreencherDataGridViewComClas();

            dataGridView1.ClearSelection();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private void PreencherDataGridViewComClas()
        {
            var clas = claServico.ListarTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < clas.Count; i++)
            {
                var cla = clas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    cla.Id,
                    cla.Nome,
                    cla.Lider,
                    cla.KekkeiGenkai,
                    cla.DataFormacaoDoCla
                });
            }
        }

        private void PreencherComboBoxComOsNomesDosLideres()
        {
            var lideres = liderServico.ListarTodos();

            for (int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];
                comboBoxLider.Items.Add(lider.Nome);
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um clã para editar", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cla = claServico.ObterPorCodigo(codigo);

            textBoxNome.Text = cla.Nome;
            comboBoxLider.SelectedItem = cla.Lider;

            bool kekkeiGenkai;

            if (radioButtonSim.Checked == true)
            {
                kekkeiGenkai = true;
            }
            else
            {
                kekkeiGenkai = false;
            }

        }

        private void CadastarCla(string nome, string lider, bool kekkeiGenkai, DateTime dataFormacaoDoCla)
        {
            var cla = new Cla();
            cla.Id = claServico.ObterUltimoCodigo() + 1;
            cla.Nome = nome;
            cla.Lider = lider;
            cla.KekkeiGenkai = kekkeiGenkai;
            cla.DataFormacaoDoCla = dataFormacaoDoCla;

            claServico.Adicionar(cla);
        }

        private void EditarCla(string nome, string lider, bool kekkeiGenkai, DateTime dataFormacaoDoCla)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cla = new Cla();
            cla.Id = codigoSelecionado;
            cla.Nome = nome;
            cla.Lider = lider;
            cla.KekkeiGenkai = kekkeiGenkai;
            cla.DataFormacaoDoCla = dataFormacaoDoCla;

            claServico.Editar(cla);
        }
    }
}
