 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace AppCadernoVirtual.Primeiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialPrimeiro : ContentPage
    {
        public InicialPrimeiro()
        {
            
                InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatematicaPrimeiro());

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaPrimeiro());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaPrimeiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaPrimeiro());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaPrimeiro());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaPrimeiro ());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaPrimeiro());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArtePrimeiro());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimeiro());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EdfisicaPrimeiro());
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PWPrimeiro());
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnaliseSistemasPrimeiro());
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FIPrimeiro());
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BDPrimeiro());
        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TPAprimeiro());
        }

        private void Button_Clicked_16(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DDPrimeiro());
        }
    }
}