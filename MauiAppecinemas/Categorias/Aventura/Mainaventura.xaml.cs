namespace MauiAppecinemas.Categorias.Aventura;

public partial class Mainaventura : ContentPage
{
	public Mainaventura()
	{
		InitializeComponent();
	}
   
    private void velozes_Clicked(object sender, EventArgs e)
    {

    }

    private void ultimo_Clicked(object sender, EventArgs e)
    {

    }

    private void violenta_Clicked(object sender, EventArgs e)
    {

    }

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}