﻿using PokedexXamarin.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokedexXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarPokemon : ContentPage
    {
        public RegistrarPokemon()
        {
            InitializeComponent();
            BindingContext = new RegistrarPokemonViewmodel(Navigation);
        }
    }
}