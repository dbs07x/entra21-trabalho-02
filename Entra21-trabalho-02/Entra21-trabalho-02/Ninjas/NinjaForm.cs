using Entra21_trabalho_02.Aldeias;
using Entra21_trabalho_02.Chakras;
using Entra21_trabalho_02.Clas;

namespace Entra21_trabalho_02.Ninjas
{
    public partial class NinjaForm : Form
    {
        private NinjaServico ninjaServico;

        private ChakraServico chakraServico;

        private ClaServico claServico;

        private AldeiaServico aldeiaServico;

        public NinjaForm()
        {
            InitializeComponent();

            ninjaServico = new NinjaServico();

            chakraServico = new ChakraServico();

            claServico = new ClaServico();

            aldeiaServico = new AldeiaServico();

            PreencherDataGridViewComNinjas();

            PreencherComboBoxComOsChakras();

            comboBoxNivel.DataSource = Enum.GetValues(typeof(Nivel));

            PreencherComboBoxComOsClas();

            PreencherComboBoxComAsAldeias();

            LimparCampos();
        }

        private void NinjaForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComNinjas();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var natureza = comboBoxElementoChakra.Text;
            var dataNascimento = maskedTextBoxDataNascimento.Text;
            string genero;

            if ((checkBoxMasculino.Checked == true) && (checkBoxFeminino.Checked == false) && (checkBoxNaoBinario.Checked == false) && (checkBoxCisgenero.Checked == false) && (checkBoxTransgenero.Checked == false))
            {
                genero = "Masculino";
            }

            else if ((checkBoxMasculino.Checked == false) && (checkBoxFeminino.Checked == true) && (checkBoxNaoBinario.Checked == false) && (checkBoxCisgenero.Checked == false) && (checkBoxTransgenero.Checked == false))
            {
                genero = "Feminino";
            }

            else
            {
                genero = "Não-Binário";
            }

            bool status;

            if (radioButtonSim.Checked == true)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            var nivel = comboBoxNivel.Text;
            var cla = comboBoxCla.Text;
            var aldeia = comboBoxAldeia.Text;

            bool kekkeiGenkai;

            if (radioButtonSim.Checked == true)
            {
                kekkeiGenkai = true;
            }
            else
            {
                kekkeiGenkai = false;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                CadastarNinja(nome, natureza, dataNascimento, genero, status, nivel, cla, aldeia, kekkeiGenkai);
            }

            else
            {
                EditarNinja(nome, natureza, dataNascimento, genero, status, nivel, cla, aldeia, kekkeiGenkai);
            }

            PreencherDataGridViewComNinjas();

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
                MessageBox.Show("Selecione um ninja para apagar", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var resposta = MessageBox.Show("Deseja apagar o ninja?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("O ninja permanece na lista", "Aviso", MessageBoxButtons.OK);
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var ninja = ninjaServico.ObterPorCodigo(codigo);

            ninjaServico.Apagar(ninja);

            PreencherDataGridViewComNinjas();

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

        private void PreencherDataGridViewComNinjas()
        {
            var ninjas = ninjaServico.ListarTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < ninjas.Count; i++)
            {
                var ninja = ninjas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    ninja.Id,
                    ninja.Nome,
                    ninja.ElementoChakra,
                    ninja.DataNascimento,
                    ninja.Genero,
                    ninja.Status,
                    ninja.Nivel,
                    ninja.Cla,
                    ninja.Aldeia,
                    ninja.KekkeiGenkai
                });
            }
        }

        private void PreencherComboBoxComOsChakras()
        {
            var chakras = chakraServico.ListarTodos();

            for (int i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];
                comboBoxElementoChakra.Items.Add(chakra.Natureza);
            }
        }

        private void PreencherComboBoxComOsClas()
        {
            var clas = claServico.ListarTodos();

            for (int i = 0; i < clas.Count; i++)
            {
                var cla = clas[i];
                comboBoxCla.Items.Add(cla.Nome);
            }
        }

        private void PreencherComboBoxComAsAldeias()
        {
            var aldeias = aldeiaServico.ListarTodas();

            for (int i = 0; i < aldeias.Count; i++)
            {
                var aldeia = aldeias[i];
                comboBoxAldeia.Items.Add(aldeia.Nome);
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
                MessageBox.Show("Selecione um ninja para editar", "Aviso", MessageBoxButtons.OK);

                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var ninja = ninjaServico.ObterPorCodigo(codigo);

            textBoxNome.Text = ninja.Nome;
            comboBoxElementoChakra.SelectedItem = ninja.ElementoChakra;
            maskedTextBoxDataNascimento.Text = ninja.DataNascimento;

            bool status;

            if (radioButtonSim.Checked == true)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            comboBoxNivel.SelectedItem = ninja.Nivel;
            comboBoxCla.SelectedItem = ninja.Cla;
            comboBoxAldeia.SelectedItem = ninja.Aldeia;

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

        private void CadastarNinja(string nome, string natureza, string dataNascimento, string genero, bool status, string nivel, string cla, string aldeia, bool kekkeiGenkai)
        {
            var ninja = new Ninja();
            ninja.Id = ninjaServico.ObterUltimoCodigo() + 1;
            ninja.Nome = nome;
            ninja.ElementoChakra = chakraServico.ObterPorNatureza(natureza);
            ninja.DataNascimento = dataNascimento;
            ninja.Genero = genero;
            ninja.Status = status;
            ninja.Nivel = ninjaServico.ObterNivelNinja(nivel);
            ninja.Cla = claServico.ObterPorNomeCla(cla);
            ninja.Aldeia = aldeiaServico.ObterAldeiaPeloNome(aldeia);
            ninja.KekkeiGenkai = kekkeiGenkai;

            ninjaServico.Adicionar(ninja);
        }

        private void EditarNinja(string nome, string natureza, string dataNascimento, string genero, bool status, string nivel, string cla, string aldeia, bool kekkeiGenkai)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var ninja = new Ninja();
            ninja.Id = ninjaServico.ObterUltimoCodigo() + 1;
            ninja.Nome = nome;
            ninja.ElementoChakra = chakraServico.ObterPorNatureza(natureza);
            ninja.DataNascimento = dataNascimento;
            ninja.Genero = genero;
            ninja.Status = status;
            ninja.Nivel = ninjaServico.ObterNivelNinja(nivel);
            ninja.Cla = claServico.ObterPorNomeCla(cla);
            ninja.Aldeia = aldeiaServico.ObterAldeiaPeloNome(aldeia);
            ninja.KekkeiGenkai = kekkeiGenkai;

            ninjaServico.Editar(ninja);
        }
    }
}
