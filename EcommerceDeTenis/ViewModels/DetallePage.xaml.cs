using EcommerceDeTenis.ViewModels;

namespace EcommerceDeTenis.Views;

public partial class DetallePage : ContentPage
{
    public DetallePage(DetalleViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

