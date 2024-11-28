using EcommerceDeTenis.Models;
using EcommerceDeTenis.ViewModels;

namespace EcommerceDeTenis.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var tenisSeleccionado = e.CurrentSelection.FirstOrDefault() as Tenis;
        if (tenisSeleccionado != null)
        {
            await Navigation.PushAsync(new DetallePage(new DetalleViewModel(tenisSeleccionado)));
        }
    }
}
