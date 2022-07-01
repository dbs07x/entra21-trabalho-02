using Newtonsoft.Json;

namespace Entra21_trabalho_02.Aldeias
{
    internal class AldeiaServico
    {
        private List<Aldeia> aldeias;

        public AldeiaServico()
        {
            aldeias = new List<Aldeia>();

            LerArquivo();
        }

        public void Adicionar(Aldeia aldeia)
        {
            aldeias.Add(aldeia);

            SalvarArquivo();
        }

        public void Editar(Aldeia aldeiaEditar)
        {
            for(int i = 0; i < aldeias.Count; i++)
            {
                var aldeia = aldeias[i];

                if(aldeia.Codigo == aldeiaEditar.Codigo)
                {
                    aldeia.Nome = aldeiaEditar.Nome;
                    aldeia.Pais = aldeiaEditar.Pais;
                    aldeia.Lider = aldeiaEditar.Lider;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(int codigo)
        {
            for(int i = 0; i < aldeias.Count; i++)
            {
                var aldeia = aldeias[i];

                if(aldeia.Codigo == codigo)
                {
                    aldeias.Remove(aldeia);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Aldeia> ListarTodas()
        {
            return aldeias;
        }

        public Aldeia ApresentarPorCodigo(int codigo)
        {
            for(int i = 0; i < aldeias.Count; i++)
            {
                var aldeia = aldeias[i];

                if(aldeia.Codigo == codigo)
                {
                    return aldeia;
                }
            }

            return null;
        }

        public void SalvarArquivo()
        {
            var aldeiaJson = JsonConvert.SerializeObject(aldeias);
            File.WriteAllText("aldeias.json", aldeiaJson);
        }

        public void LerArquivo()
        {
            if (File.Exists("aldeias.json") == false)
                return;

            var aldeiaJson = File.ReadAllText("aldeias.json");
            aldeias = JsonConvert.DeserializeObject<List<Aldeia>>(aldeiaJson);
        }

        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;

            for(int i = 0; i < aldeias.Count; i++)
            {
                var aldeia = aldeias[i];

                ultimoCodigo = aldeia.Codigo;
            }

            return ultimoCodigo;
        }

        public Aldeia ObterPorCodigo(int codigo)
        {
            for(int i = 0; i < aldeias.Count; i++)
            {
                var aldeia = aldeias[i];

                if (aldeia.Codigo == codigo)
                    return aldeia;
            }

            return null;
        }

        public Aldeia ObterAldeiaPeloNome(string nomeAldeia)
        {
            for(int i = 0; i < aldeias.Count; i++)
            {
                var aldeia = aldeias[i];

                if(aldeia.Nome == nomeAldeia)
                {
                    return aldeia;
                }
            }

            return null;
        }
    }
}
