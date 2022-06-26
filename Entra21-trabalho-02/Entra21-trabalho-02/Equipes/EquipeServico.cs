using Newtonsoft.Json;

namespace Entra21_trabalho_02.Equipes
{
    internal class EquipeServico
    {
        private List<Equipe> equipes;

        public EquipeServico()
        {
            equipes = new List<Equipe>();

            LerArquivo();
        }

        public void Adicionar(Equipe equipe)
        {
            equipes.Add(equipe);

            SalvarArquivo();
        }

        public void Apagar(Equipe equipeParaApagar)
        {
            for (var i = 0; i < equipes.Count; i++)
            {
                var equipe = equipes[i];

                if (equipe.Id == equipeParaApagar.Id)
                {
                    equipes.Remove(equipe);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Editar(Equipe equipeParaAlterar)
        {
            for (var i = 0; i < equipes.Count; i++)
            {
                var equipe = equipes[i];

                if (equipe.Id == equipeParaAlterar.Id)
                {
                    equipe.Nome = equipeParaAlterar.Nome;
                    equipe.Lider = equipeParaAlterar.Lider;
                    equipe.Membro1 = equipeParaAlterar.Membro1;
                    equipe.Membro2 = equipeParaAlterar.Membro2;
                    equipe.Membro3 = equipeParaAlterar.Membro3;
                    equipe.Formacao = equipeParaAlterar.Formacao;
                    equipe.InicioProximaMissao = equipeParaAlterar.InicioProximaMissao;
                    equipe.Situacao = equipeParaAlterar.Situacao;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void LerArquivo()
        {
            if (File.Exists("equipes.json") == false)
            {
                return;
            }

            var equipesJson = File.ReadAllText("equipes.json");
            equipes = JsonConvert.DeserializeObject<List<Equipe>>(equipesJson);
        }

        public void SalvarArquivo()
        {
            var equipesJson = JsonConvert.SerializeObject(equipes);
            File.WriteAllText("equipes.json", equipesJson);
        }

        public List<Equipe> ListarTodos()
        {
            return equipes;
        }

        public Equipe ObterPorId(int id)
        {
            for (var i = 0; i < equipes.Count; i++)
            {
                var equipe = equipes[i];

                if (equipe.Id == id)
                {
                    return equipe;
                }
            }

            return null;
        }

        public int ObterUltimoId()
        {
            var ultimoId = 0;

            for (var i = 0; i < equipes.Count; i++)
            {
                var equipe = equipes[i];

                ultimoId = equipe.Id;
            }

            return ultimoId;
        }
    }
}
