namespace MauiAppecinemas.Categorias.Filmesdo;

public partial class Quem : ContentPage
{
	public Quem()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Documentario());
    }
}