namespace MauiAppecinemas.Categorias.Filmesdo;

public partial class Cronicas : ContentPage
{
	public Cronicas()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Documentario());
    }
}