namespace MauiAppecinemas.Categorias.Filmesan;

public partial class Detona : ContentPage
{
	public Detona()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Animacao());
    }
}