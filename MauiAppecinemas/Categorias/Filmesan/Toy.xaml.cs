namespace MauiAppecinemas.Categorias.Filmesan;

public partial class Toy : ContentPage
{
	public Toy()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Animacao());
    }
}