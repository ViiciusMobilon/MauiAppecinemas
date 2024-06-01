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
            Navigation.PushAsync(new Comedia());
        }

        private void drama_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Drama());
        }

        private void acao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Acao());
        }

        private void animacao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Animacao());
        }

        private void terror_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terror());
        }

        private void documentario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Documentario());
        }

        private void guerra_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Guerra());
        }
    }
}

