using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaSupermercado
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new View.ListaProduto());
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
