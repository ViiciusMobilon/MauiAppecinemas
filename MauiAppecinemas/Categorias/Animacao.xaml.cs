namespace MauiAppecinemas.Categorias;

public partial class Animacao : ContentPage
{
	public Animacao()
	{
		InitializeComponent();
	}

   

    
    

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    

    private void detona_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesan.Detona());
    }

    private void ter_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesan.sherk());
    }

    private void tom_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesan.Tom());
    }

    private void toy_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesan.Toy());
    }
}