using Entra21_trabalho_02.Clas;

namespace Entra21_trabalho_02.Ninjas
{
    internal class Ninja
    {
        public int Id;
        public string Nome;
        // public Chakra ElementoChakra;
        public DateTime DataNascimento;
        public Genero Genero;
        public Status Status;
        // public Nivel Nivel;
        public Cla Cla;
        // public Aldeia Aldeia
        public bool KekkeiGenkai;

        /*
        public bool PossuiEquipe()
        {
        return true;
        }
        */

        public int CalcularIdade()
        {
            var idade = DateTime.Now.Year - DataNascimento.Year;

            return idade;
        }
    }
}