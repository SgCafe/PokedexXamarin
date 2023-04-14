using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PokedexXamarin.Viewmodel
{
    public class RegistrarPokemonViewmodel : BaseViewmodel
    {
        #region properties
        public INavigation Navigation { get; }

        #endregion

        #region constructor
        public RegistrarPokemonViewmodel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
    }
}
