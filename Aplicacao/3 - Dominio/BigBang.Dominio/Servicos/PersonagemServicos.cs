using BigBang.Dominio.Entidades;
using BigBang.Dominio.Interfaces.Repositorios;
using BigBang.Dominio.Interfaces.Servicos;
using RecursosCompartilhados.Dominio.Servicos;

namespace BigBang.Dominio.Servicos
{
    /*public class PersonagemServicos : BaseServicos<Personagem>, IPersonagemServicos
    {
        private readonly IPersonagemRepositorioSql _repositorio;

        public PersonagemServicos(IPersonagemRepositorioSql repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }*/

    public class PersonagemServicos
    {
        private readonly IPersonagemRepositorioMongo _repositorio;

        public PersonagemServicos(IPersonagemRepositorioMongo repositorio)
        {
            _repositorio = repositorio;
        }
    }
}