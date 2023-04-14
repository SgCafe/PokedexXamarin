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

        #endregion

        #region constructor
        public ListaPokemonViewmodel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

           

    }
}
