using Newtonsoft.Json;

namespace Entra21_trabalho_02.Ninjas
{
    internal class NinjaServico
    {
        private List<Ninja> ninjas;

        public NinjaServico()
        {
            ninjas = new List<Ninja>();

            LerArquivo();
        }

        public void Salvar(Ninja ninja)
        {
            ninjas.Add(ninja);

            SalvarArquivo();
        }

        public void Editar(Ninja ninjaEditar)
        {
            for (int i = 0; i < ninjas.Count; i++)
            {
                var ninja = ninjas[i];

                if (ninja.Id == ninjaEditar.Id)
                {
                    ninja.Nome = ninjaEditar.Nome;
                    // ninja.Chakra = ninjaEditar.Chakra;
                    ninja.DataNascimento = ninjaEditar.DataNascimento;
                    ninja.Genero = ninjaEditar.Genero;
                    ninja.Status = ninjaEditar.Status;
                    ninja.Nivel = ninjaEditar.Nivel;
                    ninja.Cla = ninjaEditar.Cla;
                    // ninja.Aldeia = ninjaEditar.Aldeia;
                    ninja.KekkeiGenkai = ninjaEditar.KekkeiGenkai;
                                           
                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(Ninja claApagar)
        {
            for (int i = 0; i < ninjas.Count; i++)
            {
                var cla = ninjas[i];

                if (cla.Id == claApagar.Id)
                {
                    ninjas.Remove(cla);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public List<Ninja> ObterTodos()
        {
            return ninjas;
        }

        public Ninja ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < ninjas.Count; i++)
            {
                var endereco = ninjas[i];

                if (endereco.Id == codigo)
                {
                    return endereco;
                }
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < ninjas.Count; i++)
            {
                var endereco = ninjas[i];

                ultimoCodigo = endereco.Id;
            }

            return ultimoCodigo;
        }

        public Ninja ObterPorNomeNinja(string nomeNinja)
        {
            for (int i = 0; i < ninjas.Count; i++)
            {
                var ninja = ninjas[i];

                if (ninja.Nome == nomeNinja)
                {
                    return ninja;
                }
            }

            return null;
        }

        public List<Ninja> ListarTodos()
        {
            return ninjas;
        }

        public void SalvarArquivo()
        {
            var ninjasJson = JsonConvert.SerializeObject(ninjas);
            File.WriteAllText("ninjas.json", ninjasJson);
        }

        public void LerArquivo()
        {
            if (File.Exists("ninjas.json") == false)
            {
                return;
            }

            var ninjasJson = File.ReadAllText("ninjas.json");
            ninjas = JsonConvert.DeserializeObject<List<Ninja>>(ninjasJson);
        }
    }
}
