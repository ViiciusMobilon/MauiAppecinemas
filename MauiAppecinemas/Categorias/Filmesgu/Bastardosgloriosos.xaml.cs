namespace MauiAppecinemas.Categorias.Filmesgu;

public partial class Bastardosgloriosos : ContentPage
{
	public Bastardosgloriosos()
	{
		InitializeComponent();
	}

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}