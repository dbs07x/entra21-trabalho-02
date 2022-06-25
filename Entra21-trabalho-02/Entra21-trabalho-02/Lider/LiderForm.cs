namespace Entra21_trabalho_02.Lider
{
    public partial class LiderForm : Form
    {
        private LiderServico liderServico;
        public LiderForm()
        {
            InitializeComponent();

            liderServico = new LiderServico();

            PreencherComboBoxComTitulo();

            PreencherComboBoxComGenero();
        }

        private void AdicionarLider(string nome, TituloNinja titulo, GeneroNinja genero, int idade, DateTime inicioLideranca, DateTime fimLideranca)
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

        private void PreencherComboBoxComTitulo()
        {
            var lideres = liderServico.ListarTodos();

            for (int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];
                comboBoxTitulo.Items.Add(lider.Titulo);
            }
        }

        private void PreencherComboBoxComGenero()
        {
            var lideres = liderServico.ListarTodos();

            for (var i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];
                comboBoxGenero.Items.Add(lider.Genero);
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            comboBoxTitulo.SelectedIndex = -1;
            textBoxIdade.Clear();
            comboBoxGenero.SelectedIndex = -1;
            maskedTextBoxInicioLideranca.Clear();
            maskedTextBoxFimLideranca.Clear();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim().ToLower();
            var titulo = Convert.ToString(comboBoxTitulo.SelectedItem);
            var idade = Convert.ToInt32(textBoxIdade.Text.Trim().ToLower());
            var genero = Convert.ToString(comboBoxGenero.SelectedItem);
            var inicioLideranca = Convert.ToDateTime(maskedTextBoxInicioLideranca.Text);
            var fimLideranca = Convert.ToDateTime(maskedTextBoxFimLideranca.Text);

            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarLider(nome, titulo, genero, idade, inicioLideranca, fimLideranca);

                return;
            }
        }
    }
}
