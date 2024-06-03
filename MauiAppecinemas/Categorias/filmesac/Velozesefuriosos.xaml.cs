namespace MauiAppecinemas.Categorias.filmesac;

public partial class Velozesefuriosos : ContentPage
{
	public Velozesefuriosos()
	{
		InitializeComponent();

	}


    private void voltar_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acao());
    }
}