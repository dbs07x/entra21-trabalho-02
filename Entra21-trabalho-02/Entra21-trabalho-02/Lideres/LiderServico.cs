using Newtonsoft.Json;

namespace Entra21_trabalho_02.Lideres
{
    internal class LiderServico
    {
        private List<Lider> lideres;

        public LiderServico()
        {
            lideres = new List<Lider>();
        }

        public List<Lider> ListarTodos()
        {
            return lideres;
        }

        public void Cadastrar(Lider lider)
        {
            lideres.Add(lider);
        }

        public void Editar(Lider liderParaAlterar)
        {
            for (int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];

                if (lider.Codigo == liderParaAlterar.Codigo)
                {
                    lider.Nome = liderParaAlterar.Nome;
                    lider.Titulo = liderParaAlterar.Titulo;
                    lider.Idade = liderParaAlterar.Idade;
                    lider.Genero = liderParaAlterar.Genero;
                    lider.InicioLideranca = liderParaAlterar.InicioLideranca;
                    lider.FimLideranca = liderParaAlterar.FimLideranca;
                    lider.Status = liderParaAlterar.Status;

                    return;
                }
            }
        }

        public void Excluir(Lider liderParaApagar)
        {
            for (int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];

                if (lider.Codigo == liderParaApagar.Codigo)
                {
                    lideres.Remove(lider);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void SalvarArquivo()
        {
            var lideresJson = JsonConvert.SerializeObject(lideres);
            File.WriteAllText("lideres.json", lideresJson);
        }

        public Lider ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];

                if (lider.Codigo == codigo)
                {
                    return lider;
                }
            }
            return null;
        }

        public Lider ObterPorNomeLider(string nomeLider)
        {
            for(int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];

                if(lider.Nome == nomeLider)
                {
                    return lider;
                }
            }

            return null;
        }
    }
}
