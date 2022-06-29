namespace Entra21_trabalho_02.Lideres
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
                comboBoxChakra.Items.Add(lider.Genero);
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            comboBoxTitulo.SelectedIndex = -1;
            textBoxIdade.Clear();
            comboBoxChakra.SelectedIndex = -1;
            dateTimePickerInicioLideranca.CustomFormat = "yyyy-MM-dd";
            dateTimePickerFimLideranca.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim().ToLower();
            var titulo = Convert.ToString(comboBoxTitulo.SelectedItem);
            var idade = Convert.ToInt32(textBoxIdade.Text.Trim().ToLower());
            var genero = Convert.ToString(comboBoxChakra.SelectedItem);
            var inicioLideranca = Convert.ToDateTime(dateTimePickerInicioLideranca.Text);
            var fimLideranca = Convert.ToDateTime(dateTimePickerFimLideranca.Text);

            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarLider(nome, titulo, genero, idade, inicioLideranca, fimLideranca);

                return;
            }
        }
    }
}
