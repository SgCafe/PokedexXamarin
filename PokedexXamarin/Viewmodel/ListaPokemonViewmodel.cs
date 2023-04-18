﻿using PokedexXamarin.Dados;
using PokedexXamarin.Model;
using PokedexXamarin.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PokedexXamarin.Viewmodel
{
    public class ListaPokemonViewmodel : BaseViewmodel
    {
        #region properties
        public INavigation Navigation { get; }

        
        private List<Pokemon> _ListaPokemon;
        public List<Pokemon> ListaPokemon
        {
            get => _ListaPokemon;
            set => SetProperty(ref _ListaPokemon, value);
        }


        #endregion

        #region constructor
        public ListaPokemonViewmodel(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPokemon();
        }
        #endregion

        #region commands
        public ICommand RegistrarCommand => new Command(async () => await Registrar());
        #endregion

        #region methods
        public async Task MostrarPokemon()
        {
            var function = new Dpokemon();
            ListaPokemon = await function.MostrarPokemon();
        }

        public async Task Registrar()
        {
            await Navigation.PushAsync(new RegistrarPokemon());
        }
        
        #endregion


    }
}
