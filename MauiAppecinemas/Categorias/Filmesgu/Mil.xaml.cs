namespace MauiAppecinemas.Categorias.Filmesgu;

public partial class Mil : ContentPage
{
	public Mil()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}