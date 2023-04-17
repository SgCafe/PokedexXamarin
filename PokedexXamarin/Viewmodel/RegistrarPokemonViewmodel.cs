using PokedexXamarin.Dados;
using PokedexXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PokedexXamarin.Viewmodel
{
    public class RegistrarPokemonViewmodel : BaseViewmodel
    {
        #region properties
        private string _txtCorTipos;
        public string TxtCorTipos
        {
            get => _txtCorTipos;
            set => SetProperty(ref _txtCorTipos, value);
        }

        private string _txtCorFundo;
        public string TxtCorFundo
        {
            get => _txtCorFundo;
            set => SetProperty(ref _txtCorFundo, value);
        }

        private string _txtIcone;
        public string TxtIcone
        {
            get => _txtIcone;
            set => SetProperty(ref _txtIcone, value);
        }

        private string _txtNome;
        public string TxtNome
        {
            get => _txtNome;
            set => SetProperty(ref _txtNome, value);
        }

        private string _txtNumOrdem;
        public string TxtNumOrdem
        {
            get => _txtNumOrdem;
            set => SetProperty(ref _txtNumOrdem, value);
        }

        private string _txtTipos;
        public string TxtTipos
        {
            get => _txtTipos;
            set => SetProperty(ref _txtTipos, value);
        }

        public INavigation Navigation { get; }

        #endregion

        #region constructor
        public RegistrarPokemonViewmodel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region commands 
        public ICommand VoltarCommand => new Command(async () => await Voltar());
        public ICommand InserirCommand => new Command(async () => await Inserir());
        #endregion

        #region methods
        public async Task Inserir()
        {
            var function = new Dpokemon();
            var parametros = new Pokemon();

            parametros.CorFundo = TxtCorFundo;
            parametros.CorTipo = TxtCorTipos;
            parametros.Icone = TxtIcone;
            parametros.Nome = TxtNome;
            parametros.NumOrdem = TxtNumOrdem;
            parametros.Tipos = TxtTipos;

            await function.InsertPokemon(parametros); 
            await Voltar();
        }



        public async Task Voltar()
        {
            await Navigation.PopAsync();
        }
        #endregion
    }
}
