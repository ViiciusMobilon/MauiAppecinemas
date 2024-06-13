using MauiAppecinemas.Categorias.Filmesgu;

namespace MauiAppecinemas.Categorias;

public partial class Guerra : ContentPage
{
	public Guerra()
	{
		InitializeComponent();
	}

   

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void coracaodeaco_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Coracaodeferro());
    }

    private void ateoultimo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ateoultimohomem());
    }

    private void mil_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Mil());
    }

    private void bastardos_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Bastardosgloriosos());
    }
}