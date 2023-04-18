﻿using PokedexXamarin.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokedexXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new ListaPokemon());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
