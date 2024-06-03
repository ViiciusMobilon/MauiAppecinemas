namespace MauiAppecinemas.Categorias.Filmesco;

public partial class Debieloide : ContentPage
{
	public Debieloide()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Comedia());
    }
}