namespace MauiAppecinemas.Categorias.Filmesgu;

public partial class Ateoultimohomem : ContentPage
{
	public Ateoultimohomem()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}