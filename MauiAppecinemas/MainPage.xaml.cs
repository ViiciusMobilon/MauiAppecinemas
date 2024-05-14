using MauiAppecinemas.Categorias;
using MauiAppecinemas.Categorias.Aventura;

namespace MauiAppecinemas
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

       



        private void aventura_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Mainaventura());
        }

        private void Comedia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new comedia());
        }

        private void drama_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new drama());
        }

        private void acao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new acao());
        }

        private void animacao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new animacao());
        }

        private void terror_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new terror());
        }

        private void documentario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new documentario());
        }

        private void guerra_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.guerra.guerra());
        }
    }
}

