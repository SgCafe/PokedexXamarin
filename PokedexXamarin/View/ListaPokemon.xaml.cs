using PokedexXamarin.Viewmodel;
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
    public partial class ListaPokemon : ContentPage
    {
        ListaPokemonViewmodel vm;
        public ListaPokemon()
        {
            InitializeComponent();
            vm = new ListaPokemonViewmodel(Navigation);
            BindingContext = vm;
            this.Appearing += ListaPokemon_Appearing;
        }

        private async void ListaPokemon_Appearing(object sender, EventArgs e)
        {
            await vm.MostrarPokemon();
        }
    }
}