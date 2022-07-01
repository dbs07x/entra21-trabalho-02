using Newtonsoft.Json;

namespace Entra21_trabalho_02.Ninjas
{
    internal class NinjaServico
    {
        private List<Ninja> ninjas;
        private List<Genero> generos;

        public NinjaServico()
        {
            ninjas = new List<Ninja>();

            LerArquivo();
        }

        public void Adicionar(Ninja ninja)
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
                    ninja.ElementoChakra = ninjaEditar.ElementoChakra;
                    ninja.DataNascimento = ninjaEditar.DataNascimento;
                    ninja.Genero = ninjaEditar.Genero;
                    ninja.Status = ninjaEditar.Status;
                    ninja.Nivel = ninjaEditar.Nivel;
                    ninja.Cla = ninjaEditar.Cla;
                    ninja.Aldeia = ninjaEditar.Aldeia;
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

        public Genero ObterGeneroNinja(string generoNinja)
        {
            if (generoNinja == "Masculino")
            {
                return Genero.Masculino;
            }
            else if (generoNinja == "Feminino")
            {
                return Genero.Feminino;
            }
            else if (generoNinja == "Não-Binário")
            {
                return Genero.NaoBinario;
            }
            else if (generoNinja == "Cisgenero")
            {
                return Genero.Cisgenero;
            }
            else
            {
                return Genero.Transgenero;
            }
        }

        public Status ObterStatusNinja(string status)
        {
            if (status == "Vivo")
            {
                return Status.Vivo;
            }
            else
            {
                return Status.Morto;
            }
        }

        public Nivel ObterNivelNinja(string nivel)
        {
            if (nivel == "Aluno da Academia")
            {
                return Nivel.AlunoDaAcademia;
            }
            else if (nivel == "Genin")
            {
                return Nivel.Genin;
            }
            else if (nivel == "Chuunin")
            {
                return Nivel.Chuunin;
            }
            else if (nivel == "Anbu")
            {
                return Nivel.Anbu;
            }
            else if (nivel == "Sannin")
            {
                return Nivel.Sannin;
            }
            else if (nivel == "Kage")
            {
                return Nivel.Kage;
            }
            else
            {
                return Nivel.Nukenin;
            }
        }
    }
}
