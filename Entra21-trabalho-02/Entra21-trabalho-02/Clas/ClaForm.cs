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
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var lider = Convert.ToString(comboBoxLider.SelectedItem);
            bool kekkeigenkai;

            if (radioButtonSim.Checked == true)
            {
                kekkeigenkai = true;
            }
            else
            {
                kekkeigenkai = false;
            }

            var dataFormacao = Convert.ToString(dateTimePickerDataFormacaoDoCLa.Text);

            CadastarCla(nome, lider, kekkeigenkai);

            PreencherDataGridViewComClas();

            LimparCampos();
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

        private void PreencherDataGridViewComClas()
        {
            var clas = claServico.ListarTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < clas.Count; i++)
            {
                var cla = clas[i];

                dataGridView1.Rows.Add(new object[]
                {
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

        private void CadastarCla(string nome, string lider, bool kekkeigenkai)
        {
            var cla = new Cla();
            cla.Id = claServico.ObterUltimoCodigo() + 1;
            cla.Nome = nome;
            cla.Lider = lider;
            cla.KekkeiGenkai = kekkeigenkai;

            claServico.Adicionar(cla);
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
        }


    }
}
