using System.Collections.Generic;
using BigBang.Dados.Contexto;
using BigBang.Dominio.Entidades;
using BigBang.Dominio.Interfaces.Repositorios;
using MongoDB.Driver;

namespace BigBang.Dados.Repositorios
{
    public class PersonagemRepositorioMongo : IPersonagemRepositorioMongo
    {
        BigBangContextoMongo Contexto = new BigBangContextoMongo();

        public ICollection<Personagem> Listar()
        {
            return Contexto.Personagens.FindSync(m => true).ToList();
        }

        public void Adicionar(Personagem personagem)
        {
            Contexto.Personagens.InsertOne(personagem);
        }
    }
}