namespace MauiAppecinemas.Categorias.Filmesan;

public partial class sherk : ContentPage
{
	public sherk()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Animacao());
    }
}