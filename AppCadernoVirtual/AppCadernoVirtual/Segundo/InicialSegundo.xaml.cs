using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Segundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialSegundo : ContentPage
    {
        public InicialSegundo()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesSegundo ());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaSegundo());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaSegundo());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaSegundo());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaSegundo());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaSegundo());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaSegundo());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaSegundo());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaSegundo());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesSegundo());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EdfisiaSegundo());
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EticaSegundo());
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PWSegundo());
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BDSegundo());
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DSSegundo());
        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SESegundo());
        }

        private void Button_Clicked_16(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MobileSegundo());
        }
    }
}