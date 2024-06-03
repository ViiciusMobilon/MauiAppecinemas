namespace MauiAppecinemas.Categorias.Filmesdo;

public partial class Coracao : ContentPage
{
	public Coracao()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Documentario());
    }
}