using Newtonsoft.Json;

namespace Entra21_trabalho_02.Chakras
{
    internal class ChakraServico
    {
        private List<Chakra> chakras;

        public ChakraServico()
        {
            chakras = new List<Chakra>();

            LerArquivo();
        }

        public void Adicionar(Chakra chakra)
        {
            chakras.Add(chakra);

            SalvarArquivo();
        }

        public void Apagar(Chakra chakraParaApagar)
        {
            for (var i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];

                if (chakra.Id == chakraParaApagar.Id)
                {
                    chakras.Remove(chakra);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Editar(Chakra chakraParaAlterar)
        {
            for (var i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];

                if (chakra.Id == chakraParaAlterar.Id)
                {
                    chakra.Natureza = chakraParaAlterar.Natureza;
                    chakra.Tipo = chakraParaAlterar.Tipo;
                    chakra.Primario = chakraParaAlterar.Primario;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void LerArquivo()
        {
            if (File.Exists("chakras.json") == false)
            {
                return;
            }

            var chakraJson = File.ReadAllText("chakras.json");
            chakras = JsonConvert.DeserializeObject<List<Chakra>>(chakraJson);
        }

        public void SalvarArquivo()
        {
            var chakrasJson = JsonConvert.SerializeObject(chakras);
            File.WriteAllText("chakras.json", chakrasJson);
        }

        public List<Chakra> ListarTodos()
        {
            return chakras;
        }

        public Chakra ObterPorId(int id)
        {
            for (var i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];

                if (chakra.Id == id)
                {
                    return chakra;
                }
            }

            return null;
        }

        public int ObterUltimoId()
        {
            var ultimoId = 0;

            for (var i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];

                ultimoId = chakra.Id;
            }

            return ultimoId;
        }
    }
}
