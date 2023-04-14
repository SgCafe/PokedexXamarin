using Firebase.Database.Query;
using PokedexXamarin.Conexao;
using PokedexXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokedexXamarin.Dados
{
    public class Dpokemon
    {
        //Pulei anotações o tempo 1:19

        public async Task InsertPokemon(Pokemon parametros)
        {
            await Cconexao.firebase.Child("Pokemon").PostAsync(new Pokemon()
            {
                CorFundo = parametros.CorFundo,
                CorTipo = parametros.CorTipo,
                Icone = parametros.Icone,
                Nome = parametros.Nome,
                NumOrdem = parametros.NumOrdem,
                Tipos = parametros.Tipos,
                IdPokemon = parametros.IdPokemon,
            });
        }
    }
}
