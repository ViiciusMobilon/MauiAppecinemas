namespace MauiAppecinemas.Categorias;

public partial class Comedia : ContentPage
{
	public Comedia()
	{
		InitializeComponent();
	}



    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void panico_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesco.Todo());
    }

    private void brancas_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesco.Asbranquelas());
    }

    private void debi_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesco.Debieloide());
    }

    private void prof_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmesco.Professor());
    }
}