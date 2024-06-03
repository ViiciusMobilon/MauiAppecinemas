namespace MauiAppecinemas.Categorias.Filmesco;

public partial class Asbranquelas : ContentPage
{
	public Asbranquelas()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Comedia());
    }
}