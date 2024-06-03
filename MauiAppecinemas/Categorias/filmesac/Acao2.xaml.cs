namespace MauiAppecinemas.Categorias.filmesac;

public partial class Acao2 : ContentPage
{
	public Acao2()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acao());
    }
}