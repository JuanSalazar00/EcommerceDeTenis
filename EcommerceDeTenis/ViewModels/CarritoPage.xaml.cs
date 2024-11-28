using EcommerceDeTenis.ViewModels;

namespace EcommerceDeTenis.Views;

public partial class CarritoPage : ContentPage
{
    public CarritoPage()
    {
        InitializeComponent();
        BindingContext = CarritoViewModel.Instancia; // Vincular al ViewModel compartido
    }
}
