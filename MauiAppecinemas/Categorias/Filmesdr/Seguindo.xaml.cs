namespace MauiAppecinemas.Categorias.Filmesdr;

public partial class Seguindo : ContentPage
{
	public Seguindo()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Drama());
    }
}