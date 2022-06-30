using Entra21_trabalho_02.Aldeias;
using Entra21_trabalho_02.Chakras;
using Entra21_trabalho_02.Clas;
using Entra21_trabalho_02.Equipes;
using Entra21_trabalho_02.Lideres;
using Entra21_trabalho_02.Ninjas;

namespace Entra21_trabalho_02
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonAldeia_Click(object sender, EventArgs e)
        {
            var aldeiasForm = new AldeiaForm();
            aldeiasForm.ShowDialog();
        }

        private void buttonChakra_Click(object sender, EventArgs e)
        {
            var chakrasForm = new ChakraForm();
            chakrasForm.ShowDialog();
        }

        private void buttonCla_Click(object sender, EventArgs e)
        {
            var clasForm = new ClaForm();
            clasForm.ShowDialog();
        }

        private void buttonEquipe_Click(object sender, EventArgs e)
        {
            var equipesForm = new EquipeForm();
            equipesForm.ShowDialog();
        }

        private void buttonLider_Click(object sender, EventArgs e)
        {
            var lideresForm = new LiderForm();
            lideresForm.ShowDialog();
        }

        private void buttonNinja_Click(object sender, EventArgs e)
        {
            var ninjasForm = new NinjaForm();
            ninjasForm.ShowDialog();
        }
    }
}
