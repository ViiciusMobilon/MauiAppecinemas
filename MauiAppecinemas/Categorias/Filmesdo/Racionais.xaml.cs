namespace MauiAppecinemas.Categorias.Filmesdo;

public partial class Racionais : ContentPage
{
	public Racionais()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Documentario());
    }
}