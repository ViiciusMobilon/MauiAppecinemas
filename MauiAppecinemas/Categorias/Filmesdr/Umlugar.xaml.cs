namespace MauiAppecinemas.Categorias.Filmesdr;

public partial class Umlugar : ContentPage
{
	public Umlugar()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Drama());
    }
}