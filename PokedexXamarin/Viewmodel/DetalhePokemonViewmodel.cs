using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PokedexXamarin.Viewmodel
{
    public class DetalhePokemonViewmodel : BaseViewmodel
    {
        #region properties
        public INavigation Navigation { get; set; }
        #endregion

        #region constructor
        public DetalhePokemonViewmodel(INavigation navigation) 
        {
            Navigation = navigation;
        }
        #endregion

        #region commands

        #endregion

        #region methods

        #endregion
    }
}
