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

        public Natureza ObterNaturezaChakra(string natureza)
        {
            if (natureza == "Aço")
            {
                return Natureza.Aço;
            }
            else if (natureza == "Água")
            {
                return Natureza.Água;
            }
            else if (natureza == "Calor")
            {
                return Natureza.Calor;
            }
            else if (natureza == "Chama")
            {
                return Natureza.Chama;
            }
            else if (natureza == "Cristal")
            {
                return Natureza.Cristal;
            }
            else if (natureza == "Ebulição")
            {
                return Natureza.Ebulição;
            }
            else if (natureza == "Espuma")
            {
                return Natureza.Espuma;
            }
            else if (natureza == "Explosão")
            {
                return Natureza.Explosão;
            }
            else if (natureza == "Fogo")
            {
                return Natureza.Fogo;
            }
            else if (natureza == "Fusão")
            {
                return Natureza.Fusão;
            }
            else if (natureza == "Gelo")
            {
                return Natureza.Gelo;
            }
            else if (natureza == "Lama")
            {
                return Natureza.Lama;
            }
            else if (natureza == "Madeira")
            {
                return Natureza.Madeira;
            }
            else if (natureza == "Magnetismo")
            {
                return Natureza.Magnetismo;
            }
            else if (natureza == "Pó")
            {
                return Natureza.Pó;
            }
            else if (natureza == "Raio")
            {
                return Natureza.Raio;
            }
            else if (natureza == "Rápido")
            {
                return Natureza.Rápido;
            }
            else if (natureza == "Tempestade")
            {
                return Natureza.Tempestade;
            }
            else if (natureza == "Terra")
            {
                return Natureza.Terra;
            }
            else if (natureza == "Tufão")
            {
                return Natureza.Tufão;
            }
            else if (natureza == "Vento")
            {
                return Natureza.Vento;
            }
            else if (natureza == "Yang")
            {
                return Natureza.Yang;
            }
            else
            {
                return Natureza.Yin;
            }
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

        public Chakra ObterPorNatureza(string natureza)
        {
            var tipo = ObterNaturezaChakra(natureza);

            for (var i = 0; i < chakras.Count; i++)
            {
                var chakra = chakras[i];

                if (chakra.Natureza == tipo)
                {
                    return chakra;
                }
            }

            return null;
        }

        public Tipo ObterTipoChakra(string tipo)
        {
            if (tipo == "BestaDeCauda")
            {
                return Tipo.BestaDeCauda;
            }
            else if (tipo == "Normal")
            {
                return Tipo.Normal;
            }
            else
            {
                return Tipo.Sábio;
            }
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
