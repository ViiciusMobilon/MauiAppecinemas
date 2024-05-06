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
            
        }

        private void drama_Clicked(object sender, EventArgs e)
        {

        }

        private void acao_Clicked(object sender, EventArgs e)
        {

        }

        private void animacao_Clicked(object sender, EventArgs e)
        {

        }

        private void terror_Clicked(object sender, EventArgs e)
        {

        }

        private void documentario_Clicked(object sender, EventArgs e)
        {

        }

        private void guerra_Clicked(object sender, EventArgs e)
        {

        }
    }
}

