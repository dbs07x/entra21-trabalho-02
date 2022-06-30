using Newtonsoft.Json;

namespace Entra21_trabalho_02.Clas
{
    internal class ClaServico
    {
        private List<Cla> clas;

        public ClaServico()
        {
            clas = new List<Cla>();

            LerArquivo();
        }

        public void Salvar(Cla cla)
        {
            clas.Add(cla);

            SalvarArquivo();
        }

        public void Editar(Cla claEditar)
        {
            for (int i = 0; i < clas.Count; i++)
            {
                var cla = clas[i];

                if (cla.Id == claEditar.Id)
                {
                    cla.Nome = claEditar.Nome;
                    cla.Lider = claEditar.Lider;
                    cla.KekkeiGenkai = claEditar.KekkeiGenkai;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(Cla claApagar)
        {
            for (int i = 0; i < clas.Count; i++)
            {
                var cla = clas[i];

                if (cla.Id == claApagar.Id)
                {
                    clas.Remove(cla);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Cla> ListarTodos()
        {
            return clas;
        }

        public Cla ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < clas.Count; i++)
            {
                var cla = clas[i];

                if (cla.Id == codigo)
                {
                    return cla;
                }
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < clas.Count; i++)
            {
                var cla = clas[i];

                ultimoCodigo = cla.Id;
            }

            return ultimoCodigo;
        }

        public void ListarClaPossuiKekkeiGenkai()
        {

        }

        public void ListarClaNaoPossuiKekkeiGenkai()
        {

        }

        public void ListarTodosMembrosCla()
        {

        }

        public void ListarMembroClaPorElementoChakra()
        {

        }

        public void ListarMembroClaPorGenero()
        {

        }

        public void ListarMembroClaPorStatus()
        {

        }

        public void ListarMembroClaPorNivel()
        {

        }

        public void ListarMembroClaPossuiEquipe()
        {

        }

        public void ListarMembroClaNaoPossuiEquipe()
        {

        }

        public void Adicionar(Cla cla)
        {
            clas.Add(cla);

            SalvarArquivo();
        }

        public void SalvarArquivo()
        {
            var clasJson = JsonConvert.SerializeObject(clas);
            File.WriteAllText("clas.json", clasJson);
        }

        public void LerArquivo()
        {
            if (File.Exists("clas.json") == false)
            {
                return;
            }

            var clasJson = File.ReadAllText("clas.json");
            clas = JsonConvert.DeserializeObject<List<Cla>>(clasJson);
        }
    }
}
