using Entra21_trabalho_02.Aldeias;
using Entra21_trabalho_02.Chakras;
using Entra21_trabalho_02.Clas;

namespace Entra21_trabalho_02.Ninjas
{
    internal class Ninja
    {
        public int Id;
        public string Nome;
        public Chakra ElementoChakra;
        public string DataNascimento;
        public string Genero;
        public bool Status;
        public Nivel Nivel;
        public Cla Cla;
        public Aldeia Aldeia;
        public bool KekkeiGenkai;

        /*
        public bool PossuiEquipe()
        {
        return true;
        }
        */

        /*public int CalcularIdade()
        {
            var idade = DateTime.Now.Year - DataNascimento.Year;

            return idade;
        }
        */
    }
}