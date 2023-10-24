namespace TodoDolistExaul.Pages;

public partial class NewMainPage : ContentPage
{
	public NewMainPage()
	{
		
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		// esta linea sirve para hacer la navegacion entre paginas
		
         Navigation.PushAsync(new NewPage());
    }
}