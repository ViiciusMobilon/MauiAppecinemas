namespace MauiAppecinemas.Categorias;

public partial class Drama : ContentPage
{
	public Drama()
	{
		InitializeComponent();
	}

    

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void milvesez_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesdr.Milvesez());
    }

    private void umlugar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesdr.Umlugar());
    }

    private void tempo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesdr.Tempo());
    }

    private void seguindo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesdr.Seguindo());
    }
}