using Newtonsoft.Json;

namespace Entra21_trabalho_02.Lideres
{
    internal class LiderServico
    {
        private List<Lider> lideres;

        public LiderServico()
        {
            lideres = new List<Lider>();

            LerArquivo();
        }

        public List<Lider> ListarTodos()
        {
            return lideres;
        }

        public void Cadastrar(Lider lider)
        {
            lideres.Add(lider);

            SalvarArquivo();
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
                    lider.Chakra = liderParaAlterar.Chakra;

                    SalvarArquivo();

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

        public void LerArquivo()
        {
            if (File.Exists("lideres.json") == false)
                return;

            var lideresEmJson = File.ReadAllText("lideres.json");
            lideres = JsonConvert.DeserializeObject<List<Lider>>(lideresEmJson);
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for(int i = 0; i < lideres.Count; i++)
            {
                var lider = lideres[i];

                ultimoCodigo = lider.Codigo;
            }

            return ultimoCodigo;
        }
    }
}
