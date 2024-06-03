namespace MauiAppecinemas.Categorias.Filmesco;

public partial class Todo : ContentPage
{
	public Todo()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Comedia());
    }
}