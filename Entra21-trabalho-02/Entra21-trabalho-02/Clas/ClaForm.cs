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
        }

        private void PreencherComboBoxComOsNomesDosLideres()
        {
            var lideres = liderServico.ListarTodos();

            for (int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];
                textBox
                
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;


        }


    }
}
