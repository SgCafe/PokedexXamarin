﻿using Firebase.Database;
using Firebase.Database.Query;
using PokedexXamarin.Conexao;
using PokedexXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexXamarin.Dados
{
    public class Dpokemon
    {
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

        public async Task<ObservableCollection<Pokemon>> MostrarPokemon()
        {
            //Convertendo uma Lista para um ObservableCollection
            var data = await Task.Run(() =>

                Cconexao.firebase.Child("Pokemon")
                .AsObservable<Pokemon>()
                .AsObservableCollection()
            );
            return data;

            //return (await Cconexao.firebase.Child("Pokemon").OnceAsync<Pokemon>()).Select(item => new Pokemon
            //{
            //    IdPokemon = item.Key,
            //    Nome = item.Object.Nome,
            //    Tipos = item.Object.Tipos,
            //    Icone = item.Object.Icone,
            //    NumOrdem = item.Object.NumOrdem,
            //    CorFundo = item.Object.CorFundo,
            //    CorTipo = item.Object.CorTipo,
            //}).ToList();
        }
    }
}
