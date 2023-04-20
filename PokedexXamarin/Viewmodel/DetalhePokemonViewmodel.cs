using PokedexXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PokedexXamarin.Viewmodel
{
    public class DetalhePokemonViewmodel : BaseViewmodel
    {
        #region properties
        public INavigation Navigation { get; set; }

        private Pokemon _parametrosRecebe;

        public Pokemon ParametrosRecebe
        {
            get => _parametrosRecebe;
            set => SetProperty(ref _parametrosRecebe, value); 
        }


        #endregion

        #region constructor
        public DetalhePokemonViewmodel(INavigation navigation, Pokemon parametros) 
        {
            Navigation = navigation;
            ParametrosRecebe = parametros;
        }
        #endregion

        #region commands
        public ICommand VoltarCommand => new Command(async () => await Voltar());
        #endregion

        #region methods
        private async Task Voltar()
        {
            await Navigation.PopAsync();
        }
        #endregion
    }
}
