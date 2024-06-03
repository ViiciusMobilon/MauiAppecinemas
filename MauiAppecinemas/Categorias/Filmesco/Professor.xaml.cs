namespace MauiAppecinemas.Categorias.Filmesco;

public partial class Professor : ContentPage
{
	public Professor()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Comedia());
    }
}