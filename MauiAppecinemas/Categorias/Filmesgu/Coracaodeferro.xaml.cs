namespace MauiAppecinemas.Categorias.Filmesgu;

public partial class Coracaodeferro : ContentPage
{
	public Coracaodeferro()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}