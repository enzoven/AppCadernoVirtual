using AppCadernoVirtual.Primeiro;
using AppCadernoVirtual.Segundo;
using AppCadernoVirtual.Terceiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            logo2.Source = ImageSource.FromResource("AppCadernoVirtual.Imagem.logo2.png");

            //Definindo a logo da MainPage
            //this.BackgroundImageSource = ImageSource.FromResource("imagem.jpg");

            
           
           NavigationPage.SetHasNavigationBar(this, false);
        }

       // Todos os eventos de cada botão criado no projeto

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialPrimeiro());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialSegundo ());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialTerceiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialTerceiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialTerceiro());
        }
    }
}
