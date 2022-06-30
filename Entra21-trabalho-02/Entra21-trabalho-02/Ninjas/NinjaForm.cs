using Entra21_trabalho_02.Clas;

namespace Entra21_trabalho_02.Ninjas
{
    public partial class NinjaForm : Form
    {
        private NinjaServico ninjaServico;

        public NinjaForm()
        {
            InitializeComponent();

            comboBoxNivel.DataSource = Enum.GetValues(typeof(Nivel));
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var elementoChakra = comboBoxElementoChakra.Text;
            var dataNascimento = maskedTextBoxDataNascimento.Text;
            var nivel = comboBoxNivel.Text;
            var cla = comboBoxCla.Text;
            var aldeia = comboBoxAldeia.Text;

        }

        private void PreencherDataGridViewComNinjas()
        {
            var ninjas = ninjaServico.ObterTodos();

            dataGridView1.Rows.Clear();


        }


        /*
        Cadastrar
        Excluir
        Editar
        ListarTodos
        ListarPorElementoChakra
        ListarPorGenero
        ListarPorStatus
        ListarPorNivel
        ListarPossuiKekkeiGenkai
        ListarNaoPossuiKekkeiGenkai
        ListarPossuiEquipe
        ListarNaoPossuiEquipe
        ListarPossuiCla
        ListarNaoPossuiCla
        ListarPossuiAldeia
        ListarNaoPossuiAldeia
        */
    }
}
