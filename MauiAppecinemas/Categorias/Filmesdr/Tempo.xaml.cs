namespace MauiAppecinemas.Categorias.Filmesdr;

public partial class Tempo : ContentPage
{
	public Tempo()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Drama());
    }
}