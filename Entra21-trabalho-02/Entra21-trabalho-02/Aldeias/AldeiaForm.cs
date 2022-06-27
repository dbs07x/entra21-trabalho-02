namespace Entra21_trabalho_02.Aldeias
{
    public partial class AldeiaForm : Form
    {
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
    }
}
