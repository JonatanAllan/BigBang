using System.Collections.Generic;
using BigBang.Dominio.Entidades;

namespace BigBang.Dominio.Interfaces.Repositorios
{
    public interface IPersonagemRepositorioMongo
    {
        ICollection<Personagem> Listar();
    }
}