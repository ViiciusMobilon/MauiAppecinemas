namespace MauiAppecinemas.Categorias.Filmesdr;

public partial class Milvesez : ContentPage
{
	public Milvesez()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Drama());
    }
}