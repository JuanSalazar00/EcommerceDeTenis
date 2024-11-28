using EcommerceDeTenis.Models;
using System.Windows.Input;

namespace EcommerceDeTenis.ViewModels;

public class DetalleViewModel
{
    public Tenis TenisSeleccionado { get; set; }
    public ICommand AgregarAlCarritoCommand { get; }

    public DetalleViewModel(Tenis tenis)
    {
        TenisSeleccionado = tenis;
        AgregarAlCarritoCommand = new Command(() =>
        {
            // Lógica para agregar al carrito
            CarritoViewModel.Instancia.AgregarAlCarrito(tenis);
        });
    }
}
