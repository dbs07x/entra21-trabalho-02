using Entra21_trabalho_02.Ninjas;

namespace Entra21_trabalho_02.Equipes
{
    internal class Equipe
    {
        public int Id;
        public string Nome;
        public Ninja Lider;
        public Ninja Membro1;
        public Ninja Membro2;
        public Ninja Membro3;
        public DateTime Formacao;
        public DateTime InicioProximaMissao;
        public Situacao Situacao;
    }
}