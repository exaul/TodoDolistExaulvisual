namespace TodoDolistExaul.Pages;

public partial class NewPage : ContentPage
{
    public NewPage()
    {
        InitializeComponent();

    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        // Utiliza PopAsync para regresar a la página anterior en la pila de navegación
        Navigation.PopAsync();
    }
}