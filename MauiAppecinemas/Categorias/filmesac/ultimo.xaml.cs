namespace MauiAppecinemas.Categorias.filmesac;

public partial class ultimo : ContentPage
{
	public ultimo()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acao());
    }
}