namespace MauiAppecinemas.Categorias.Filmesan;

public partial class Tom : ContentPage
{
	public Tom()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Animacao());
    }
}