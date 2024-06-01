namespace MauiAppecinemas.Categorias;

public partial class Acao : ContentPage
{
	public Acao()
	{
		InitializeComponent();
	}

    

    private void voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void velozes_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new filmesac.Velozesefuriosos());

    }

    private void Arranhaceu_Clicked(object sender, EventArgs e)
    {

    }

    private void ultimo_Clicked(object sender, EventArgs e)
    {

    }

    private void Arranhaceu_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Arranhaceu_Clicked_2(object sender, EventArgs e)
    {

    }

    private void Arranhaceu_Clicked_3(object sender, EventArgs e)
    {

    }

    private void ultimo_Clicked_1(object sender, EventArgs e)
    {

    }

    private void violenta_Clicked(object sender, EventArgs e)
    {

    }
}