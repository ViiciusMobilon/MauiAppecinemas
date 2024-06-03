namespace MauiAppecinemas.Categorias;

public partial class Documentario : ContentPage
{
	public Documentario()
	{
		InitializeComponent();
	}

    

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void racionais_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesdo.Racionais());
    }

    private void cronica_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesdo.Cronicas());
    }

    private void coracao_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesdo.Coracao());
    }

    private void quem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesdo.Quem());
    }
}